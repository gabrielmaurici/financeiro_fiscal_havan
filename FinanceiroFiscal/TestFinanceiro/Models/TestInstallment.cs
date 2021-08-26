using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestFinanceiro.Models
{
    public class TestInstallment
    {
        [Fact]
        public void TesteVariaveisInstallment()
        {
            int i = 10;
            float f = 1.0f;
            var ii = typeof(int);
            var ff = typeof(float);
            Installment installment = Activator.CreateInstance<Installment>();

            installment.ParcelQuantity = i;
            installment.Id = i;
            installment.TaxFees = f;

            //teste tipo
            Assert.IsAssignableFrom(ii, installment.ParcelQuantity);
            Assert.IsAssignableFrom(ii, installment.Id);
            Assert.IsAssignableFrom(ff, installment.TaxFees);
            //teste assign
            Assert.NotEqual(0, installment.Id);
            Assert.NotEqual(0, installment.ParcelQuantity);
            Assert.NotEqual(0, installment.TaxFees);
        }
    }
}
