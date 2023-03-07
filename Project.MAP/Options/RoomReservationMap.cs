﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class RoomReservationMap:BaseMap<RoomReservation>
    {
        public RoomReservationMap()
        {
            ToTable("Oda Rezervasyonlari");
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.RoomID,
                x.ReservationID
            });
        }
    }
}
