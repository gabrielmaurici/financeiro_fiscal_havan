using Data.Models;
using Data.Repository;
using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace TestFinanceiro.Repository
{
    public abstract class TesteRepositories<M, R> where M : BaseModel where R : BaseRepository<M>
    {
        [Fact]
        public void TestInstance()
        {
            //Arrange
            Type addressRepoType = typeof(R);
            //Act
            var objAddressRepo = Activator.CreateInstance<R>();
            //Assert
            Assert.IsType(addressRepoType, objAddressRepo);
        }

        [Fact]
        public void TestCreate()
        {
            M model = Activator.CreateInstance<M>();
            R repo = Activator.CreateInstance<R>();
            repo.Create(model);

            Assert.NotEqual(0, model.Id);
        }
        [Fact]
        public void TestRead()
        {
            M model = Activator.CreateInstance<M>();
            R repo = Activator.CreateInstance<R>();
            repo.Create(model);

            M result = repo.Read().Find(m => m.Id == model.Id);

            Assert.NotNull(result);
        }

        [Fact]
        public void TestReadById()
        {
            M model = Activator.CreateInstance<M>();
            R repo = Activator.CreateInstance<R>();
            repo.Create(model);

            M result = repo.Read(model.Id);

            Assert.NotNull(result);
        }

        [Fact]
        public void TestUpdate()
        {
            R repo = Activator.CreateInstance<R>();
            M model = Activator.CreateInstance<M>();

            repo.Create(model);
            M modifica = repo.Read(model.Id);
            PropertyInfo propertyInfo =  modifica.GetType().GetProperties()[0];
            Type type = propertyInfo.PropertyType;
            if (type == typeof(string))
            {
                propertyInfo.SetValue(modifica, "sth");
            }
            else
            {
                propertyInfo.SetValue(modifica,Activator.CreateInstance(type));
            }
            repo.Update(modifica);
            M result = repo.Read(modifica.Id);

            Assert.NotEqual(model.GetType().GetProperties()[0].GetValue(model), result.GetType().GetProperties()[0].GetValue(result));
        }
        [Fact]
        public void TestDelete()
        {
            R repo = Activator.CreateInstance<R>();
            M model = Activator.CreateInstance<M>();
            repo.Create(model);

            repo.Delete(model.Id);
            M deletado = repo.Read(model.Id);

            Assert.Null(deletado);
        }
    }
}
