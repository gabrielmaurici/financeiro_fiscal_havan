using Data.Models;
using System;

namespace TestFinanceiro.Models.TestCurrentAccount
{
    public class TestCurrentAccountExtractProp : BaseTestProp<CurrentAccount>
    {
        public TestCurrentAccountExtractProp() : base ("Extract", typeof(Extract), Activator.CreateInstance<Extract>())
        {
        }
    }
}
