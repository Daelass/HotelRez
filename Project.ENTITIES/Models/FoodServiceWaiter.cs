using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class FoodServiceWaiter:BaseEntity
    {
        public int FoodServiceID { get; set; }// yemek servisi
        public int WaiterID { get; set; }// garson
        //relational
        public virtual FoodService FoodService { get; set; }
        public virtual Waiter Waiter { get; set; }
    }
}
