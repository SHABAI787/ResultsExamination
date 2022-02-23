namespace ResultsExamination.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActExecutors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResultsExaminationActId = c.Int(),
                        Executor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResultsExaminationActs", t => t.ResultsExaminationActId)
                .ForeignKey("dbo.Executors", t => t.Executor_Id)
                .Index(t => t.ResultsExaminationActId)
                .Index(t => t.Executor_Id);
            
            CreateTable(
                "dbo.ResultsExaminationActs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataCreate = c.DateTime(nullable: false),
                        NumObject = c.String(),
                        AddresObject = c.String(),
                        Additionally = c.String(),
                        CommissionConclusion = c.Boolean(nullable: false),
                        ShortcomingEliminate = c.String(),
                        CorrectionPeriodIn = c.DateTime(),
                        CorrectionPeriodOut = c.DateTime(),
                        PlanPremise_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Files", t => t.PlanPremise_Id)
                .Index(t => t.PlanPremise_Id);
            
            CreateTable(
                "dbo.ActRecipients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResultsExaminationActId = c.Int(),
                        Recipient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResultsExaminationActs", t => t.ResultsExaminationActId)
                .ForeignKey("dbo.Recipients", t => t.Recipient_Id)
                .Index(t => t.ResultsExaminationActId)
                .Index(t => t.Recipient_Id);
            
            CreateTable(
                "dbo.Recipients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Person_Id = c.Int(),
                        Post_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persons", t => t.Person_Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .Index(t => t.Person_Id)
                .Index(t => t.Post_Id);
            
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        Name = c.String(),
                        MiddleName = c.String(),
                        DataBirth = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Data = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Executors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Person_Id = c.Int(),
                        Post_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persons", t => t.Person_Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .Index(t => t.Person_Id)
                .Index(t => t.Post_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActExecutors", "Executor_Id", "dbo.Executors");
            DropForeignKey("dbo.Executors", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Executors", "Person_Id", "dbo.Persons");
            DropForeignKey("dbo.ResultsExaminationActs", "PlanPremise_Id", "dbo.Files");
            DropForeignKey("dbo.ActRecipients", "Recipient_Id", "dbo.Recipients");
            DropForeignKey("dbo.Recipients", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Recipients", "Person_Id", "dbo.Persons");
            DropForeignKey("dbo.ActRecipients", "ResultsExaminationActId", "dbo.ResultsExaminationActs");
            DropForeignKey("dbo.ActExecutors", "ResultsExaminationActId", "dbo.ResultsExaminationActs");
            DropIndex("dbo.Executors", new[] { "Post_Id" });
            DropIndex("dbo.Executors", new[] { "Person_Id" });
            DropIndex("dbo.Recipients", new[] { "Post_Id" });
            DropIndex("dbo.Recipients", new[] { "Person_Id" });
            DropIndex("dbo.ActRecipients", new[] { "Recipient_Id" });
            DropIndex("dbo.ActRecipients", new[] { "ResultsExaminationActId" });
            DropIndex("dbo.ResultsExaminationActs", new[] { "PlanPremise_Id" });
            DropIndex("dbo.ActExecutors", new[] { "Executor_Id" });
            DropIndex("dbo.ActExecutors", new[] { "ResultsExaminationActId" });
            DropTable("dbo.Executors");
            DropTable("dbo.Files");
            DropTable("dbo.Posts");
            DropTable("dbo.Persons");
            DropTable("dbo.Recipients");
            DropTable("dbo.ActRecipients");
            DropTable("dbo.ResultsExaminationActs");
            DropTable("dbo.ActExecutors");
        }
    }
}
