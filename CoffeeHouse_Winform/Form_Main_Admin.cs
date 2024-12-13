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
    public partial class Form_Main_Admin : Form
    {
        public Form_Main_Admin()
        {
            InitializeComponent();
          
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_container.Controls.Clear();
            panel_container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            UC_ADMIN_PRODUCT uc = new UC_ADMIN_PRODUCT();
            addUserControl(uc);
        }

        private void btnManageCate_Click(object sender, EventArgs e)
        {
            UC_ADMIN_CATEGORY uc = new UC_ADMIN_CATEGORY();
            addUserControl(uc);
        }

        private void btnManageTopping_Click(object sender, EventArgs e)
        {
            UC_ADMIN_TOPPING uc = new UC_ADMIN_TOPPING();
            addUserControl(uc);
        }

        private void btnManageSize_Click(object sender, EventArgs e)
        {
            UC_ADMIN_SIZE uc = new UC_ADMIN_SIZE();
            addUserControl(uc);
        }

        private void btnLinkProduct_Click(object sender, EventArgs e)
        {
            UC_ADMIN_PRODUCTVARIANT uc = new UC_ADMIN_PRODUCTVARIANT();
            addUserControl(uc);
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            UC_ADMIN_WAREHOUSE uc = new UC_ADMIN_WAREHOUSE();
            addUserControl(uc);
        }
    }
}
