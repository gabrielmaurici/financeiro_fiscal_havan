using Data.Models;

namespace TestFinanceiro.Models.TestContactModel
{
    public class TestContactModelEmailProp : BaseTestProp<ContactModel>
    {
        public TestContactModelEmailProp() : base ("Email", typeof(string), "rafinha@rato.com")
        {
        }
    }
}
