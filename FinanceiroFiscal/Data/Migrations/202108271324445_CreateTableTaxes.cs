﻿namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableTaxes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Taxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TaxValue = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Taxes");
        }
    }
}
