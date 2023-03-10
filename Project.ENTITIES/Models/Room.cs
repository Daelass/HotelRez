using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Room:BaseEntity
    {
        public string RoomNo { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsOn { get; set; }
        public int? HouseKeeperID { get; set; }
        

        //Relational Properties
        public virtual List<RoomService> RoomServices{ get; set; } //Konugun istediği OdaServisi listesi 
        public virtual List<RoomType> RoomTypes{ get; set; }
        public virtual HouseKeeper HouseKeeper { get; set; }
        public virtual List<RoomDetail> RoomDetails { get; set; } // Reservation Room Claslarının Junction Table listesi




    }
}
