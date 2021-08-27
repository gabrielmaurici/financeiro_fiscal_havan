using Data.Models;

namespace TestFinanceiro.Models.TestTax
{
    public class TestTaxNameProp : TestBase<Tax>
    {
        public TestTaxNameProp() : base ("Name", typeof(string))
        {
        }
    }
}
