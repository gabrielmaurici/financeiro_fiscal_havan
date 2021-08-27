namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipNoteIssueClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NoteIssues", "Client_Id", c => c.Int());
            CreateIndex("dbo.NoteIssues", "Client_Id");
            AddForeignKey("dbo.NoteIssues", "Client_Id", "dbo.Clients", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NoteIssues", "Client_Id", "dbo.Clients");
            DropIndex("dbo.NoteIssues", new[] { "Client_Id" });
            DropColumn("dbo.NoteIssues", "Client_Id");
        }
    }
}
