using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Messages.ProductNameInValid);
               
            }
            _productDal.Add(product);
            return new SuccesResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //Some business code blocks
            //Is he allows to use ? 
            if (DateTime.Now.Hour==20)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccesDataResult<List<Product>>(_productDal.GetAll());   

        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryID == id));
        }

        public IDataResult<Product> GetById(int id)
        {
            //BusinessCode
            return new SuccesDataResult<Product>(_productDal.Get(p=>p.ProductId==id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetAll().Where(p => p.UnitPrice > min && p.UnitPrice < max).ToList());
        }

        public IDataResult<List<ProductDetailsDto>> GetProductDetailsDtos()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<ProductDetailsDto>>(Messages.MaintenanceTime);
            }
            return new SuccesDataResult<List<ProductDetailsDto>>(_productDal.GetByDetails());
        }
    }
}
