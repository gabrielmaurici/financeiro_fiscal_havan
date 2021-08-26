using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestFinanceiro.Models
{
    public class TestCurrentAccount
    {
        [Fact]
        public void TestInstanceClassCurrentAccount()
        {
            CurrentAccount instance;

            instance = Activator.CreateInstance<CurrentAccount>();

            Assert.IsType<CurrentAccount>(instance);
        }
        [Fact]
        public void TestInherintanceClassCurrentAccountWithBaseModel()
        {
            CurrentAccount instance;

            instance = Activator.CreateInstance<CurrentAccount>();

            Assert.IsAssignableFrom<BaseModel>(instance);
        }

        [Fact]
        public void TestProperdyAccoutnNumberClassCurrentAccount() 
        {
            //Arrange
            CurrentAccount instance = new CurrentAccount(); 
            int resultado = 10;
            //Act
            instance.AccountNumber = resultado;
            //Assert
            Assert.Equal(resultado,instance.AccountNumber);
        }

        [Fact]
        public void TestProperdyLimitClassCurrentAccount()
        {
            //Arrange
            CurrentAccount instance = new CurrentAccount();
            decimal resultado = 265.63m;
            //Act
            instance.Limit = resultado;
            //Assert
            Assert.Equal(resultado, instance.Limit);
            Assert.IsType<decimal>(instance.Limit);
        }
        [Fact]
        public void TestProperdyBalanceClassCurrentAccount()
        {
            //Arrange
            CurrentAccount instance = new CurrentAccount();
            decimal resultado = 265.10m;
            //Act
            instance.Balance = resultado;
            //Assert
            Assert.Equal(resultado, instance.Balance);
            Assert.IsType<decimal>(instance.Balance);
        }

        [Fact]
        public void TestProperdyComposition()
        {
            //Arrange
            CurrentAccount instance = new CurrentAccount();
            Extract extract = new Extract();
            //Act
            instance.Extract = extract;
            //Assert
            Assert.Equal(extract, instance.Extract);
            Assert.IsType<Extract>(instance.Extract);
        }
    }
}
