using System;
using System.Collections.Generic;
using DAL;
using DTO;
namespace BLL
{
    public class OrderBLL
    {
        private OrderDAL orderDAL = new OrderDAL();

        public List<OrderDTO> GetAllOrders()
        {
            return orderDAL.GetAllOrders();
        }

        public List<OrderDTO> GetOrdersByStatus(string status)
        {
            return orderDAL.GetOrdersByStatus(status);
        }

        public void UpdateOrderStatus(int orderId, string paymentStatus, string orderStatus)
        {
            orderDAL.UpdateOrderStatus(orderId, paymentStatus, orderStatus);
        }

        public OrderDTO GetOrderById(int orderId)
        {
            return (OrderDTO)orderDAL.GetOrderById(orderId);
        }
    }
}

