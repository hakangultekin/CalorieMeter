﻿namespace CalorieMeter.DAL.Migrations
{
    using CaloriMeter.DAL.SeedConfigurations;
    using CaloriMeter.Model.Entitites;
    using CaloriMeter.Model.Enums;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CaloriMeter.DAL.CalorieMeterDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CaloriMeter.DAL.CalorieMeterDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            new CategorySeed(context);
            new ActivityTypeSeed(context);
            new AdminSeed(context);
            new MealTypeSeed(context);
            new FoodSeed(context);
        }
    }
}
