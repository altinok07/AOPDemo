using AOPDemo.Core.Interface.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo.Business.Product
{
    public class ProductManager : IProduct
    {

        IProduct _product;

        public ProductManager(IProduct product)
        {
            _product = product;
        }

        public void Add(Model.Product.Product entity)
        {
            _product.Add(entity);
        }

        public bool Delete(Model.Product.Product entity)
        {
            throw new NotImplementedException();
        }

        public Model.Product.Product Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Product.Product> GetActive()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Product.Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Model.Product.Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
