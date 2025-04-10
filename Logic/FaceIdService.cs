using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Objects;

namespace Logic
{
    public class FaceIdService
    {
        private readonly FaceClient faceClient;
        private readonly string personGroupId = "usuarios-utn"; // ID personalizado para tus usuarios
        private readonly UserService userService = new UserService();

        public FaceIdService(string endpoint, string key)
        {
            faceClient = new FaceClient(new ApiKeyServiceClientCredentials(key))
            {
                Endpoint = endpoint
            };
        }

        // ✅ Verifica si el grupo existe, y lo crea si no
        public async Task EnsurePersonGroupExists()
        {
            try
            {
                await faceClient.PersonGroup.GetAsync(personGroupId); // Intenta obtenerlo
            }
            catch (APIErrorException ex)
            {
                if (ex.Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    // Si no existe, lo creamos
                    await faceClient.PersonGroup.CreateAsync(
                        personGroupId,
                        name: "Usuarios del sistema",
                        userData: "Grupo para login con Face ID"
                    );
                }
                else
                {
                    throw; // Si es otro error, relanzalo
                }
            }
        }

        // ✅ Método principal para registrar usuario y su rostro
        public async Task RegisterUserAsync(UserModel user, string imagePath)
        {
            // Asegurarse de que el grupo de personas exista en Azure
            await EnsurePersonGroupExists();

            // Crear persona en el grupo
            var person = await faceClient.PersonGroupPerson.CreateAsync(
                personGroupId,
                name: user.name,
                userData: "Registro con Face ID"
            );

            // Guardar el ID único del rostro
            user.faceId = person.PersonId;

            // Subir imagen del rostro
            using (Stream stream = File.OpenRead(imagePath))
            {
                await faceClient.PersonGroupPerson.AddFaceFromStreamAsync(
                    personGroupId,
                    person.PersonId,
                    stream
                );
            }

            // Entrenar al grupo para que reconozca la nueva cara
            await faceClient.PersonGroup.TrainAsync(personGroupId);

            // Guardar el usuario con el faceId en la base de datos
            userService.InsertUser(user);
        }
    }
}
