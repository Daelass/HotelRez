using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public abstract class Employee:BaseEntity
    {
        public string FirstName { get; set; }// adı
        public string LastName { get; set; }// soyadı
        public  string ContactNumber{ get; set; }// iletişim numara

        public virtual List<FoodServiceWaiter> Waiters { get; set; }// garson listi burada verildi
        public virtual List<HouseKeeper> HouseKeepers { get; set; }// hizmetli listi burada verildi
        public virtual List<Receptionist> Receptionists { get; set;}// resepsiyonist listi burada verildi
       
    }
}
