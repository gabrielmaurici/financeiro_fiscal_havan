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
    public abstract class BaseTestProp<M> where M : BaseModel
    {
        public string propName { get; set; }
        public Type T { get; set; }
        public object valueTest { get; set; }
        public BaseTestProp(string name, Type type, object value)
        {
            this.propName = name;
            this.T = type;
            if(value != null)
            {
                valueTest = value.GetType()==type ? value : null;

            }
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
        public void TestGetSetPropInModel()
        {
            //Arrange
            M classTest = Activator.CreateInstance<M>();
            Type classType = typeof(M);
            object valueProp = null;
            //Act
            PropertyInfo classProp = classType.GetProperties().FirstOrDefault(p => p.Name == this.propName);
            if(this.valueTest != null)
            {
                if (classProp != null && classProp.PropertyType == this.T && this.valueTest.GetType() == this.T)
                {
                    classProp.SetValue(classTest, valueTest);
                    valueProp = classProp.GetValue(classTest);
                }
            }
            //Assert
            Assert.NotNull(valueProp);
        }

    }
}