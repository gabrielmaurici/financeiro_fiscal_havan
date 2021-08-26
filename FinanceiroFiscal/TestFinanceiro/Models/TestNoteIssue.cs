using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public void TestofPropertsExists()
        {
            Type t = typeof(NoteIssue);
            
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Valor");
            PropertyInfo pI1 = t.GetProperties().FirstOrDefault(p => p.Name == "BarCode");
            Assert.NotNull(pI);
            Assert.NotNull(pI1);
        }
        [Fact]
        public void TestifPropertyIsIntOrDecimal()
        {
            Type t = typeof(NoteIssue);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Valor");
            Type typeString = typeof(decimal);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeString, typeProperty);

            PropertyInfo pI1 = t.GetProperties().FirstOrDefault(p => p.Name == "BarCode");
            Type typeString1 = typeof(int);
            Type typeProperty1 = pI1 != null ? pI1.PropertyType : null;
            Assert.Equal(typeString1, typeProperty1);
        }
        [Fact]
        public void TestPropertyGet()
        {
            //Test decimal
            NoteIssue s = new NoteIssue();
            Type t = typeof(NoteIssue);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "Valor");
            object valueprop = null;
            if (pi != null && pi.PropertyType == typeof(Decimal))
            {
                pi.SetValue(s, 10m);
                valueprop = pi.GetValue(s);
            }
            Assert.NotNull(valueprop);
            //Test int
            NoteIssue d = new NoteIssue();
            Type R = typeof(NoteIssue);
            PropertyInfo pi1 = R.GetProperties().FirstOrDefault(p => p.Name == "BarCode");
            object valueprop1 = null;
            if (pi1 != null && pi1.PropertyType == typeof(int))
            {
                pi1.SetValue(d, 11);
                valueprop1 = pi1.GetValue(d);
            }
            Assert.NotNull(valueprop1);
        }
    }
}