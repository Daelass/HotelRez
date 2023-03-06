using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    interface IRoomType
    {
        string StandartRoom { get; set; }
        string SingleRoom { get; set; }
        string SuitRoom { get; set; }

    }
}
