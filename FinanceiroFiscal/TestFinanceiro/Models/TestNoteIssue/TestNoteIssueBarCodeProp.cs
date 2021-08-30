using Data.Models;

namespace TestFinanceiro.Models.TestNoteIssue
{
    public class TestNoteIssueBarCodeProp : BaseTestProp<NoteIssue>
    {
        public TestNoteIssueBarCodeProp() : base ("BarCode", typeof(int), 15587733)
        {
        }
    }
}
