using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Waiter:Employee
    {//garson
        public virtual  List<RoomServiceDetail> RoomServiceDetails { get; set; }// odaya yapılacak olan yemek servisi için yapılmış bir list
        public virtual List<FoodServiceWaiter> Waiters { get; set; }// garsonla yemek servisi çoka çoka ilişkide olduğu için listi burada
    }
}
