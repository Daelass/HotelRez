using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class SuitType:RoomType
    {
        public int? RoomID { get; set; }
        public virtual Room Room { get; set; }
    }
}
