namespace Kontrachent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JmeVatDictionaries : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JmeDictionary",
                c => new
                    {
                        Kod = c.Int(nullable: false ),
                        Jme = c.String(),
                    })
                ;
            
            CreateTable(
                "dbo.VatDictionary",
                c => new
                    {
                        Kod = c.Int(nullable: false),
                        Vat = c.Int(nullable: false),
                    })
                ;
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VatDictionary");
            DropTable("dbo.JmeDictionary");
        }
    }
}
