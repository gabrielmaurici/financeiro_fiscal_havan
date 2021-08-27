using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestFinanceiro.Models
{
    public class TestInstallment
    {
        [Fact]
        public void TestInstallmentPropertiesExist()
        {
            Type t = typeof(Installment);
            PropertyInfo pIParcelQuantity = t.GetProperties().FirstOrDefault(p => p.Name == "ParcelQuantity");
            Assert.NotNull(pIParcelQuantity);
            PropertyInfo pITaxFees = t.GetProperties().FirstOrDefault(p => p.Name == "TaxFees");
            Assert.NotNull(pITaxFees);
        }
        [Fact]
        public void TestInstallmentPropertiesType()
        {
            Type t = typeof(Installment);
            Type typeInt = typeof(int);
            Type typeFloat = typeof(float);

            PropertyInfo pIParcelQuantity = t.GetProperties().FirstOrDefault(p => p.Name == "ParcelQuantity");
            PropertyInfo pITaxFees = t.GetProperties().FirstOrDefault(p => p.Name == "TaxFees");

            Type typePropertyParcel = pIParcelQuantity != null ? pIParcelQuantity.PropertyType : null;
            Assert.Equal(typeInt, typePropertyParcel);

            Type typePropertyTaxFees = pITaxFees != null ? pITaxFees.PropertyType : null;
            Assert.Equal(typeFloat, typePropertyTaxFees);
        }
        [Fact]
        public void TestarSePropriedadeDescricaoGet()
        {
            Installment s = new Installment();
            Type t = typeof(Installment);

            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "ParcelQuantity");
            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(int))
            {

                pI.SetValue(s, 1);
                valueProp = pI.GetValue(s);
            }
            Assert.NotNull(valueProp);

            pI = t.GetProperties().FirstOrDefault(p => p.Name == "TaxFees");
            valueProp = null;
            if (pI != null && pI.PropertyType == typeof(float))
            {

                pI.SetValue(s, 1.0f);
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
    }
}
