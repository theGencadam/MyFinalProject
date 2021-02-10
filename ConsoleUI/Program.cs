using Business.Concrete;
using DateAccess.Concrete.EntityFramework;
using DateAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object = DTOs
            //ProductTest();
            //IoC
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetailDto())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
    }
}
