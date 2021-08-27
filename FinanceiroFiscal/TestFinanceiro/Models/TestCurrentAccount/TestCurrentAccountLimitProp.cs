using Data.Models;

namespace TestFinanceiro.Models.TestCurrentAccount
{
    public class TestCurrentAccountLimitProp : BaseTestProp<CurrentAccount>
    {
        public TestCurrentAccountLimitProp() : base ("Limit", typeof(decimal), 15.45M)
        {
        }
    }
}
