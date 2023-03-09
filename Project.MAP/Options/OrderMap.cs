﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class OrderMap:BaseMap<Order>
    {
        public OrderMap()
        {
            ToTable("Siparişler");
            Property(x =>x.OrderName).HasColumnName("Sipariş Adı");
          
            
        }
    }
}
