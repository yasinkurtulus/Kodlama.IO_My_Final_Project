using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFrameWork
{
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext> ,IProductDal
    {
       
    }
}
