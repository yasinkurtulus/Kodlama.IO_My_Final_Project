using Business.Concrate;
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
            ProductManager productManager2 = new ProductManager(new EfProductDal());
            foreach (var product in productManager2.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName + " " + product.UnitPrice);
            }

        }

    }


}
