using Data.Models;

namespace TestFinanceiro.Models.TestNoteIssue
{
    public class TestNoteIssueValorProp : BaseTestProp<NoteIssue>
    {
        public TestNoteIssueValorProp() : base ("Valor", typeof(decimal), 1044.55m)
        {
        }
    }
}
