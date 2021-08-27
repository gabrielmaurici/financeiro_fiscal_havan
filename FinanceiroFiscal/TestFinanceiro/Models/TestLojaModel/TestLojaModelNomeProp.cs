using Data.Models;

namespace TestFinanceiro.Models.TestLojaModel
{
    public class TestLojaModelNomeProp : BaseTestProp<LojaModel>
    {
        public TestLojaModelNomeProp() : base ("Nome", typeof(string), "Vini")
        {
        }
    }
}
