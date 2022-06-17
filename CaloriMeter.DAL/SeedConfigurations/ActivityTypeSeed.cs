using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL.SeedConfigurations
{
    public class ActivityTypeSeed
    {
        public ActivityTypeSeed(CalorieMeterDbContext context)
        {
            context.ActivityTypes.Add(new ActivityType() { ActivityName = "Aktivite Yok" });
            context.ActivityTypes.Add(new ActivityType() { ActivityName = "Az Aktif" });
            context.ActivityTypes.Add(new ActivityType() { ActivityName = "Aktif" });
            context.ActivityTypes.Add(new ActivityType() { ActivityName = "Çok Aktif" });
        }
    }
}
