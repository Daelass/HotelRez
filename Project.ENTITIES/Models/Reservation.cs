﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation:BaseEntity
    {
        public DateTime RezervationDate { get; set; }
        public DateTime CheckIn { get; set; }// giriş tarihi datetime olarak verdim
        public DateTime CheckOut { get; set; }// çıkış tarihi datetime olarak verdim
        public decimal TotalPrice { get; set; }
        public int? ReceptionID { get; set; }
        public int? CustomerID { get; set; }


        //relational
        public virtual List<RoomDetail> RoomDetails { get; set; }
        public virtual List<GuestDetail> GuestDetails { get; set; }
        public virtual Customer Customer { get; set; }
        
        
}
