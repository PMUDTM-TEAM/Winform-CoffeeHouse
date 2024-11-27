using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductVariantWithSize
    {
        public int Id {  get; set; }
        public int? Pro_Id { get; set; }
        public string Pro_Name { get; set; }
        public int? Size_Id { get;set; }
        public string Size_Name { get; set;}
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }  

    }
}
