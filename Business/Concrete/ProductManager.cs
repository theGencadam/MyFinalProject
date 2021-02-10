using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DateAccess.Abstract;
using DateAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Product product)
        {
            //business codes
            if (product.ProductName.Length<2)
            {
                //magic strings
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {

            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),true,"Ürünler listelendi");
        }

        public List<Product> GetAllByCategory(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(P => P.UnitPrice >= min && P.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
