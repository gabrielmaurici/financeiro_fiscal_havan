using Data.Models;
using System;
using Xunit;

namespace TestFinanceiro.Models
{
    public class TestExtract
    {
        [Fact]
        public void TesteExtracproperty()
        {
            Extract testproperty;
            testproperty = Activator.CreateInstance<Extract>();
            decimal deci = 10.8m;
            testproperty.Entry = deci;
            testproperty.OutPut = deci;
            Assert.IsType<decimal>(testproperty.Entry);
            Assert.IsType<decimal>(testproperty.OutPut);
        }
        [Fact]
        public void TestInstanceinhertyforBase()
        {
            Extract testinherty;
            testinherty = Activator.CreateInstance<Extract>();
            Assert.IsAssignableFrom<BaseModel>(testinherty);
        }   
    }
}