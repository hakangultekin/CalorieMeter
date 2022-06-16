using CaloriMeter.Model.Entitites;
using CaloriMeter.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL.SeedConfigurations
{
    public class AdminSeed
    {
        public AdminSeed(CalorieMeterDbContext context)
        {
            User admin = new User() 
            {
                Name = "admin",
                LastName = "admin",
                UserName = "admin",
                Password = "admin",
                UserType = UserType.Admin
            };

            context.Users.Add(admin);
            context.SaveChanges();
        }
    }
}
