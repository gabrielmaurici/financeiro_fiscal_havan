using Data.Models;

namespace TestFinanceiro.Models.TestAddress
{
    public class TestAddressStateProp : BaseTestProp<Address>
    {
        public TestAddressStateProp() : base ("State", typeof(string), "OK")
        {
        }
    }
}
