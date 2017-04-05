namespace Kontrachent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class znakNotRQ : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Storehouse", "ZNAK", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Storehouse", "ZNAK", c => c.String(nullable: false, maxLength: 1));
        }
    }
}
