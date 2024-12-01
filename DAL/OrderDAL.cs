using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class OrderDAL
    {
        QLCFDataContext db = new QLCFDataContext();

        public OrderDAL() { }

        public List<OrderDTO> GetAllOrders()
        {
            return db.Orders.Select(order => new OrderDTO
            {
                Id = order.Id,
                PurchaseDate = order.CreatedAt.Value,
                CustomerName = order.Account.Name,
                PaymentMethod = order.PaymentMethod,
                PaymentStatus = order.PaymentStatus,
                Status = order.Status,
                TotalPrice = order.TotalPrice ?? 0
            }).ToList();
        }

        public List<OrderDTO> GetOrdersByStatus(string status)
        {
            return db.Orders
                     .Where(o => o.Status == status)
                     .Select(o => new OrderDTO
                     {
                         Id = o.Id,
                         PurchaseDate = o.CreatedAt.Value,
                         CustomerName = o.Account.Name,
                         PaymentMethod = o.PaymentMethod,
                         PaymentStatus = o.PaymentStatus,
                         Status = o.Status,
                         TotalPrice = o.TotalPrice ?? 0
                     })
                     .ToList();
        }

        public void UpdateOrderStatus(int orderId, string paymentStatus, string orderStatus)
        {
            var order = db.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                if (!string.IsNullOrEmpty(paymentStatus))
                {
                    order.PaymentStatus = paymentStatus;
                }

                if (!string.IsNullOrEmpty(orderStatus))
                {
                    order.Status = orderStatus;
                }

                db.SubmitChanges();
            }
        }

        public OrderDTO GetOrderById(int orderId)
        {
            var order = db.Orders
                          .Where(o => o.Id == orderId)
                          .Select(o => new OrderDTO
                          {
                              Id = o.Id,
                              PurchaseDate = o.CreatedAt.Value,
                              CustomerName = o.Account.Name,
                              PaymentMethod = o.PaymentMethod,
                              PaymentStatus = o.PaymentStatus,
                              Status = o.Status,
                              TotalPrice = o.TotalPrice ?? 0
                          })
                          .FirstOrDefault();
            return order;
        }
    }
}
