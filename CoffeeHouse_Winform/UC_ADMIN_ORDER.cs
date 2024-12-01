using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHouse_Winform
{
    public partial class UC_ADMIN_ORDER : UserControl
    {
        private OrderBLL orderBLL = new OrderBLL();
        private OrderDetailBLL orderDetailBLL = new OrderDetailBLL();
        private Form_Main_Admin mainForm;
        private List<string> paymentStatusOptions = new List<string> { "Pending", "Completed" };
        private List<string> orderStatusOptions = new List<string> { "Pending", "Processed", "Canceled", "Delivered", "Completed" };


        public event Action<string> OnFilterRequested;

        public UC_ADMIN_ORDER(Form_Main_Admin form)
        {
            InitializeComponent();
            mainForm = form;
            this.Load += UC_ADMIN_ORDER_Load;
            dg_donhang.SelectionChanged += Dg_donhang_SelectionChanged;
            cboPaymentStatus.SelectionChangeCommitted += CboPaymentStatus_SelectionChangeCommitted;
            cboStatus.SelectionChangeCommitted += CboStatus_SelectionChangeCommitted;
            LoadOrders();           

        }
        private void UpdateRowInDataGridView(int orderId, string paymentStatus, string orderStatus)
        {
            foreach (DataGridViewRow row in dg_donhang.Rows)
            {
                if (Convert.ToInt32(row.Cells["Id"].Value) == orderId) 
                {
                    if (!string.IsNullOrEmpty(paymentStatus))
                    {
                        row.Cells["PaymentStatus"].Value = paymentStatus;
                    }
                    if (!string.IsNullOrEmpty(orderStatus))
                    {
                        row.Cells["Status"].Value = orderStatus;
                    }
                    break;
                }
            }
        }

        private void CboStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtOrderId.Text, out int orderId))
                {
                    string newOrderStatus = cboStatus.SelectedItem.ToString();

                    orderBLL.UpdateOrderStatus(orderId, null, newOrderStatus);

                    UpdateRowInDataGridView(orderId, null, newOrderStatus);

                    MessageBox.Show("Cập nhật trạng thái đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật trạng thái đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboPaymentStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtOrderId.Text, out int orderId))
                {
                    string newPaymentStatus = cboPaymentStatus.SelectedItem.ToString();

                    orderBLL.UpdateOrderStatus(orderId, newPaymentStatus, null);

                    UpdateRowInDataGridView(orderId, newPaymentStatus, null);

                    MessageBox.Show("Cập nhật trạng thái thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật trạng thái thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void Dg_donhang_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_donhang.Focused && dg_donhang.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dg_donhang.SelectedRows[0].Cells["Id"].Value);
                DisplayOrder(orderId);
                DisplayOrderDetails(orderId);
            }
        }

        private void UC_ADMIN_ORDER_Load(object sender, EventArgs e)
        {
            cboPaymentStatus.DataSource = paymentStatusOptions;
            cboStatus.DataSource = orderStatusOptions;
            LoadOrders();
        }

        private void LoadOrders(string status = null)
        {
            ClearOrderDetails();

            if (dg_donhang.DataSource != null)
            {
                dg_donhang.DataSource = null;
                dg_donhang.Refresh();
            }

            if (string.IsNullOrEmpty(status))
            {
                dg_donhang.DataSource = orderBLL.GetAllOrders();
            }
            else
            {
                dg_donhang.DataSource = orderBLL.GetOrdersByStatus(status);
            }

            dg_donhang.Refresh();
        }



        public void FilterOrders(string status)
        {
            LoadOrders(status); 
        }

        private void btnFilterPending_Click(object sender, EventArgs e)
        {
            ClearOrderDetails();
            OnFilterRequested?.Invoke("Pending");
        }
        private void btnFilterProcessed_Click(object sender, EventArgs e)
        {
            ClearOrderDetails();
            OnFilterRequested?.Invoke("Processed");
        }

        private void btnFilterCanceled_Click(object sender, EventArgs e)
        {
            ClearOrderDetails();
            OnFilterRequested?.Invoke("Canceled");
        }

        private void btnFilterDelivered_Click(object sender, EventArgs e)
        {
            ClearOrderDetails();
            OnFilterRequested?.Invoke("Delivered");
        }

        private void btnFilterCompleted_Click(object sender, EventArgs e)
        {
            ClearOrderDetails();
            OnFilterRequested?.Invoke("Completed");
        }
        private void ClearOrderDetails()
        {
            dg_chitietdonhang.DataSource = null;

            dg_chitietdonhang.Refresh();
        }

        private void DisplayOrderDetails(int orderId)
        {
            var orderDetails = orderDetailBLL.GetOrderDetails(orderId);

            if (orderDetails == null || !orderDetails.Any())
            {
                MessageBox.Show("Không có dữ liệu chi tiết đơn hàng.");
                return;
            }

            dg_chitietdonhang.DataSource = orderDetails;


            dg_chitietdonhang.Refresh();
        }

        private void DisplayOrder(int orderId)
        {
            var order = orderBLL.GetOrderById(orderId);

            if (order == null)
            {
                MessageBox.Show("Không có dữ liệu đơn hàng.");
                return;
            }
            else
            {
                txtOrderId.Text = order.Id.ToString();
                txtCustomerName.Text = order.CustomerName;
                txtTotalPrice.Text = order.TotalPrice.ToString();
                if (order.PurchaseDate != null)
                {
                    dateTimePickerPayment.Value = order.PurchaseDate;
                }
                else
                {
                    dateTimePickerPayment.Value = DateTime.Now;
                }

                if (!paymentStatusOptions.Contains(order.PaymentStatus))
                {
                    paymentStatusOptions.Add(order.PaymentStatus);
                    cboPaymentStatus.DataSource = null;
                    cboPaymentStatus.DataSource = paymentStatusOptions;
                }

                if (!orderStatusOptions.Contains(order.Status))
                {
                    orderStatusOptions.Add(order.Status);
                    cboStatus.DataSource = null;
                    cboStatus.DataSource = orderStatusOptions;
                }

                cboPaymentStatus.Text = order.PaymentStatus;
                cboStatus.Text = order.Status;
            }

        }

    }
}
