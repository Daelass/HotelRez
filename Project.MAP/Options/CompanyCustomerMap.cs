using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CompanyCustomerMap : BaseMap<CompanyCustomer>
    {
        public CompanyCustomerMap()
        {
            ToTable("Şirket Müşterileri");
            Property(x => x.FirstName).HasColumnName("İsim");
            Property(x => x.LastName).HasColumnName("Soyİsim");
            Property(x => x.ContactNumber).HasColumnName("İletişim Numarası");
        }
    }
}
