using CaloriMeter.DAL.Repositories;
using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.BLL.Services
{
    public class ActivityTypeService
    {
        ActivityTypeRepository activityTypeRepository;

        public ActivityTypeService()
        {
            activityTypeRepository = new ActivityTypeRepository();
        }

        public List<ActivityType> GetActivities()
        {
            return activityTypeRepository.GetActivities();
        }
    }
}
