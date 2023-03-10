using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public  class Reception:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string ReceptionNumber { get; set; }

        // relational properties

        public virtual List<Customer> Customer { get; set; } // Müşteri Listesi BireÇok ilişki sayesinde saglandı.
        public virtual List<Reservation> Reservations { get; set; } //Recepsiyonun yaptıgı rezervasyonların Listesi BireCok ilişki ile saglandı.

    }
}
