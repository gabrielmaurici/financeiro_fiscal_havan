using Data.Models;

namespace TestFinanceiro.Models.TestInstallment
{
    public class TestInstallmentTaxFeesProp : BaseTestProp<Installment>
    {
        public TestInstallmentTaxFeesProp() : base ("TaxFees", typeof(float), 10.55F)
        {
        }
    }
}
