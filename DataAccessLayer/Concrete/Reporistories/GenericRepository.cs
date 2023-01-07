using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Reporistories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context db = new Context();

        DbSet<T> _Object;

        public GenericRepository()
        {
            _Object = db.Set<T>();
        }
        public void Delete(T p)
        {
            _Object.Remove(p);
            db.SaveChanges();
        }

        public void Insert(T p)
        {
            _Object.Add(p);
            db.SaveChanges();
        }

        public List<T> List()
        {
            return _Object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _Object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            db.SaveChanges();
        }
    }
}
