using Data.Models;

namespace TestFinanceiro.Models.TestLojaModel
{
    public class TestLojaModelIEProp : BaseTestProp<LojaModel>
    {
        public TestLojaModelIEProp() : base ("IE", typeof(string), "1000000")
        {
        }
    }
}
