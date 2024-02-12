using Business.Abstract;
using Business.Concrate;
using Business.Constant;
using DataAccess.Concrate.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            // CategoryTest();
         


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var product in categoryManager.GetAll())
            {
                Console.WriteLine(product.CategoryName + " " + product.CategoryId);
            }
        }

        private static void ProductTest()
        {

            ProductManager productManager2 = new ProductManager(new EfProductDal());
            var result = productManager2.GetProductDetailsDtos().Succes;
             if (result==false)
            {
                Console.WriteLine(productManager2.GetProductDetailsDtos().Message);
            }
            else
            {
                foreach (var product in productManager2.GetProductDetailsDtos().Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
           
        }
    }


}
