using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class FoodService:BaseEntity
    {
        public string FoodName { get; set;}
        public string FoodPrice { get; set;}
        //relational
        public virtual List<FoodServiceWaiter> Waiters { get; set;}// garsonla yemek servisi çoka çoka ilişkide olduğu için listi burada
    }
}
