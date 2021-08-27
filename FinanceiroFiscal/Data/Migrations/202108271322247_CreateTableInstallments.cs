namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableInstallments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Installments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParcelQuantity = c.Int(nullable: false),
                        TaxFees = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Installments");
        }
    }
}
