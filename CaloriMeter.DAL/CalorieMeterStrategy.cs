using CaloriMeter.DAL.SeedConfigurations;
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
          
            new AdminSeed(context);
            new ActivityTypeSeed(context);
            new CategorySeed(context);
            new FoodSeed(context);
            new MealTypeSeed(context);

            context.SaveChanges();
        }
    }
}
