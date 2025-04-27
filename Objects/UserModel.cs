using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class UserModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string genre { get; set; }
        public DateTime birthday { get; set; }
        public int age { get; set; }
        public string password { get; set; }
        // Cambiar a nullable Guid para permitir valores NULL (?)
        public Guid? faceId { get; set; }
        public int role {  get; set; }
        public int clientType { get; set; }
        public int status {  get; set; }
    }
}
