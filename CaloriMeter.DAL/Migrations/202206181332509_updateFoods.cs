namespace CalorieMeter.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateFoods : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Foods", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "ImageUrl", c => c.String());
        }
    }
}
