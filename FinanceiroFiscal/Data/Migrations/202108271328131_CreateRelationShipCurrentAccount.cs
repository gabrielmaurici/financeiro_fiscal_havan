namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipCurrentAccount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CurrentAccounts", "Extract_Id", c => c.Int());
            CreateIndex("dbo.CurrentAccounts", "Extract_Id");
            AddForeignKey("dbo.CurrentAccounts", "Extract_Id", "dbo.Extracts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CurrentAccounts", "Extract_Id", "dbo.Extracts");
            DropIndex("dbo.CurrentAccounts", new[] { "Extract_Id" });
            DropColumn("dbo.CurrentAccounts", "Extract_Id");
        }
    }
}
