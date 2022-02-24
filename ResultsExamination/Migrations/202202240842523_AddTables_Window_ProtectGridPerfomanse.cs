namespace ResultsExamination.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables_Window_ProtectGridPerfomanse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Windows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AmmountGlass = c.Int(nullable: false),
                        AmmountTransom = c.Int(nullable: false),
                        IsWoodMaterial = c.Boolean(nullable: false),
                        IsPlasticMaterial = c.Boolean(nullable: false),
                        Height = c.Double(nullable: false),
                        Width = c.Double(nullable: false),
                        ProtectGridPerfomanse_Id = c.Int(),
                        Premise_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProtectGridPerfomanses", t => t.ProtectGridPerfomanse_Id)
                .ForeignKey("dbo.Premises", t => t.Premise_Id)
                .Index(t => t.ProtectGridPerfomanse_Id)
                .Index(t => t.Premise_Id);
            
            CreateTable(
                "dbo.ProtectGridPerfomanses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Windows", "Premise_Id", "dbo.Premises");
            DropForeignKey("dbo.Windows", "ProtectGridPerfomanse_Id", "dbo.ProtectGridPerfomanses");
            DropIndex("dbo.Windows", new[] { "Premise_Id" });
            DropIndex("dbo.Windows", new[] { "ProtectGridPerfomanse_Id" });
            DropTable("dbo.ProtectGridPerfomanses");
            DropTable("dbo.Windows");
        }
    }
}
