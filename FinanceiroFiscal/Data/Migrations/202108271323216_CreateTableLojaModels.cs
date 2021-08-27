namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableLojaModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LojaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CNPJ = c.String(),
                        IE = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LojaModels");
        }
    }
}
