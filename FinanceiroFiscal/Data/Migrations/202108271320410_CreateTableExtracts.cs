namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableExtracts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Extracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Entry = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OutPut = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Extracts");
        }
    }
}
