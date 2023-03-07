using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Room:BaseEntity
    {// oda class'ını açtım
        public string RoomNo { get; set; }// oda numarası
        


        //relational
        public virtual List<RoomReservation> RoomReservations { get; set; }// oda rezervasyon çoka çok ilişkide listi burada
      
        public virtual List<RoomType> RoomTypes { get; set; }
        public virtual List<Guest> Guests { get; set; }



    }
}
