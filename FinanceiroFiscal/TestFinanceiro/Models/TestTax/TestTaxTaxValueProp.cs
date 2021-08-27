using Data.Models;

namespace TestFinanceiro.Models.TestTax
{
    public class TestTaxTaxValueProp : BaseTestProp<Tax>
    {
        public TestTaxTaxValueProp() : base ("TaxValue", typeof(float), 10.5F)
        {
        }
    }
}
