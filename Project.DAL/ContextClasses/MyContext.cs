using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new CustomerGuestMap());
            modelBuilder.Configurations.Add(new ReceptionMap());
            modelBuilder.Configurations.Add(new ReceptionProfileMap());
            modelBuilder.Configurations.Add(new GuestMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new RoomReservationMap());
            modelBuilder.Configurations.Add(new RoomTypeMap());
            modelBuilder.Configurations.Add(new HouseKeeperMap());
            modelBuilder.Configurations.Add(new RoomServiceMap());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerGuest> CustomerGuests { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<ReceptionProfile> ReceptionProfiles { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomDetail> RoomReservations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomService> RoomsServices { get; set;}
        public DbSet<HouseKeeper> HouseKeepers { get; set; }




    }
}
