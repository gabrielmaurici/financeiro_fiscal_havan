using Data.Models;

namespace TestFinanceiro.Models.TestAddress
{
    public class TestAddressCEPProp : BaseTestProp<Address>
    {
        public TestAddressCEPProp() : base ("CEP", typeof(string), "88555-555")
        {
        }
    }
}
