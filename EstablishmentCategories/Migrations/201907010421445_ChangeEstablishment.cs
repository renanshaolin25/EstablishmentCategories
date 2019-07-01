namespace EstablishmentCategories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEstablishment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Establishments", "registrationDate", c => c.DateTime());
            AlterColumn("dbo.Establishments", "category", c => c.Int());
            AlterColumn("dbo.Establishments", "status", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Establishments", "status", c => c.Int(nullable: false));
            AlterColumn("dbo.Establishments", "category", c => c.Int(nullable: false));
            AlterColumn("dbo.Establishments", "registrationDate", c => c.DateTime(nullable: false));
        }
    }
}
