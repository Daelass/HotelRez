using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomServiceDetail:BaseEntity
    {// oda ve garson çoka çok ilişkide ve daha kapsamlı bir junctin table yaratabilmek için detay olarak adlandırdım
        // roomService detail dememin nedeni daha sonra başka IDleri de daha rahat ekleyebilmek içim composite keylerde kullanmak çok daha kolay ve rahat olur.
        public int RoomID { get; set; }
        public int WaiterID { get; set; }
        // relational
        public virtual Room Room { get; set; }
        public virtual Waiter  Waiter { get; set;}
    }
}
