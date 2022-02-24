namespace ResultsExamination.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables_FloorPerformanse_FloorType_ConstructionDefect : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConstructionDefects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Premise_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Premises", t => t.Premise_Id)
                .Index(t => t.Premise_Id);
            
            CreateTable(
                "dbo.FloorPerformanses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FloorTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Premises", "FloorPerformanse_Id", c => c.Int());
            AddColumn("dbo.Premises", "FloorType_Id", c => c.Int());
            CreateIndex("dbo.Premises", "FloorPerformanse_Id");
            CreateIndex("dbo.Premises", "FloorType_Id");
            AddForeignKey("dbo.Premises", "FloorPerformanse_Id", "dbo.FloorPerformanses", "Id");
            AddForeignKey("dbo.Premises", "FloorType_Id", "dbo.FloorTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Premises", "FloorType_Id", "dbo.FloorTypes");
            DropForeignKey("dbo.Premises", "FloorPerformanse_Id", "dbo.FloorPerformanses");
            DropForeignKey("dbo.ConstructionDefects", "Premise_Id", "dbo.Premises");
            DropIndex("dbo.ConstructionDefects", new[] { "Premise_Id" });
            DropIndex("dbo.Premises", new[] { "FloorType_Id" });
            DropIndex("dbo.Premises", new[] { "FloorPerformanse_Id" });
            DropColumn("dbo.Premises", "FloorType_Id");
            DropColumn("dbo.Premises", "FloorPerformanse_Id");
            DropTable("dbo.FloorTypes");
            DropTable("dbo.FloorPerformanses");
            DropTable("dbo.ConstructionDefects");
        }
    }
}
