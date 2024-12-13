using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WarehouseWithProduct
    {
        public int Id { get; set; }
        public int? Provar_id { get; set; }
        public string Pro_Name { get; set; }
        public string Size_Name { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Day_In {  get; set; }
    }
}
