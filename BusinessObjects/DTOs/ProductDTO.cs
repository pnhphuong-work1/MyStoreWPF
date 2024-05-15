using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = null;

        public int? CategoryId { get; set; }

        public short? UnitsInStock { get; set; }

        public decimal? UnitPrice { get; set; }

        public string CategoryName { get; set; }
    }
}
