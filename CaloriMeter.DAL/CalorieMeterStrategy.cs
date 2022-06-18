using CaloriMeter.DAL.SeedConfigurations;
using CaloriMeter.Model.Entitites;
using CaloriMeter.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL
{
    public class CalorieMeterStrategy : CreateDatabaseIfNotExists<CalorieMeterDbContext>
    {
        protected override void Seed(CalorieMeterDbContext context)
        {
            // seed data eklenecek

            //new CategorySeed(context);
            //new ActivityTypeSeed(context);
            //new AdminSeed(context);
            //new MealTypeSeed(context);
            //new FoodSeed(context);

            //context.ActivityTypes.Add(new ActivityType() { ActivityName = "Aktivite Yok" });

            //User admin = new User()
            //{
            //    Name = "admin",
            //    LastName = "admin",
            //    UserName = "admin",
            //    Password = "admin",
            //    UserType = UserType.Admin,
            //    ActivityTypeID = 1,
            //};

            //context.Users.Add(admin);
            //context.SaveChanges();
        }
    }
}
