namespace OrderServiceApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarColor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Color", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Color");
        }
    }
}
