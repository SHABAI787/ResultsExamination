namespace ResultsExamination.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables_Conditioner_LightSourse_EngineringTechnicalProvision : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EngineringTechnicalProvisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ventilation = c.Int(nullable: false),
                        HeatingSystem = c.Int(nullable: false),
                        ExistSecuritySystem = c.Boolean(nullable: false),
                        ExistFireAlarm = c.Boolean(nullable: false),
                        ExistTopPremisesWaterConsumption = c.Boolean(nullable: false),
                        ExistJalousie = c.Boolean(nullable: false),
                        ExistCurtains = c.Boolean(nullable: false),
                        ExistOtherShading = c.Boolean(nullable: false),
                        ExistPlacesWithdrawal = c.Boolean(nullable: false),
                        Conditioner_Id = c.Int(),
                        LightSourse_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Conditioners", t => t.Conditioner_Id)
                .ForeignKey("dbo.LightSourses", t => t.LightSourse_Id)
                .Index(t => t.Conditioner_Id)
                .Index(t => t.LightSourse_Id);
            
            CreateTable(
                "dbo.Conditioners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SystemFankoil = c.Boolean(nullable: false),
                        SystemFreon = c.Boolean(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LightSourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AmountLumLamps = c.Int(nullable: false),
                        AmountIncLamps = c.Int(nullable: false),
                        AmountPlacesPeople = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Premises", "EngineringTechnicalProvision_Id", c => c.Int());
            CreateIndex("dbo.Premises", "EngineringTechnicalProvision_Id");
            AddForeignKey("dbo.Premises", "EngineringTechnicalProvision_Id", "dbo.EngineringTechnicalProvisions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Premises", "EngineringTechnicalProvision_Id", "dbo.EngineringTechnicalProvisions");
            DropForeignKey("dbo.EngineringTechnicalProvisions", "LightSourse_Id", "dbo.LightSourses");
            DropForeignKey("dbo.EngineringTechnicalProvisions", "Conditioner_Id", "dbo.Conditioners");
            DropIndex("dbo.EngineringTechnicalProvisions", new[] { "LightSourse_Id" });
            DropIndex("dbo.EngineringTechnicalProvisions", new[] { "Conditioner_Id" });
            DropIndex("dbo.Premises", new[] { "EngineringTechnicalProvision_Id" });
            DropColumn("dbo.Premises", "EngineringTechnicalProvision_Id");
            DropTable("dbo.LightSourses");
            DropTable("dbo.Conditioners");
            DropTable("dbo.EngineringTechnicalProvisions");
        }
    }
}
