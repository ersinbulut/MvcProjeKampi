using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICategoryDal
    {
        //CRUD
        // TYPE NAME();

        List<Category> List();

        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);

       

    }
}
