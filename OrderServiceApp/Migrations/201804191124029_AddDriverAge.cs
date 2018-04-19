namespace OrderServiceApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDriverAge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drivers", "Age");
        }
    }
}
