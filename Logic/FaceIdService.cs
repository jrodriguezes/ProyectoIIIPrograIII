using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Objects;


namespace Logic
{
    public class FaceIdService
    {
        private readonly FaceClient faceClient;
        private readonly string personGroupId = "usuarios-utn";
        private readonly UserService userService = new UserService();

        public FaceIdService(string endpoint, string key)
        {
            faceClient = new FaceClient(new ApiKeyServiceClientCredentials(key))
            {
                Endpoint = endpoint
            };
        }

        public async Task RegisterUserAsync(UserModel user, string imagePath)
        {
            // Crear persona en Face API
            var person = await faceClient.PersonGroupPerson.CreateAsync(
                personGroupId,
                name: user.name,
                userData: "Registro con Face ID"
            );

            // Guardar el personId
            user.faceId = person.PersonId;

            using (Stream stream = File.OpenRead(imagePath))
            {
                await faceClient.PersonGroupPerson.AddFaceFromStreamAsync(personGroupId, person.PersonId, stream);
            }

            await faceClient.PersonGroup.TrainAsync(personGroupId);

            // Guardar en BD
            userService.InsertUser(user);                                                                                                             
        }
    }
}
