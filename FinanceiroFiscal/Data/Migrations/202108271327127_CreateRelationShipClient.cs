namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "CurrentAccount_Id", c => c.Int());
            CreateIndex("dbo.Clients", "CurrentAccount_Id");
            AddForeignKey("dbo.Clients", "CurrentAccount_Id", "dbo.CurrentAccounts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "CurrentAccount_Id", "dbo.CurrentAccounts");
            DropIndex("dbo.Clients", new[] { "CurrentAccount_Id" });
            DropColumn("dbo.Clients", "CurrentAccount_Id");
        }
    }
}
