using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class OrderDetailBLL
    {
        private OrderDetailDAL orderDetailDAL = new OrderDetailDAL();
        public List<OrderDetailDTO> GetOrderDetails(int orderId)
        {
            return orderDetailDAL.GetOrderDetailsByOrderId(orderId);
        }
       

    }
}
