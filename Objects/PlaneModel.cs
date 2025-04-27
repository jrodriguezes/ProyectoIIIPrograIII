using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class PlaneModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public byte[] photo { get; set; } // Aquí viene el contenido de la imagen
        public int planeInformationId { get; set; }
        public DateTime created { get; set; }
    }
}
