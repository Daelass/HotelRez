using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public abstract class RoomType:BaseEntity
    {
        public decimal RoomPrice { get; set; }
    }
}
