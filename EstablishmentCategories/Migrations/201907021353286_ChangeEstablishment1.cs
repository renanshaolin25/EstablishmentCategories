namespace EstablishmentCategories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEstablishment1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Establishments", "cnpj", c => c.String(nullable: false, maxLength: 200));
            CreateIndex("dbo.Establishments", "cnpj", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Establishments", new[] { "cnpj" });
            AlterColumn("dbo.Establishments", "cnpj", c => c.String(nullable: false));
        }
    }
}
