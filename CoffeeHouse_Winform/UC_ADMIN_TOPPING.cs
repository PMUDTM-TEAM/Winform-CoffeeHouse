using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Globalization;

using System.Text.RegularExpressions;

using SixLabors.ImageSharp.Processing;


namespace CoffeeHouse_Winform
{
    public partial class UC_ADMIN_TOPPING : UserControl
    {
        private ToppingBLL top;
       

        public UC_ADMIN_TOPPING()
        {
            InitializeComponent();
            top=new ToppingBLL();
        }

        // Hàm load danh sách topping lên dgDSSP
        public void loadList()
        {
            var toppinggs = top.getTopping();
            dgDSSP.Rows.Clear();


            foreach (var topping in toppinggs)
            {
                dgDSSP.Rows.Add(topping.Id, topping.Name, topping.Price);
            }
        }

        // Hàm dùng close các button khác khi thêm mới
        public void closeBtnWhenInsert()
        {
            btnDelete.Enabled=false;
            btnEdit.Enabled=false;
        }

        // Hàm dùng close các button khác khi đang sửa
        public void closeBtnWhenUpdate()
        {
            btnDelete.Enabled = false;
            btnCreate.Enabled = false;
        }

        // Hàm mở các button thực hiện chức năng
        public void openBtn()
        {
            btnDelete.Enabled=true;
            btnCreate.Enabled=true;
            btnEdit.Enabled =true;
        }

        // Hàm đóng tất cả các component
        public void closeComponent()
        {
            txtName.Enabled=false;
            txtPrice.Enabled=false;
            btnfix.Enabled=false;
            btnSave.Enabled=false;
            btn_cancelSave.Enabled=false;
            btnClear.Enabled=false;
        }

        // Hàm mở các component cho việc thêm mới topping
        public void openComponentForInsert()
        {
            txtName.Enabled = true;
            txtPrice.Enabled=true;
            btnSave.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnClear.Enabled = true;
        }

        // Hàm mở các component cho việc cập nhật topping
        public void openComponentForUpdate()
        {
            txtName.Enabled = true;
            txtPrice.Enabled=true;  
            btnfix.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnClear.Enabled = true;
        }

        // Hàm dùng reset thông tin nhập liệu
        public void clearInfor()
        {
            txtName.Text = "";
            txtPrice.Text = "";
        }

        // Hàm load chương trình khi lần đàu chạy
        private void UC_ADMIN_PRODUCT_Load(object sender, EventArgs e)
        {
  
            loadList();
            closeComponent();
            
        }

        // Sự kiện nút Không lưu
        private void btn_cancelSave_Click(object sender, EventArgs e)
        {
            clearInfor();
            closeComponent();
            openBtn();
        }

        // Sự kiện nút reset thông tin
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInfor();
        }

        // Sự kiện nút thêm mới
        private void btnCreate_Click(object sender, EventArgs e)
        {
            openComponentForInsert();
            closeBtnWhenInsert();
        }

        // Sự kiện click vào dgDSSP
        private void dgDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgDSSP.Rows[e.RowIndex];
                txtName.Text = selectedRow.Cells["TopName"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
            }
        }

        // Hàm của btnSave lưu topping mới
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            decimal price=decimal.Parse(txtPrice.Text);

            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập tên trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            if(string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Nhập giá trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
           
            Topping topping = new Topping
            {
                Name = name,
                Price = price,
            };
          
            bool checkSuccess=top.insertTopping(topping);
            if(checkSuccess)
            {
                clearInfor();
                closeComponent();
                openBtn();
                loadList();
                MessageBox.Show("Thêm topping mới thành công !");
            }
            else
            {
                MessageBox.Show("Thêm lỗi vui lòng kiểm tra lại !");
            }    
        }

        // Hàm của btnDelete dùng xóa topping
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgDSSP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn topping trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            DataGridViewRow selectedRow = dgDSSP.SelectedRows[0];
            string Name = selectedRow.Cells["TopName"].Value.ToString();
            int Id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
            
            
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa topping: {Name}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                try
                {
                    bool isDeleted = top.deleteTopping(Id);

                    if (isDeleted)
                    {
                        MessageBox.Show($"Topping {Name} đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInfor();
                        loadList();
                    }
                    else
                    {
                        MessageBox.Show($"Không thể xóa Topping {Name}. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi xóa topping: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm của btnEdit dùng để kích hoạt các component update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgDSSP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn topping trong danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            closeBtnWhenUpdate();
            openComponentForUpdate();
        }

        // Hàm của btnFix dùng để cập nhật topping
        private void btnfix_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgDSSP.SelectedRows[0];
            string name = txtName.Text;
            int id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
            decimal price=decimal.Parse(txtPrice.Text);
            if(string.IsNullOrEmpty(txtPrice.Text))
            {
                price = 0;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn sửa topping: {name}?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                try
                {
                    bool isUpdate = top.updateTopping(id,name,price);

                    if (isUpdate)
                    {
                       
                            openBtn();
                            loadList();
                            closeComponent();
                            clearInfor();
                            MessageBox.Show($"Topping đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           

                    }
                    else
                    {
                        MessageBox.Show($"Không thể cập nhật Topping {name}. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi sửa Topping: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
