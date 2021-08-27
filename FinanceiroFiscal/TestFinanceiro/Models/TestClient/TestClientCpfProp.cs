using Data.Models;

namespace TestFinanceiro.Models.TestClient
{
    public class TestClientCpfProp : BaseTestProp<Client>
    {
        public TestClientCpfProp() : base ("Cpf", typeof(string), "555.000.000-00")
        {
        }
    }
}
