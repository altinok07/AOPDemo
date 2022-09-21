using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo.Model.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int ProductTypeId { get; set; }
        public string Barcode { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal PurchasePrice { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal SalePrice { get; set; }
        public bool IsActive { get; set; }
    }
}
