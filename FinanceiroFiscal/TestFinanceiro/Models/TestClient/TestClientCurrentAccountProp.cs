using Data.Models;
using System;

namespace TestFinanceiro.Models.TestClient
{
    public class TestClientCurrentAccountProp : BaseTestProp<Client>
    {
        public TestClientCurrentAccountProp() : base ("CurrentAccount", typeof(CurrentAccount), Activator.CreateInstance<CurrentAccount>())
        {
        }
    }
}
