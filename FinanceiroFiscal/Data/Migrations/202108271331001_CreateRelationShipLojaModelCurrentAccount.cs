namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipLojaModelCurrentAccount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LojaModels", "Current_Id", c => c.Int());
            CreateIndex("dbo.LojaModels", "Current_Id");
            AddForeignKey("dbo.LojaModels", "Current_Id", "dbo.CurrentAccounts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LojaModels", "Current_Id", "dbo.CurrentAccounts");
            DropIndex("dbo.LojaModels", new[] { "Current_Id" });
            DropColumn("dbo.LojaModels", "Current_Id");
        }
    }
}
