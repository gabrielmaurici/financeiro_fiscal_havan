using Data.Models;
using System;

namespace TestFinanceiro.Models.TestNoteIssue
{
    public class TestNoteIssueClientProp : BaseTestProp<NoteIssue>
    {
        public TestNoteIssueClientProp() : base("Client", typeof(Client), Activator.CreateInstance<Client>())
        {
        }
    }
}
