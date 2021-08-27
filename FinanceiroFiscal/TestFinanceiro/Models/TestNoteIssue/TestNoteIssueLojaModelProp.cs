using Data.Models;
using System;

namespace TestFinanceiro.Models.TestNoteIssue
{
    public class TestNoteIssueLojaModelProp : BaseTestProp<NoteIssue>
    {
        public TestNoteIssueLojaModelProp() : base ("LojaModel", typeof(LojaModel), Activator.CreateInstance<LojaModel>())
        {
        }
    }
}
