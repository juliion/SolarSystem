namespace SolarSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Moons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Age = c.Double(nullable: false),
                        Diameter = c.Double(nullable: false),
                        ApparentMagnitude = c.Double(nullable: false),
                        PhotoPath = c.String(),
                        DocPath = c.String(),
                        PlanetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Planets", t => t.PlanetId, cascadeDelete: true)
                .Index(t => t.PlanetId);
            
            CreateTable(
                "dbo.Planets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        DistanceFromSun = c.Double(nullable: false),
                        Diameter = c.Double(nullable: false),
                        YearLength = c.Double(nullable: false),
                        DayLength = c.Double(nullable: false),
                        PhotoPath = c.String(),
                        DocPath = c.String(),
                        StarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stars", t => t.StarId, cascadeDelete: true)
                .Index(t => t.StarId);
            
            CreateTable(
                "dbo.Stars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Age = c.Double(nullable: false),
                        Diameter = c.Double(nullable: false),
                        Mass = c.String(nullable: false, maxLength: 50),
                        AbsoluteMagnitude = c.Double(nullable: false),
                        SurfaceTemp = c.Double(nullable: false),
                        PhotoPath = c.String(),
                        DocPath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planets", "StarId", "dbo.Stars");
            DropForeignKey("dbo.Moons", "PlanetId", "dbo.Planets");
            DropIndex("dbo.Planets", new[] { "StarId" });
            DropIndex("dbo.Moons", new[] { "PlanetId" });
            DropTable("dbo.Stars");
            DropTable("dbo.Planets");
            DropTable("dbo.Moons");
        }
    }
}
