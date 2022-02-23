namespace ResultsExamination.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Premises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Height = c.Double(nullable: false),
                        Width = c.Double(nullable: false),
                        Depth = c.Double(nullable: false),
                        Name = c.String(),
                        Num = c.String(),
                        Floor = c.Int(nullable: false),
                        FirstFloor = c.Boolean(nullable: false),
                        LastFloor = c.Boolean(nullable: false),
                        EquipmentStorage = c.String(),
                        HeightCeiling = c.Double(nullable: false),
                        FakeHeightCeiling = c.Double(),
                        WallThickness = c.Double(nullable: false),
                        FakeDepthFloor = c.Double(),
                        PureCeiling = c.Boolean(nullable: false),
                        ExistAntistaticFloor = c.Boolean(nullable: false),
                        DefferenceSizeFloorBetweenCorridor = c.Double(nullable: false),
                        WallPremiseCorridor_Id = c.Int(),
                        WallСovering_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WallPremiseTypes", t => t.WallPremiseCorridor_Id)
                .ForeignKey("dbo.WallСoverings", t => t.WallСovering_Id)
                .Index(t => t.WallPremiseCorridor_Id)
                .Index(t => t.WallСovering_Id);
            
            CreateTable(
                "dbo.WallPremiseTypes",
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
                "dbo.WallСoverings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ResultsExaminationActs", "Premise_Id", c => c.Int());
            CreateIndex("dbo.ResultsExaminationActs", "Premise_Id");
            AddForeignKey("dbo.ResultsExaminationActs", "Premise_Id", "dbo.Premises", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResultsExaminationActs", "Premise_Id", "dbo.Premises");
            DropForeignKey("dbo.Premises", "WallСovering_Id", "dbo.WallСoverings");
            DropForeignKey("dbo.WallPremiseTypes", "Premise_Id", "dbo.Premises");
            DropForeignKey("dbo.Premises", "WallPremiseCorridor_Id", "dbo.WallPremiseTypes");
            DropIndex("dbo.WallPremiseTypes", new[] { "Premise_Id" });
            DropIndex("dbo.Premises", new[] { "WallСovering_Id" });
            DropIndex("dbo.Premises", new[] { "WallPremiseCorridor_Id" });
            DropIndex("dbo.ResultsExaminationActs", new[] { "Premise_Id" });
            DropColumn("dbo.ResultsExaminationActs", "Premise_Id");
            DropTable("dbo.WallСoverings");
            DropTable("dbo.WallPremiseTypes");
            DropTable("dbo.Premises");
        }
    }
}
