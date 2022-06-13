using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.Model.Entitites
{
    public class ActivityType
    {
        public ActivityType()
        {
            Users = new HashSet<User>();
        }

        public int ActivityID { get; set; }
        public string ActivityName { get; set; }

        public virtual ICollection<User> Users { get; set; }
       //yorum satırı 
	
    }
}
