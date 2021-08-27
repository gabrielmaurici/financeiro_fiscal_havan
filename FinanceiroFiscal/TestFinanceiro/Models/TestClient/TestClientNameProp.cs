using Data.Models;

namespace TestFinanceiro.Models.TestClient
{
    public class TestClientNameProp : BaseTestProp<Client>
    {
        public TestClientNameProp() : base ("Name", typeof(string), "OK")
        {
        }
    }
}
