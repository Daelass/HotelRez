using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomHousekeeper:BaseEntity
    {// oda temizlikçi çoka çok olduğu için junction table burada yer alıyor
        public int RoomID { get; set; }
        public int HouskeeperID { get; set; }
        // relational
        public virtual Room Room { get; set; }
        public virtual HouseKeeper HouseKeeper { get; set; }

    }
}
