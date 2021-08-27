namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipLojaModelAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LojaModels", "Addres_Id", c => c.Int());
            CreateIndex("dbo.LojaModels", "Addres_Id");
            AddForeignKey("dbo.LojaModels", "Addres_Id", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LojaModels", "Addres_Id", "dbo.Addresses");
            DropIndex("dbo.LojaModels", new[] { "Addres_Id" });
            DropColumn("dbo.LojaModels", "Addres_Id");
        }
    }
}
