using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class EmployeeProfile:BaseEntity
    {// Employee ile Employee Profile bire bir ilişkidedir.
        public string FirstName { get; set; }// adı
        public string LastName { get; set; }// soyadı
        public string ContactNumber { get; set; }// iletişim numara
        public string Department { get; set; } // departmanı
        public string DepartmentDescription { get; set; }// departman açıklaması 

        //relational
        public virtual Employee Employee { get; set; }

    }
}
