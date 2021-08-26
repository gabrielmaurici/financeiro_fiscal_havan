using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestFinanceiro.Models
{
    public class TestClient
    {
        [Fact]
        public void TestClientClassInheritance()
        {
            Client c;

            c = Activator.CreateInstance<Client>();

            Assert.IsAssignableFrom<BaseModel>(c);
        }
        [Fact]
        public void TestClientClassInstancing()
        {
            Client c;
            
            c = Activator.CreateInstance<Client>();

            Assert.IsType<Client>(c);
        }
        [Fact]
        public void TestClientProperties()
        {
            Client c;
            string setString = "a";
            DateTime d = new DateTime(1999, 08, 22);
            var st = typeof(string);
            var dt = typeof(DateTime);

            c = Activator.CreateInstance<Client>();
            c.Name = setString;
            c.Cpf = setString;
            c.Rg = setString;
            c.Birthday = d;

            //var assignName = c.Name;
            //var assignCpf = c.Cpf;
            //var assignRg = c.Rg;
            //var assignBirthday = c.Birthday;

            //TypeTestSet
            Assert.IsAssignableFrom( st, c.Name);
            Assert.IsAssignableFrom( st, c.Cpf);
            Assert.IsAssignableFrom( st, c.Rg);
            Assert.IsAssignableFrom( dt, c.Birthday);
            //AssignTestSet
            Assert.NotEqual<string>("", c.Name);
            Assert.NotEqual<string>("", c.Cpf);
            Assert.NotEqual<string>("", c.Rg);
            Assert.Equal<DateTime>(d, c.Birthday);
            //TypeTestGet
            //Assert.IsAssignableFrom(c.Name.GetType(), assignName);
            //Assert.IsAssignableFrom(c.Cpf.GetType(), assignCpf);
            //Assert.IsAssignableFrom(c.Rg.GetType(), assignRg);
            //Assert.IsAssignableFrom(c.Birthday.GetType(), assignBirthday);
            //AssignTestGet
        }
    }
}
