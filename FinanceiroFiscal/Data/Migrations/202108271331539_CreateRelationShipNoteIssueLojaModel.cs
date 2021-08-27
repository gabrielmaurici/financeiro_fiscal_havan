namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipNoteIssueLojaModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NoteIssues", "LojaModel_Id", c => c.Int());
            CreateIndex("dbo.NoteIssues", "LojaModel_Id");
            AddForeignKey("dbo.NoteIssues", "LojaModel_Id", "dbo.LojaModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NoteIssues", "LojaModel_Id", "dbo.LojaModels");
            DropIndex("dbo.NoteIssues", new[] { "LojaModel_Id" });
            DropColumn("dbo.NoteIssues", "LojaModel_Id");
        }
    }
}
