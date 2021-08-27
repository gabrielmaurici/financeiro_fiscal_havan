using Data.Models;
using System;

namespace TestFinanceiro.Models.TestNoteIssue
{
    public class TesteNoteIssueTaxProp : BaseTestProp<NoteIssue>
    {
        public TesteNoteIssueTaxProp() : base ("Tax", typeof(Tax), Activator.CreateInstance<Tax>())
        {
        }
    }
}
