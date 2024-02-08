using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal icategorydal;
        public CategoryManager(ICategoryDal icd)
        {
            icategorydal = icd;
        }
        public Category Get(int categoryid)
        {
            //business code
            return icategorydal.Get(p => p.CategoryId == categoryid);

        }

        public List<Category> GetAll()
        {
            //business code
            return icategorydal.GetAll();
        }
    }
}
