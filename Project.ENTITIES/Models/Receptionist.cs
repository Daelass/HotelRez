using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Receptionist:Employee
    {// resepsiyonist 
        public string UserName { get; set; }// kullanıcı adı
        public string Password { get; set; }// şifre
        // relational 
        public virtual ReceptionistProfile ReceptionistProfile { get; set; }
        public virtual List<Guest> Guests { get; set; }// müşteri listesi bire çok ilşkiden dolayı burada
      
    }
}
