namespace GUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Input = c.Boolean(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Topic = c.String(),
                        Description = c.String(),
                        Caller_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.Caller_Id)
                .Index(t => t.Caller_Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SecondName = c.String(),
                        FirstName = c.String(),
                        MidleName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Nick = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Calls", "Caller_Id", "dbo.Contacts");
            DropIndex("dbo.Calls", new[] { "Caller_Id" });
            DropTable("dbo.Contacts");
            DropTable("dbo.Calls");
        }
    }
}
