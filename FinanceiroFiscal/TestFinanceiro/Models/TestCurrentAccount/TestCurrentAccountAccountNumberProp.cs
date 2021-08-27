using Data.Models;

namespace TestFinanceiro.Models.TestCurrentAccount
{
    public class TestCurrentAccountAccountNumberProp : BaseTestProp<CurrentAccount>
    {
        public TestCurrentAccountAccountNumberProp() : base ("AccountNumber", typeof(int), 15)
        {
        }
    }
}
