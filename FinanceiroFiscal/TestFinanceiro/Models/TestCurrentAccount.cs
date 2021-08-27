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
    public class TestCurrentAccount
    {
        [Fact]
        public void TestInstanceClassCurrentAccount()
        {
            CurrentAccount instance;

            instance = Activator.CreateInstance<CurrentAccount>();

            Assert.IsType<CurrentAccount>(instance);
        }
        [Fact]
        public void TestInherintanceClassCurrentAccountWithBaseModel()
        {
            CurrentAccount instance;

            instance = Activator.CreateInstance<CurrentAccount>();

            Assert.IsAssignableFrom<BaseModel>(instance);
        }
        [Fact]
        public void TestaSePropriedadeAccoutnNumberexiste() 
        {
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "AccountNumber");
            Assert.NotNull(pi);
        }
        [Fact]
        public void TestaPropriedadeAccountNumberEInt() 
        {
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "AccountNumber");
            Type typeString = typeof(int);
            Type typeProperty = pi != null ? pi.PropertyType : null;
            Assert.Equal(typeString,typeProperty);
        }
        [Fact]
        public void TestaPropriedadeAccountNumberGet() 
        {
            CurrentAccount ad = new CurrentAccount();
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "AccountNumber");
            object valueProp = null;
            if (pi != null && pi.PropertyType== typeof(int)) 
            {
                pi.SetValue(ad, 3);
                valueProp = pi.GetValue(ad);
            }
            Assert.NotNull(valueProp);
        }

        [Fact]
        public void TestaSePropriedadeLimitExiste()
        {
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "Limit");
            Assert.NotNull(pi);
        }
        [Fact]
        public void TestaPropriedadeLimitEDecimal()
        {
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "Limit");
            Type type = typeof(decimal);
            Type typeProperty = pi != null ? pi.PropertyType : null;
            Assert.Equal(type, typeProperty);
        }
        [Fact]
        public void TestaPropriedadeLimitGet()
        {
            CurrentAccount ad = new CurrentAccount();
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "Limit");
            object valueProp = null;
            if (pi != null && pi.PropertyType == typeof(decimal))
            {
                pi.SetValue(ad, 10m);
                valueProp = pi.GetValue(ad);
            }
            Assert.NotNull(valueProp);
        }

        [Fact]
        public void TestaSePropriedadeBalanceExiste()
        {
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "Balance");
            Assert.NotNull(pi);
        }
        [Fact]
        public void TestaPropriedadeBalanceEDecimal()
        {
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "Balance");
            Type type = typeof(decimal);
            Type typeProperty = pi != null ? pi.PropertyType : null;
            Assert.Equal(type, typeProperty);
        }
        [Fact]
        public void TestaPropriedadeBalanceGet()
        {
            CurrentAccount ad = new CurrentAccount();
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "Balance");
            object valueProp = null;
            if (pi != null && pi.PropertyType == typeof(decimal))
            {
                pi.SetValue(ad, 10m);
                valueProp = pi.GetValue(ad);
            }
            Assert.NotNull(valueProp);
        }
        [Fact]
        public void TestaSePropriedadeExtractExiste()
        {
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "Extract");
            Assert.NotNull(pi);
        }
        [Fact]
        public void TestaPropriedadeExtractEExtract()
        {
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "Extract");
            Type type = typeof(Extract);
            Type typeProperty = pi != null ? pi.PropertyType : null;
            Assert.Equal(type, typeProperty);
        }
        [Fact]
        public void TestaPropriedadeExtractGet()
        {
            CurrentAccount ad = new CurrentAccount();
            Type t = typeof(CurrentAccount);
            PropertyInfo pi = t.GetProperties().FirstOrDefault(p => p.Name == "Extract");
            object valueProp = null;
            if (pi != null && pi.PropertyType == typeof(Extract))
            {
                Extract model = new Extract();
                model.Id = 1;
                model.OutPut = 10m;
                model.Entry = 10m;
                pi.SetValue(ad, model);
                valueProp = pi.GetValue(ad);
            }
            Assert.NotNull(valueProp);
        }
    }
}
