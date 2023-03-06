using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class HouseKeeper:Employee
    {
        public  int? EmployeeID { get; set; }
        public virtual List<RoomHousekeeper> Housekeepers { get; set; }// oda temizlikçi çoka çok ilişkide listi burada
    }
}
