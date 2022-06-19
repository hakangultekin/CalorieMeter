namespace CalorieMeter.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbdb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MealDetails", "MealID", "dbo.Meals");
            DropIndex("dbo.MealDetails", new[] { "MealID" });
            AlterColumn("dbo.MealDetails", "MealID", c => c.Int());
            CreateIndex("dbo.MealDetails", "MealID");
            AddForeignKey("dbo.MealDetails", "MealID", "dbo.Meals", "MealID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MealDetails", "MealID", "dbo.Meals");
            DropIndex("dbo.MealDetails", new[] { "MealID" });
            AlterColumn("dbo.MealDetails", "MealID", c => c.Int(nullable: false));
            CreateIndex("dbo.MealDetails", "MealID");
            AddForeignKey("dbo.MealDetails", "MealID", "dbo.Meals", "MealID", cascadeDelete: true);
        }
    }
}
