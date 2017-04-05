namespace Kontrachent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Storehouse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Storehouse",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ZNAK = c.String(nullable: false, maxLength: 1),
                        MAGAZ = c.String(maxLength: 2),
                        KTM = c.String(maxLength: 12),
                        CK = c.String(maxLength: 1),
                        NAZWAK = c.String(maxLength: 20),
                        WIELK = c.String(maxLength: 15),
                        CENA = c.Double(nullable: false),
                        CENA2 = c.Double(nullable: false),
                        VAT = c.String(maxLength: 2),
                        JME = c.String(maxLength: 4),
                        STANPI = c.Double(nullable: false),
                        PIK = c.Double(nullable: false),
                        RIK = c.Double(nullable: false),
                        STANKI = c.Double(nullable: false),
                        STANOG = c.Double(nullable: false),
                        STANPW = c.Double(nullable: false),
                        PWK = c.Double(nullable: false),
                        RWK = c.Double(nullable: false),
                        STANKW = c.Double(nullable: false),
                        PRZECALL = c.Double(nullable: false),
                        PIM = c.Double(nullable: false),
                        RIM = c.Double(nullable: false),
                        PWM = c.Double(nullable: false),
                        RWM = c.Double(nullable: false),
                        DATAP = c.DateTime(nullable: false),
                        DATAR = c.DateTime(nullable: false),
                        SPIS = c.DateTime(nullable: false),
                        STANII = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Storehouse");
        }
    }
}
