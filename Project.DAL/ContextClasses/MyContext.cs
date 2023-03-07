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
            modelBuilder.Configurations.Add(new CompanyCustomerMap());
            modelBuilder.Configurations.Add(new CompanyCustomerGuestMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeProfileMap());
            modelBuilder.Configurations.Add(new GuestMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new RoomReservationMap());
            modelBuilder.Configurations.Add(new RoomTypeMap());

        }

        public DbSet<CompanyCustomer> CompanyCustomer { get; set; }
        public DbSet<CompanyCustomerGuest> CompanyCustomerGuests { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }




    }
}
