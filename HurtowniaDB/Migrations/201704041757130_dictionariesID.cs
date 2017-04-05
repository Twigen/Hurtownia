namespace Kontrachent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dictionariesID : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.JmeDictionary", "Kod", c => c.Int(nullable: false, identity: false));
            AlterColumn("dbo.VatDictionary", "Kod", c => c.Int(nullable: false, identity: false));
            
            AddColumn("dbo.JmeDictionary", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.VatDictionary", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.JmeDictionary", "ID");
            AddPrimaryKey("dbo.VatDictionary", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.VatDictionary");
            DropPrimaryKey("dbo.JmeDictionary");
            DropColumn("dbo.VatDictionary", "ID");
            DropColumn("dbo.JmeDictionary", "ID");
            AlterColumn("dbo.VatDictionary", "Kod", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.JmeDictionary", "Kod", c => c.Int(nullable: false, identity: true));
           
            AddPrimaryKey("dbo.VatDictionary", "Kod");
            AddPrimaryKey("dbo.JmeDictionary", "Kod");
        }
    }
}
