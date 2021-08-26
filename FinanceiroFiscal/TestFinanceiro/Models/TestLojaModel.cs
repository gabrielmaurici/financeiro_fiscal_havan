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
    public class TestLojaModel
    {
        [Fact]
        public void TestIntanceStoreModel()
        {
            //Arrange
            LojaModel loja;
            //Act
            loja = new LojaModel();
            //Assert
            Assert.IsType<LojaModel>(loja);
        }
        [Fact]
        public void TestOfHeritageForStoreModel()
        {
            //Arrange
            LojaModel loja;
            //Act
            loja = new LojaModel();
            //Assert
            Assert.IsAssignableFrom<BaseModel>(loja);
        }

        [Fact]
        public void TestOfNameOfStoreMode()
        {
            //Arrange
            LojaModel loja;
            string nome = "test";
            //Act
            loja = new LojaModel();
            loja.Nome = nome;
            //Assert
            Assert.Equal(nome, loja.Nome);
        }
        [Fact]
        public void TestOfCnpjOfStoreModel()
        {
            //Arrenge
            LojaModel loja;
            string cnpj = "test";
            //Act
            loja = new LojaModel();
            loja.CNPJ = cnpj;
            //Assert
            Assert.Equal(cnpj, loja.CNPJ);
        }
        [Fact]
        public void TestOfTypeForCnpjOfStroreModel()
        {
            //Arrenge
            LojaModel loja;
            //Act 
            loja = new LojaModel();
            loja.CNPJ = "";
            //Assert
            Assert.IsType<string>(loja.CNPJ);
        }
        [Fact]
        public void TestOfIeOfStoreModel()
        {
            //Arrange
            LojaModel loja;
            string ie = "tets";
            //Act
            loja = new LojaModel();
            loja.IE = ie;
            //Assert
            Assert.Equal(ie, loja.IE);
        }
        [Fact]
        public void TestOfTypeForIeOfStroreModel()
        {
            //Arrenge
            LojaModel loja;
            //Act 
            loja = new LojaModel();
            loja.IE = "";
            //Assert
            Assert.IsType<string>(loja.IE);
        }
        [Fact]
        public void TestOfAddressOfStoreModel()
        {
            //Arrange
            LojaModel loja;
            Address address;
            //Act
            address = new Address();
            loja = new LojaModel();
            loja.Addres = address;
            //Assert
            Assert.Equal(address, loja.Addres);
        }
        [Fact]
        public void TestOfTypeForAddressOfStroreModel()
        {
            //Arrenge
            LojaModel loja;
            //Act 
            loja = new LojaModel();
            loja.Addres = new Address();
            //Assert
            Assert.IsType<Address>(loja.Addres);
        }
        [Fact]
        public void TestOfContactOfStoreModel()
        {
            //Arrange
            LojaModel loja;
            ContactModel contact;
            //Act
            contact = new ContactModel();
            loja = new LojaModel();
            loja.Contact = contact;
            //Assert
            Assert.Equal(contact, loja.Contact);
        }
        [Fact]
        public void TestOfTypeForContactOfStroreModel()
        {
            //Arrenge
            LojaModel loja;
            //Act 
            loja = new LojaModel();
            loja.Contact = new ContactModel();
            //Assert
            Assert.IsType<ContactModel>(loja.Contact);
        }
        [Fact]
        public void TestOfCurrentForStoreModel()
        {
            //Arrenge
            LojaModel loja;
            CurrentAccount currentAccount;
            //Act
            currentAccount = new CurrentAccount();
            loja = new LojaModel();
            loja.Current = currentAccount;
            //Assert
            Assert.Equal(currentAccount, loja.Current);
        }
        [Fact]
        public void TestOfTypeForCurrentOfStroreModel()
        {
            //Arrenge
            LojaModel loja;

            //Act
            loja = new LojaModel();
            loja.Current = new CurrentAccount();
            //Assert
            Assert.IsType<CurrentAccount>(loja.Current);
        }

    }
}
