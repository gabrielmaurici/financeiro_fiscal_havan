using Data.Models;

namespace TestFinanceiro.Models.TestExtract
{
    public class TestExtractOutPutProp : BaseTestProp<Extract>
    {
        public TestExtractOutPutProp() : base ("OutPut", typeof(decimal), 15.555M)
        {
        }
    }
}
