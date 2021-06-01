using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        
        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName==""|| p.CategoryStatus==false|| p.CategoryName.Length<=2)
            {
                //hata mesajı
            }
            else
            {
                _categoryDal.Insert(p);
            }
        }
    }
}
