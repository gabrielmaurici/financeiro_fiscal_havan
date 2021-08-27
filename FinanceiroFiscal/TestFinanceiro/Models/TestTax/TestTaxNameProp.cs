using Data.Models;

namespace TestFinanceiro.Models.TestTax
{
    public class TestTaxNameProp : BaseTestProp<Tax>
    {
        public TestTaxNameProp() : base ("Name", typeof(string), "OK")
        {
        }
    }
}
