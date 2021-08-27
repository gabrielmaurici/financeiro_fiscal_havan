using Data.Models;

namespace TestFinanceiro.Models.TestTax
{
    public class TestTaxTaxValueProp : TestBase<Tax>
    {
        public TestTaxTaxValueProp() : base ("TaxValue", typeof(float))
        {
        }
    }
}
