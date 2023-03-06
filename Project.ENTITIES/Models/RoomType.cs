using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public abstract class RoomType:BaseEntity
    {// bu class phantom object yaratılmasın diye abstract aldım böylelikle oda tiplerini arttırabiliriz.
        public string RoomPrice { get; set; }// oda ücreti
        public string RoomName { get; set;}// oda adı
    }
}
