using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CustomerGuestMap : BaseMap<CustomerGuest>
    {
        public CustomerGuestMap()
        {
            ToTable("Müşteri Misafirleri");
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.GuestID,
                x.CustomerID
            });
        }
    }
}
