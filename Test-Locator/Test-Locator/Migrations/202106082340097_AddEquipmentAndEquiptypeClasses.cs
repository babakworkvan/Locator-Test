namespace Test_Locator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEquipmentAndEquiptypeClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SerialNo = c.String(),
                        Uuid = c.String(),
                        EquipTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EquipTypes", t => t.EquipTypeId, cascadeDelete: true)
                .Index(t => t.EquipTypeId);
            
            CreateTable(
                "dbo.EquipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipments", "EquipTypeId", "dbo.EquipTypes");
            DropIndex("dbo.Equipments", new[] { "EquipTypeId" });
            DropTable("dbo.EquipTypes");
            DropTable("dbo.Equipments");
        }
    }
}
