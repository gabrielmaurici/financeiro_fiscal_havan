namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipNoteIssueTax : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NoteIssues", "Tax_Id", c => c.Int());
            CreateIndex("dbo.NoteIssues", "Tax_Id");
            AddForeignKey("dbo.NoteIssues", "Tax_Id", "dbo.Taxes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NoteIssues", "Tax_Id", "dbo.Taxes");
            DropIndex("dbo.NoteIssues", new[] { "Tax_Id" });
            DropColumn("dbo.NoteIssues", "Tax_Id");
        }
    }
}
