using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL.Repositories
{
    public class ActivityTypeRepository
    {
        CalorieMeterDbContext db;

        public ActivityTypeRepository()
        {
            db = new CalorieMeterDbContext();
        }

        public List<ActivityType> GetActivities()
        {
            return db.ActivityTypes.ToList();
        }
    }
}
