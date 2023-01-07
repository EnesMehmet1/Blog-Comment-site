using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Reporistories
{
    public class CategoryRepository : ICategoryDal
    {
        Context db = new Context();
        DbSet<Category> _Object;

        public void Delete(Category p)
        {
            _Object.Remove(p);
            db.SaveChanges();
        }

        public void Insert(Category p)
        {
            _Object.Add(p);
            db.SaveChanges();
        }

        public List<Category> List()
        {
            return _Object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            db.SaveChanges();
        }
    }
}
