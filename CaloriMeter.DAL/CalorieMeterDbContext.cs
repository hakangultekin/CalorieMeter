using CaloriMeter.DAL.EntityConfigurations;
using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL
{
    public class CalorieMeterDbContext : DbContext
    {
        public CalorieMeterDbContext() : base("config")
        {
            Database.SetInitializer(new CalorieMeterStrategy());
        }

        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDetail> MealDetails { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new ActivityTypeConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new MealTypeConfiguration());
        }

    }
}
