namespace OrderServiceApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocationId = c.Int(nullable: false),
                        DriverId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.DriverId)
                .ForeignKey("dbo.Locations", t => t.LocationId)
                .ForeignKey("dbo.CarTypes", t => t.TypeId)
                .Index(t => t.LocationId)
                .Index(t => t.DriverId)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Infoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ProviderId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                        CargoId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        ComingDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId)
                .ForeignKey("dbo.Cargoes", t => t.CargoId)
                .ForeignKey("dbo.Companies", t => t.CustomerId)
                .ForeignKey("dbo.Companies", t => t.ProviderId)
                .Index(t => t.CustomerId)
                .Index(t => t.ProviderId)
                .Index(t => t.CarId)
                .Index(t => t.CargoId);
            
            CreateTable(
                "dbo.LocationHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Maps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Markers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocationId = c.Int(nullable: false),
                        InfoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Infoes", t => t.InfoId)
                .ForeignKey("dbo.Locations", t => t.LocationId)
                .Index(t => t.LocationId)
                .Index(t => t.InfoId);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Markers", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Markers", "InfoId", "dbo.Infoes");
            DropForeignKey("dbo.Infoes", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ProviderId", "dbo.Companies");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Companies");
            DropForeignKey("dbo.Orders", "CargoId", "dbo.Cargoes");
            DropForeignKey("dbo.Orders", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Companies", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Cars", "TypeId", "dbo.CarTypes");
            DropForeignKey("dbo.Cars", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Cars", "DriverId", "dbo.Drivers");
            DropIndex("dbo.Markers", new[] { "InfoId" });
            DropIndex("dbo.Markers", new[] { "LocationId" });
            DropIndex("dbo.Orders", new[] { "CargoId" });
            DropIndex("dbo.Orders", new[] { "CarId" });
            DropIndex("dbo.Orders", new[] { "ProviderId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Infoes", new[] { "OrderId" });
            DropIndex("dbo.Companies", new[] { "LocationId" });
            DropIndex("dbo.Cars", new[] { "TypeId" });
            DropIndex("dbo.Cars", new[] { "DriverId" });
            DropIndex("dbo.Cars", new[] { "LocationId" });
            DropTable("dbo.Routes");
            DropTable("dbo.Markers");
            DropTable("dbo.Maps");
            DropTable("dbo.LocationHistories");
            DropTable("dbo.Orders");
            DropTable("dbo.Infoes");
            DropTable("dbo.Companies");
            DropTable("dbo.CarTypes");
            DropTable("dbo.Locations");
            DropTable("dbo.Drivers");
            DropTable("dbo.Cars");
            DropTable("dbo.Cargoes");
        }
    }
}
