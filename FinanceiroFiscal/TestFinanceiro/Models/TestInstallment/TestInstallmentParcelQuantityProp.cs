using Data.Models;

namespace TestFinanceiro.Models.TestInstallment
{
    public class TestInstallmentParcelQuantityProp : BaseTestProp<Installment>
    {
        public TestInstallmentParcelQuantityProp() : base("ParcelQuantity", typeof(int), 105030)
        {
        }
    }
}
