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
    public class TestContactModel
    {
        [Fact]
        public void TestIntanceContactModel()
        {
            //Arrange
            ContactModel model;
            //Act
            model = new ContactModel();
            //Assert
            Assert.IsType<ContactModel>(model);
        }
        [Fact]
        public void TestIdOfContactModel()
        {
            //Arrange
            ContactModel model;
            int id =1;
            //Act
            model = new ContactModel();
            model.Id = id;
            //Assert
            Assert.Equal(id, model.Id);
        }
        [Fact]
        public void TestPhoneOfContactModel()
        {
            //Arrange
            ContactModel model;
            string phone = "testPhone";
            //Act
            model = new ContactModel();
            model.Phone = phone;
            //Assert
            Assert.Equal(phone, model.Phone);
        }
        [Fact]
        public void TestEmailOfContactModel()
        {
            //Arrange
            ContactModel model;
            string email = "TestEmail";
            //Act
            model = new ContactModel();
            model.email = email;
            //Assert
            Assert.Equal(email, model.email);
        }
    }
}
