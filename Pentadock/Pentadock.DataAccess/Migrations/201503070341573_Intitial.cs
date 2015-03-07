namespace Pentadock.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kiddoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        WeeklyAllowance_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WeeklyAllowances", t => t.WeeklyAllowance_Id)
                .Index(t => t.WeeklyAllowance_Id);
            
            CreateTable(
                "dbo.WeeklyAllowances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeeklyStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WeekBeginning = c.DateTime(nullable: false),
                        AmountEarned = c.Double(nullable: false),
                        Kiddo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kiddoes", t => t.Kiddo_Id)
                .Index(t => t.Kiddo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeeklyStatus", "Kiddo_Id", "dbo.Kiddoes");
            DropForeignKey("dbo.Kiddoes", "WeeklyAllowance_Id", "dbo.WeeklyAllowances");
            DropIndex("dbo.WeeklyStatus", new[] { "Kiddo_Id" });
            DropIndex("dbo.Kiddoes", new[] { "WeeklyAllowance_Id" });
            DropTable("dbo.WeeklyStatus");
            DropTable("dbo.WeeklyAllowances");
            DropTable("dbo.Kiddoes");
        }
    }
}
