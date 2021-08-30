using Data.Models;

namespace TestFinanceiro.Models.TestAddress
{
    public class TestAddressNumberProp : BaseTestProp<Address>
    {
        public TestAddressNumberProp() : base ("Number", typeof(string), "155E")
        {
        }
    }
}
