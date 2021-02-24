using Entities.Concrete;

namespace Business.Concrete
{
    internal class ValitdationContext<T>
    {
        private Product product;

        public ValitdationContext(Product product)
        {
            this.product = product;
        }
    }
}