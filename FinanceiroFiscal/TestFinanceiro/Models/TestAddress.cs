using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void TestPropriedadeStateClasseAddress() 
        {
            //Arrange
            Address ad = new Address();
            string resultado = "String";
            //Act
            ad.State = resultado;
            //Assert
            Assert.Equal(resultado, ad.State);
        }

        [Fact]
        public void TestPropriedadeCityClasseAddress()
        {
            //Arrange
            Address ad = new Address();
            string resultado = "String";
            //Act
            ad.City = resultado;
            //Assert
            Assert.Equal(resultado, ad.City);
        }

        [Fact]
        public void TestPropriedadeStreetClasseAddress()
        {
            //Arrange
            Address ad = new Address();
            string resultado = "String";
            //Act
            ad.Street = resultado;
            //Assert
            Assert.Equal(resultado, ad.Street);
        }

        [Fact]
        public void TestPropriedadeNeighborhoodClasseAddress()
        {
            //Arrange
            Address ad = new Address();
            string resultado = "String";
            //Act
            ad.Neighborhood = resultado;
            //Assert
            Assert.Equal(resultado, ad.Neighborhood);
        }
        [Fact]
        public void TestPropriedadeNumberClasseAddress()
        {
            //Arrange
            Address ad = new Address();
            string resultado = "String";
            //Act
            ad.Number = resultado;
            //Assert
            Assert.Equal(resultado, ad.Number);
        }
        [Fact]
        public void TestPropriedadeCEPClasseAddress()
        {
            //Arrange
            Address ad = new Address();
            string resultado = "String";
            //Act
            ad.CEP = resultado;
            //Assert
            Assert.Equal(resultado, ad.CEP);
        }
    }
}
