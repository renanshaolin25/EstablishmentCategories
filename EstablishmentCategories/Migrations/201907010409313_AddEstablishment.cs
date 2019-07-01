namespace EstablishmentCategories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEstablishment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Establishments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        companyName = c.String(nullable: false),
                        fantasyName = c.String(),
                        cnpj = c.String(nullable: false),
                        email = c.String(),
                        address = c.String(),
                        city = c.String(),
                        state = c.String(),
                        telephone = c.String(),
                        registrationDate = c.DateTime(nullable: false),
                        category = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                        Agency = c.String(),
                        account = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Establishments");
        }
    }
}
