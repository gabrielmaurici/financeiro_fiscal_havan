//using Data.Models;
//using System.Collections.Generic;

//namespace Data.Repository
//{
//    public class BaseRepository<M> where M:BaseModel
//    {
//        public virtual void Create(M model)
//        {
//            using (var context = new FinanceiroContext())
//            {
//                context.Set<M>().Add(model);
//                context.SaveChanges();
//            }
//        }

//        public virtual List<M> Read()
//        {
//            using (var context = new FinanceiroContext())
//            {
//                return context.Set<M>().ToList();
//            }
//        }

//        public virtual M Read(int id)
//        {
//            using (var context = new FinanceiroContext())
//            {
//                return context.Set<M>().Find(id);
//            }
//        }

//        public virtual void Update(M model)
//        {
//            using (var context = new FinanceiroContext())
//            {
//                context.Entry<M>(model).State = EntityState.Modified;
//                context.SaveChanges();
//            }
//        }

//        public virtual void Delete(int id)
//        {
//            using (var context = new FinanceiroContext())
//            {
//                M model = this.Read(id);
//                context.Entry<M>(model).State = EntityState.Deleted;
//                context.SaveChanges();
//            }
//        }
//    }
//}
