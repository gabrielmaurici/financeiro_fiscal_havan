using Data.Models;

namespace TestFinanceiro.Models.TestContactModel
{
    public class TestContactModelPhoneProp : BaseTestProp<ContactModel>
    {
        public TestContactModelPhoneProp() : base ("Phone", typeof(string), "OK")
        {
        }
    }
}
