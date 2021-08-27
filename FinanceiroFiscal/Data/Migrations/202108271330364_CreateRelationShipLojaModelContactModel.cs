namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipLojaModelContactModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LojaModels", "Contact_Id", c => c.Int());
            CreateIndex("dbo.LojaModels", "Contact_Id");
            AddForeignKey("dbo.LojaModels", "Contact_Id", "dbo.ContactModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LojaModels", "Contact_Id", "dbo.ContactModels");
            DropIndex("dbo.LojaModels", new[] { "Contact_Id" });
            DropColumn("dbo.LojaModels", "Contact_Id");
        }
    }
}
