namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.RestaurantReviews", "ReviewerName");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.RestaurantReviews", "ReviewerName", c => c.String());
        }
    }
}
