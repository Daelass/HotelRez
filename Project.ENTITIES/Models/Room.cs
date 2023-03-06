using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Room:BaseEntity,IRoomType
    {// oda class'ını açtım
        public string RoomNumber { get; set; }// oda numarası
        //relational
        public virtual List<RoomReservation> Rooms { get; set; }// oda rezervasyon çoka çok ilişkide listi burada
        public virtual List<RoomHousekeeper> Housekeepers { get; set; }// oda temizlikçi çoka çok ilişkide listi burada
        public virtual List<RoomServiceDetail> RoomServiceDetails { get; set; }// yemek servisi için yapılmış bir list
        public string StandartRoom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SingleRoom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SuitRoom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
