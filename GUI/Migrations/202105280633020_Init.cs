namespace GUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calls", "IsInput", c => c.Boolean(nullable: false));
            DropColumn("dbo.Calls", "Input");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Calls", "Input", c => c.Boolean(nullable: false));
            DropColumn("dbo.Calls", "IsInput");
        }
    }
}
