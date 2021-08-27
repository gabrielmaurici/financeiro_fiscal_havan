using Data.Models;

namespace TestFinanceiro.Models.TestAddress
{
    public class TestAddressCityProp : BaseTestProp<Address>
    {
        public TestAddressCityProp() : base ("City", typeof(string), "Brusque")
        {
        }
    }
}
