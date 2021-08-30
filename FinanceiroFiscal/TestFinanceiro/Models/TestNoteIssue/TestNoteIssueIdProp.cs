using Data.Models;

namespace TestFinanceiro.Models.TestNoteIssue
{
    public class TestNoteIssueIdProp : BaseTestProp<NoteIssue>
    {
        public TestNoteIssueIdProp() : base ("Id", typeof(int), 50)
        {
        }
    }
}
