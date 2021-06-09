namespace Test_Locator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrinterandFacilityClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Printers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                        SerialNo = c.String(),
                        MacAddress = c.String(),
                        FacilityId = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facilities", t => t.FacilityId)
                .Index(t => t.FacilityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Printers", "FacilityId", "dbo.Facilities");
            DropIndex("dbo.Printers", new[] { "FacilityId" });
            DropTable("dbo.Printers");
            DropTable("dbo.Facilities");
        }
    }
}
