using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EFGenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            var values = c.Set<T>().Find(id);
            return values;
        }

        public List<T> GetListAll()
        {
            using var c = new Context();
            var values = c.Set<T>().ToList();
            return values;
        }

      

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
