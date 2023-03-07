using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public  class Employee:BaseEntity
    {
        

        public string UserName { get; set; }// kullanıcı adı
        public string Password { get; set; }// şifresi

        // relational
        public virtual EmployeeProfile EmployeeProfile { get; set; }
        public virtual List<CompanyCustomer> Guests { get; set; }

    }
}
