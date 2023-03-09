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
        public int? RoomTypeID { get; set; }

        public int? HouseKeeperID { get; set; }
        //relational
        public virtual List<RoomReservation> RoomReservations { get; set; }// oda rezervasyon çoka çok ilişkide listi burada
      
        public virtual RoomType RoomType { get; set; }
        public virtual List<Guest> Guests { get; set; }
        public virtual HouseKeeper HouseKeeper { get; set; }
       



    }
}
