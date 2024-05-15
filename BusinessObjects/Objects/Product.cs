using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Objects
{
    public struct ProductView
    {
        public int ProductId;

        public string ProductName;

        public int? CategoryId;

        public short? UnitsInStock;

        public decimal? UnitPrice;
        
        public string? CategoryName;

    }
}
