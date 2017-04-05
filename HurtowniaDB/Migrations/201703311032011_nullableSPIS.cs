namespace Kontrachent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullableSPIS : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Storehouse", "SPIS", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Storehouse", "SPIS", c => c.DateTime(nullable: false));
        }
    }
}
