using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<M> where M : BaseModel
    {
        public virtual void Create(M model)
        {
            using(var context = new FiscalContext())
            {
                context.Set<M>().Add(model);
                context.SaveChanges();
            }
        }
        public virtual List<M> Read()
        {
            List<M> list = new List<M>();
            using (var context = new FiscalContext())
            {
                list =context.Set<M>().ToList();
            }
            return list;
        }
        public virtual M Read(int id)
        {
            M model = Activator.CreateInstance<M>();
            using (var context = new FiscalContext())
            {
                model = context.Set<M>().Find(id);
            }
            return model;
        }
        public virtual void Update(M model)
        {
            using (var context = new FiscalContext())
            {
                context.Entry<M>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public virtual void Delete(int id)
        {
            using (var context = new FiscalContext())
            {
                context.Entry<M>(context.Set<M>().Find(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
