using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class OrderDetailDAL
    {
        QLCFDataContext db = new QLCFDataContext();

        public List<OrderDetailDTO> GetOrderDetailsByOrderId(int orderId)
        {
            return db.OrderDetails
                     .Where(detail => detail.Order_Id == orderId)
                     .Select(detail => new OrderDetailDTO
                     {
                         ProductId = detail.ProductVariant.Product.Id,
                         ProductName = detail.ProductVariant.Product.Name,
                         Size = detail.ProductVariant.Size.Size1,
                         PriceSize = detail.ProductVariant.Size.Price.Value,
                         UnitPrice = detail.ProductVariant.Price.Value,
                         Quantity = detail.Quantity.Value,
                         TotalPrice = detail.TotalPrice.Value
                     })
                     .ToList();
        }
    }
}
