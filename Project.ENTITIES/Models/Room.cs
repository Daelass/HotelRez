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
        public string RoomNumber { get; set; }// oda numarası
        public string StandartRoom { get; set; }
        public decimal StandartPrice { get; set; }
        public string SingleRoom { get; set; }
        public decimal SinglePrice { get; set; }
        public  string  SuitRoom { get; set; }
        public decimal SuitPrice { get; set; }
        //relational
        public virtual List<RoomReservation> Rooms { get; set; }// oda rezervasyon çoka çok ilişkide listi burada
        public virtual List<RoomHousekeeper> Housekeepers { get; set; }// oda temizlikçi çoka çok ilişkide listi burada
        public virtual List<RoomServiceDetail> RoomServiceDetails { get; set; }// yemek servisi için yapılmış bir list
      
    }
}
