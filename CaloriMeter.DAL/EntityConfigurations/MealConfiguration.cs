using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieMeter.DAL.EntityConfigurations
{
    public class MealConfiguration : EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            HasRequired(a => a.User).WithMany(b => b.Meals).HasForeignKey(c => c.UserID).WillCascadeOnDelete(false);
        }
    }
}
