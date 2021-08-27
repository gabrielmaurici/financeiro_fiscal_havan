using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestFinanceiro.Models
{
    public abstract class BaseTestInstanceAndInheritance<M> where M:BaseModel
    {
        [Fact]
        public void TestInstanceClass()
        {
            //Assert
            M classTest;
            //Act
            classTest = Activator.CreateInstance<M>();
            //Assert
            Assert.IsAssignableFrom<M>(classTest);
        }
        [Fact]
        public void TestInheritanceBaseModel()
        {
            //Assert
            M classTest;
            //Act
            classTest = Activator.CreateInstance<M>();
            //Assert
            Assert.IsAssignableFrom<BaseModel>(classTest);
        }
    }
}
