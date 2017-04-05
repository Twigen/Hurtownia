namespace Kontrachent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullableFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Storehouse", "CENA", c => c.Double());
            AlterColumn("dbo.Storehouse", "CENA2", c => c.Double());
            AlterColumn("dbo.Storehouse", "STANPI", c => c.Double());
            AlterColumn("dbo.Storehouse", "PIK", c => c.Double());
            AlterColumn("dbo.Storehouse", "RIK", c => c.Double());
            AlterColumn("dbo.Storehouse", "STANKI", c => c.Double());
            AlterColumn("dbo.Storehouse", "STANOG", c => c.Double());
            AlterColumn("dbo.Storehouse", "STANPW", c => c.Double());
            AlterColumn("dbo.Storehouse", "PWK", c => c.Double());
            AlterColumn("dbo.Storehouse", "RWK", c => c.Double());
            AlterColumn("dbo.Storehouse", "STANKW", c => c.Double());
            AlterColumn("dbo.Storehouse", "PRZECALL", c => c.Double());
            AlterColumn("dbo.Storehouse", "PIM", c => c.Double());
            AlterColumn("dbo.Storehouse", "RIM", c => c.Double());
            AlterColumn("dbo.Storehouse", "PWM", c => c.Double());
            AlterColumn("dbo.Storehouse", "RWM", c => c.Double());
            AlterColumn("dbo.Storehouse", "STANII", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Storehouse", "STANII", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "RWM", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "PWM", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "RIM", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "PIM", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "PRZECALL", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "STANKW", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "RWK", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "PWK", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "STANPW", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "STANOG", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "STANKI", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "RIK", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "PIK", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "STANPI", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "CENA2", c => c.Double(nullable: false));
            AlterColumn("dbo.Storehouse", "CENA", c => c.Double(nullable: false));
        }
    }
}
