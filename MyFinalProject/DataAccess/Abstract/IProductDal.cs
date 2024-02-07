using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.DateAccess.IEntityRepository;


namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
