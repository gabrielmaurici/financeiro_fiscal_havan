using Data.Models;
using Xunit;

namespace TestFinanceiro.Models
{
    public class TestTax
    {
        [Fact]
        public void TestinheritanceBaseTaxModel()
        {
            //Arrange
            Tax tax = new Tax();
            //Act
            //Assert
            Assert.IsAssignableFrom<BaseModel>(tax);
        }

        [Fact]
        public void TestPropNameTaxModel()
        {
            //Arrange
            Tax tax = new Tax();
            string expectedValue = "Ok";
            //Act
            tax.Name = expectedValue;
            //Assert
            Assert.Equal(expectedValue, tax.Name);
            Assert.IsType<string>(tax.Name);
        }
        [Fact]
        public void TestPropTaxValueTaxModel()
        {
            //Arrange
            Tax tax = new Tax();
            float expectedValue = 15.35F;
            //Act
            tax.TaxValue = expectedValue;
            //Assert
            Assert.Equal(expectedValue, tax.TaxValue);
            Assert.IsType<float>(expectedValue);
        }
    }
}
