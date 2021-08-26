using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestFinanceiro.Models
{
    public class TestNoteIssue
    {
        [Fact]
        public void TestInhertForBase()
        {
            NoteIssue Note = Activator.CreateInstance<NoteIssue>();
            Assert.IsAssignableFrom<BaseModel>(Note);
        }
        [Fact]
        public void TestInstanceNoteIssue()
        {
            NoteIssue Instance;
            Instance = Activator.CreateInstance<NoteIssue>();
            Assert.IsType<NoteIssue>(Instance);
        }
        [Fact]
        public void TestPropertys()
        {
            NoteIssue Instance;
            Instance = Activator.CreateInstance<NoteIssue>();

            decimal testdecimal = 10.0m;
            int testint = 10;

            Type i = typeof(int);
            Type d = typeof(decimal);

            Instance.Valor = testdecimal;
            Instance.BarCode = testint;

            Assert.IsAssignableFrom(d, Instance.Valor);
            Assert.IsAssignableFrom(i, Instance.BarCode);

            Assert.Equal(testdecimal, Instance.Valor);
            Assert.Equal(testint, Instance.BarCode);
        }
    }
}