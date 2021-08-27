using Data.Models;

namespace TestFinanceiro.Models.TestClient
{
    public class TestClientRgProp : BaseTestProp<Client>
    {
        public TestClientRgProp() : base ("Rg", typeof(string), "2.222-222")
        {
        }
    }
}
