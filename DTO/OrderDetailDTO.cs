using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetailDTO
    {
            public int ProductId { get; set; }
            public string ProductName { get; set; } 
            public string Size { get; set; }
            public decimal PriceSize { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }
        
    }
}
