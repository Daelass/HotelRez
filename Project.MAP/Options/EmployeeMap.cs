﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class EmployeeMap:BaseMap<Reception>
    {
        public EmployeeMap()
        {
            ToTable("Çalışanlar");
            Property(x => x.UserName).HasColumnName("Kullanici Adi");
            Property(x => x.Password).HasColumnName("Şifre");
        }
    }
}
