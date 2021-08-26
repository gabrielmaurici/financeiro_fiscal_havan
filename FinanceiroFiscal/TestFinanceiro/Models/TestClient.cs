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
        public void TesteClientPropertiesExist()
        {
            Type clientType = typeof(Client);
            PropertyInfo pI = clientType.GetProperties().FirstOrDefault(p => p.Name == "Name");

            pI = clientType.GetProperties().FirstOrDefault(p => p.Name == "Birthday");
            Assert.NotNull(pI);
            pI = clientType.GetProperties().FirstOrDefault(p => p.Name == "Cpf");
            Assert.NotNull(pI);
            pI = clientType.GetProperties().FirstOrDefault(p => p.Name == "Rg");
            Assert.NotNull(pI);
        }
    }
}
