using Data.Models;
using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace TestFinanceiro.Models
{
    public abstract class TestBase<M> where M:BaseModel
    {
        public string propName { get; set; }
        public Type T { get; set; }
        public TestBase(string name, Type type)
        {
            this.propName = name;
            this.T = type;
        }

        [Fact]
        public void TestInstanceTaxModel()
        {
            //Arrange
            M classTest;
            //Act
            classTest = Activator.CreateInstance<M>();
            //Assert
            Assert.IsAssignableFrom<M>(classTest);
        }

        [Fact]
        public void TestInheritanceBaseModel()
        {
            //Arrange
            M classTest;
            //Act
            classTest = Activator.CreateInstance<M>();
            //Assert
            Assert.IsAssignableFrom<BaseModel>(classTest);
        }

        [Fact]
        public void TestExistentialPropInModel()
        {
            //Arrange
            Type classType = typeof(M);
            //Act
            PropertyInfo classProp = classType.GetProperties().FirstOrDefault(p => p.Name == this.propName);
            //Assert
            Assert.NotNull(classProp);
        }

        [Fact]
        public void TestTypePropInModel()
        {
            //Arrange
            Type classType = typeof(M);
            //Act
            PropertyInfo classProp = classType.GetProperties().FirstOrDefault(p => p.Name == this.propName);
            Type propType = classProp != null ? classProp.PropertyType : null;
            //Assert
            Assert.Equal(this.T, propType);
        }

        [Fact]
        public void TestGetSetPropNameTaxModel()
        {
            //Arrange
            M classTest = Activator.CreateInstance<M>();
            Type classType = typeof(M);
            object valueProp = null;
            //Act
            PropertyInfo classProp = classType.GetProperties().FirstOrDefault(p => p.Name == this.propName);
            if(classProp != null && classProp.PropertyType == this.T)
            {
                classProp.SetValue(classTest, "OK");
                valueProp = classProp.GetValue(classTest);
            }
            //Assert
            Assert.NotNull(valueProp);
        }

    }
}