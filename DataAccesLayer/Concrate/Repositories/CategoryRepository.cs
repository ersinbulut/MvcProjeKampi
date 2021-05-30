using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrate.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category p) 
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }
        public List<Category> List(Expression<Func<Category, bool>> fiter)
        {
            throw new NotImplementedException();
        }
        public void Update(Category p)
        {
            c.SaveChanges();
        }

        /*ToList listeleme
         Add ekleme
        Remove Silme
        Find bulma
        */
    }
}
