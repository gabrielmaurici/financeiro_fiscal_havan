using Data;
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
    public class TestAddress
    {
        [Fact]
        public void TestInstanceClassAddress()
        {
            Address instance;

            instance = Activator.CreateInstance<Address>();

            Assert.IsType<Address>(instance);
        }
        [Fact]
        public void TestInherintanceClassAddresWithBaseModel()
        {
            Address instance;

            instance = Activator.CreateInstance<Address>();

            Assert.IsAssignableFrom<BaseModel>(instance);
        }

        [Fact]
        public void TestPropriedadeStateClasseAddressExiste()
        {
            //Arrange
            Type t = typeof(Address);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "State");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestarSePropriedadeStateEString()
        {
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "State");
            Type typeString = typeof(string);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestarSePropriedadeStateGetSet()
        {
            Address s = new Address();
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "State");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(String))
            {

                pI.SetValue(s, "");
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
        [Fact]
        public void TestPropriedadeCityClasseAddressExiste()
        {
            //Arrange
            Type t = typeof(Address);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "City");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestarSePropriedadeCityEString()
        {
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "City");
            Type typeString = typeof(string);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestarSePropriedadeCityGetSet()
        {
            Address s = new Address();
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "City");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(String))
            {

                pI.SetValue(s, "");
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
        [Fact]
        public void TestPropriedadeStreetClasseAddressExiste()
        {
            //Arrange
            Type t = typeof(Address);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Street");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestarSePropriedadeStreetEString()
        {
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Street");
            Type typeString = typeof(string);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestarSePropriedadeStreetGetSet()
        {
            Address s = new Address();
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Street");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(String))
            {

                pI.SetValue(s, "");
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
        [Fact]
        public void TestPropriedadeNeighborhoodClasseAddressExiste()
        {
            //Arrange
            Type t = typeof(Address);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Neighborhood");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestarSePropriedadeNeighborhoodEString()
        {
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Neighborhood");
            Type typeString = typeof(string);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestarSePropriedadeNeighborhoodGetSet()
        {
            Address s = new Address();
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Neighborhood");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(String))
            {

                pI.SetValue(s, "");
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
        [Fact]
        public void TestPropriedadeNumberClasseAddressExiste()
        {
            //Arrange
            Type t = typeof(Address);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Number");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestarSePropriedadeNumberEString()
        {
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Number");
            Type typeString = typeof(string);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestarSePropriedadeNumberGetSet()
        {
            Address s = new Address();
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Number");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(String))
            {

                pI.SetValue(s, "");
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }

        [Fact]
        public void TestPropriedadeCEPClasseAddressExiste()
        {
            //Arrange
            Type t = typeof(Address);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "CEP");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestarSePropriedadeCEPEString()
        {
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "CEP");
            Type typeString = typeof(string);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestarSePropriedadeCEPGetSet()
        {
            Address s = new Address();
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "CEP");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(String))
            {

                pI.SetValue(s, "");
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        } 
    }
}
