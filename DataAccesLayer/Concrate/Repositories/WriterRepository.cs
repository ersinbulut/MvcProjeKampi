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
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<Writer> _object;
        public void Delete(IWriterDal p)
        {
            throw new NotImplementedException();
        }

        public void Insert(IWriterDal p)
        {
            throw new NotImplementedException();
        }

        public List<IWriterDal> List()
        {
            throw new NotImplementedException();
        }

        public List<IWriterDal> List(Expression<Func<IWriterDal, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(IWriterDal p)
        {
            throw new NotImplementedException();
        }
    }
}
