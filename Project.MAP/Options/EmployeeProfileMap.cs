using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class EmployeeProfileMap:BaseMap<EmployeeProfile>
    {
        public EmployeeProfileMap()
        {
            ToTable("Çalişan Profili");
            Property(x => x.FirstName).HasColumnName("Isim");
            Property(x => x.LastName).HasColumnName("SoyIsim");
            Property(x => x.ContactNumber).HasColumnName("İletişim Numarası");
            Property(x =>x.Department).HasColumnName("Departmanı");
            Property(x => x.DepartmentDescription).HasColumnName("Departman Açiklamsı");
            HasRequired(x => x.Employee).WithOptional(x=>x.EmployeeProfile);
        }
    }
}
