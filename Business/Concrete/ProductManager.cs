using Business.Abstract;
using DateAccess.Abstract;
using DateAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal _ProductDal)
        {
            _productDal = _ProductDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategory(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(P => P.UnitPrice >= min && P.UnitPrice <= max);
        }
    }
}
