using Data.Models;
namespace TestFinanceiro.Models.TestCurrentAccount
{
    public class TestCurrentAccountBalanceProp : BaseTestProp<CurrentAccount>
    {
        public TestCurrentAccountBalanceProp() : base ("Balance", typeof(decimal), 15.151M)
        {
        }
    }
}
