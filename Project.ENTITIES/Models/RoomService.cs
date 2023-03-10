﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomService:BaseEntity
    {
        public string Menu { get; set; }
        public string Beverage { get; set; }
        public decimal Price { get; set; }  
        public int? RoomID { get; set; }

        // relational
        public virtual Room Room { get; set; }

    }
}
