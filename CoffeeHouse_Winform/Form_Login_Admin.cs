using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace CoffeeHouse_Winform
{
   
    public partial class Form_Login_Admin : Form
    {
        private LoginBLL loginBLL;
        public Form_Login_Admin()
        {
            InitializeComponent();
            loginBLL=new LoginBLL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (loginBLL.Login(email, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Điều hướng đến trang chính
                Form_Main_Admin mainForm = new Form_Main_Admin();
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Email, mật khẩu không đúng hoặc bạn không có quyền Admin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
