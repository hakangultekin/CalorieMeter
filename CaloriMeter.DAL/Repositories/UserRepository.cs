using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL.Repositories
{
    public class UserRepository
    {
        CalorieMeterDbContext db;
        public UserRepository()
        {
            db = new CalorieMeterDbContext();
        }
    }
}
