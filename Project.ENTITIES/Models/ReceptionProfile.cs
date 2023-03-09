﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ReceptionProfile:BaseEntity
    {
        public string FirstName { get; set; }// adı
        public string LastName { get; set; }// soyadı
        public string ContactNumber { get; set; }// iletişim numara
        

        //relational
        public virtual Reception Reception { get; set; }

    }
}