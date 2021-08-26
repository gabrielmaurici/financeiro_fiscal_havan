using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestFinanceiro.Models
{
    public class TestBaseModel
    {
        [Fact]
        public void TestInstanciacaoBaseModel()
        {
            //Arrange
            Action tb;
            //Act
            tb = () => Activator.CreateInstance<BaseModel>();
            //Assert
            Assert.Throws<MissingMethodException>(tb);
        }
    }
}
