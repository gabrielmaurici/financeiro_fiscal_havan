using Data.Models;

namespace TestFinanceiro.Models.TestAddress
{
    public class TestAddressNeighborhoodProp : BaseTestProp<Address>
    {
        public TestAddressNeighborhoodProp() : base("Neighborhood", typeof(string), "Felipera")
        {
        }
    }
}
