using Data.Models;
using System;

namespace TestFinanceiro.Models.TestClient
{
    public class TestClientBirthdayProp : BaseTestProp<Client>
    {
        public TestClientBirthdayProp() : base("Birthday", typeof(DateTime), DateTime.Now)
        {
        }
    }
}
