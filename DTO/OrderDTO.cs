using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string CustomerName { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
