using AOPDemo.Core.Interface.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo.Core.Repository.Product
{
    public class ProductRepository : BaseRepository<Model.Product.Product,AOPDemoContext>, IProduct
    {
    }
}
