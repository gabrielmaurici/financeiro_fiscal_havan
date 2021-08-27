using Data.Models;
using System;

namespace TestFinanceiro.Models.TestLojaModel
{
    public class TestLojaModelContactProp : BaseTestProp<LojaModel>
    {
        public TestLojaModelContactProp() : base ("Contact", typeof(ContactModel), Activator.CreateInstance<ContactModel>())
        {
        }
    }
}
