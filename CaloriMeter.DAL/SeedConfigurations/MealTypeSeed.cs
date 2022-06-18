using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL.SeedConfigurations
{
    public class MealTypeSeed
    {
        public MealTypeSeed(CalorieMeterDbContext context)
        {
            context.MealTypes.Add(new MealType() { MealTypeName = "Kahvaltı" });
            context.MealTypes.Add(new MealType() { MealTypeName = "Öğle Yemeği" });
            context.MealTypes.Add(new MealType() { MealTypeName = "Akşam Yemeği" });
            context.MealTypes.Add(new MealType() { MealTypeName = "Ara Öğün" });

            context.SaveChanges();
        }
    }
}
