using Data.Models;
using System;

namespace TestFinanceiro.Models.TestLojaModel
{
    public class TestLojaModelAddresProp : BaseTestProp<LojaModel>
    {
        public TestLojaModelAddresProp() : base ("Addres", typeof(Address), Activator.CreateInstance<Address>())
        {
        }
    }
}
