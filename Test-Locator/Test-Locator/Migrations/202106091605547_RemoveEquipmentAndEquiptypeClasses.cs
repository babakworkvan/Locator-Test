namespace Test_Locator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveEquipmentAndEquiptypeClasses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Equipments", "EquipTypeId", "dbo.EquipTypes");
            DropIndex("dbo.Equipments", new[] { "EquipTypeId" });
            DropTable("dbo.Equipments");
            DropTable("dbo.EquipTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EquipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Equipments", "EquipTypeId");
            AddForeignKey("dbo.Equipments", "EquipTypeId", "dbo.EquipTypes", "Id", cascadeDelete: true);
        }
    }
}
