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
        [Fact]
        public void TestClientPropertiesType()
        {
            Type clientType = typeof(Client);

            PropertyInfo pI = clientType.GetProperties().FirstOrDefault(p => p.Name == "Name");
            Type typeToCheck = typeof(string);
            Type typeOfProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeToCheck, typeOfProperty);

            pI = clientType.GetProperties().FirstOrDefault(p => p.Name == "Cpf");
            typeToCheck = typeof(string);
            typeOfProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeToCheck, typeOfProperty);

            pI = clientType.GetProperties().FirstOrDefault(p => p.Name == "Rg");
            typeToCheck = typeof(string);
            typeOfProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeToCheck, typeOfProperty);

            pI = clientType.GetProperties().FirstOrDefault(p => p.Name == "Birthday");
            typeToCheck = typeof(DateTime);
            typeOfProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeToCheck, typeOfProperty);
        }
        [Fact]
        public void TestarSePropriedadeDescricaoGet()
        {
            Client client = new Client();
            Type type = typeof(Client);

            PropertyInfo pI = type.GetProperties().FirstOrDefault(p => p.Name == "Name");
            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(String))
            {

                pI.SetValue(client, "");
                valueProp = pI.GetValue(client);
            }
            Assert.NotNull(valueProp);

            pI = type.GetProperties().FirstOrDefault(p => p.Name == "Cpf");
            valueProp = null;
            if (pI != null && pI.PropertyType == typeof(String))
            {

                pI.SetValue(client, "");
                valueProp = pI.GetValue(client);
            }
            Assert.NotNull(valueProp);

            pI = type.GetProperties().FirstOrDefault(p => p.Name == "Rg");
            valueProp = null;
            if (pI != null && pI.PropertyType == typeof(String))
            {

                pI.SetValue(client, "");
                valueProp = pI.GetValue(client);
            }
            Assert.NotNull(valueProp);

            pI = type.GetProperties().FirstOrDefault(p => p.Name == "Birthday");
            valueProp = null;
            if (pI != null && pI.PropertyType == typeof(DateTime))
            {

                pI.SetValue(client, new DateTime(1999,02,22));
                valueProp = pI.GetValue(client);
            }
            Assert.NotNull(valueProp);
        }
    }
}
