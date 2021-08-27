using Data.Models;
using System;

namespace TestFinanceiro.Models.TestLojaModel
{
    public class TestLojaModelCurrentProp : BaseTestProp<LojaModel>
    {
        public TestLojaModelCurrentProp() : base ("Current", typeof(CurrentAccount), Activator.CreateInstance<CurrentAccount>())
        {
        }
    }
}
