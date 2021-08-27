using Data.Models;

namespace TestFinanceiro.Models.TestAddress
{
    public class TestAddressStreetProp : BaseTestProp<Address>
    {
        public TestAddressStreetProp() : base ("Street", typeof(string), "Rafinha")
        {
        }
    }
}
