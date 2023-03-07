using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomType:Room
    {
        public string TypeName { get; set; }//oda  tipi adı
        public decimal RoomPrice { get; set; }// oda fiatı

        

        //relational
        public virtual Room Room { get; set; }

    }
}
