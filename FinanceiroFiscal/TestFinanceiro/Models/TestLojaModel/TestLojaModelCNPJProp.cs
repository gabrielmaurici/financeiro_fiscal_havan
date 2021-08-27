using Data.Models;

namespace TestFinanceiro.Models.TestLojaModel
{
    public class TestLojaModelCNPJProp : BaseTestProp<LojaModel>
    {
        public TestLojaModelCNPJProp() : base ("CNPJ", typeof(string), "544.544.555/0001")
        {
        }
    }
}
