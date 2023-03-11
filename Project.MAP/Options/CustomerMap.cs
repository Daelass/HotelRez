using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CustomerMap:BaseMap<Customer>
    {
        public CustomerMap() 
        {
            ToTable("Müşteriler");
            Property(x => x.FirstName).HasColumnName("İsim");
            Property(x => x.LastName).HasColumnName("Soyisim");
            Property(x => x.ContactNumber).HasColumnName("İletişim Numarası");
        }
    }
}
