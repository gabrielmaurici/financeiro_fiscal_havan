using Data.Models;

namespace TestFinanceiro.Models.TestExtract
{
    public class TestExtractEntryProp : BaseTestProp<Extract>
    {
        public TestExtractEntryProp() : base("Entry", typeof(decimal), 10.54545545M)
        {
        }
    }
}
