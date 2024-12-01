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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeHouse_Winform
{
    public partial class Form_Main_Admin : Form
    {
        private string username;

        public Form_Main_Admin(string name)
        {
            InitializeComponent();
            this.btnExitWindow.Click += BtnExitWindow_Click;
            username = name;
            LoadUserInfo();
            this.btnExitWindow.Visible = true;
        }

        private void BtnExitWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn đăng xuất");
            LoginBLL.LoggedInUserName = null;
            Form_Login_Admin loginForm = new Form_Login_Admin();
            loginForm.Show();

            this.Close();
        }

        public void LoadUserInfo()
        {
            lblNameLog.Text =lblInfoName.Text = $"{username}!";
        }
        private void addUserControl(UserControl userControl)
        {
            if (panel_container.Controls.Count > 0 && panel_container.Controls[0].GetType() == userControl.GetType())
            {
                return;
            }

            userControl.Dock = DockStyle.Fill;
            panel_container.Controls.Clear();
            panel_container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnManageInvoice_Click(object sender, EventArgs e)
        {
            gunaOrder.Visible = !gunaOrder.Visible;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (panel_container.Controls.Count > 0 && panel_container.Controls[0] is UC_ADMIN_ORDER ucOrder)
            {
                ucOrder.FilterOrders(null);
            }
            else
            {
                var orderControl = new UC_ADMIN_ORDER(this);
                addUserControl(orderControl);
                orderControl.FilterOrders(null);
            }
        }

        private void FilterOrders(string status)
        {
            if (panel_container.Controls.Count > 0 && panel_container.Controls[0] is UC_ADMIN_ORDER ucOrder)
            {
                ucOrder.FilterOrders(status);
            }
            else
            {
                MessageBox.Show("Quản lý hóa đơn chưa được mở!");
            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            FilterOrders("Pending");
        }

        private void btnProcessed_Click(object sender, EventArgs e)
        {
            FilterOrders("Processed");
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            FilterOrders("Delivered");
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            FilterOrders("Completed");
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            FilterOrders("Canceled");
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExitWindow_Click_1(object sender, EventArgs e)
        {

        }
    }
}
