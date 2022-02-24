namespace ResultsExamination.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables_Door_DoorMaterial_FakeFloorMaterial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Single = c.Boolean(nullable: false),
                        Dual = c.Boolean(nullable: false),
                        ExistLock = c.Boolean(nullable: false),
                        Height = c.Double(nullable: false),
                        Width = c.Double(nullable: false),
                        Thickness = c.Double(nullable: false),
                        ExistSeal = c.Boolean(nullable: false),
                        WidthTambour = c.Double(nullable: false),
                        Material_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DoorMaterials", t => t.Material_Id)
                .Index(t => t.Material_Id);
            
            CreateTable(
                "dbo.DoorMaterials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FakeFloorMaterials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Premises", "Door_Id", c => c.Int());
            AddColumn("dbo.Premises", "FakeFloorMaterial_Id", c => c.Int());
            CreateIndex("dbo.Premises", "Door_Id");
            CreateIndex("dbo.Premises", "FakeFloorMaterial_Id");
            AddForeignKey("dbo.Premises", "Door_Id", "dbo.Doors", "Id");
            AddForeignKey("dbo.Premises", "FakeFloorMaterial_Id", "dbo.FakeFloorMaterials", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Premises", "FakeFloorMaterial_Id", "dbo.FakeFloorMaterials");
            DropForeignKey("dbo.Premises", "Door_Id", "dbo.Doors");
            DropForeignKey("dbo.Doors", "Material_Id", "dbo.DoorMaterials");
            DropIndex("dbo.Doors", new[] { "Material_Id" });
            DropIndex("dbo.Premises", new[] { "FakeFloorMaterial_Id" });
            DropIndex("dbo.Premises", new[] { "Door_Id" });
            DropColumn("dbo.Premises", "FakeFloorMaterial_Id");
            DropColumn("dbo.Premises", "Door_Id");
            DropTable("dbo.FakeFloorMaterials");
            DropTable("dbo.DoorMaterials");
            DropTable("dbo.Doors");
        }
    }
}
