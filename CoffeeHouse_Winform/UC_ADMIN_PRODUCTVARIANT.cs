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
using System.Xml.Linq;


namespace CoffeeHouse_Winform
{
    public partial class UC_ADMIN_PRODUCTVARIANT : UserControl
    {
        private SizeBLL size;
        private ProductBLL product;
        private ProductVariantBLL provar;
        private CategoryBLL cate;

        public UC_ADMIN_PRODUCTVARIANT()
        {
            InitializeComponent();
            size=new SizeBLL();
            product=new ProductBLL();
            provar=new ProductVariantBLL();
            cate=new CategoryBLL();
        }

        // Hàm load combobox
        public void loadComboBox()
        {
            cboCate.SelectedIndexChanged -= cboCate_SelectedIndexChanged;

            cboCate.DataSource = cate.getCategories();
            cboCate.DisplayMember = "Name";
            cboCate.ValueMember = "Id";

            cboSize.DataSource = size.getSizes();
            cboSize.DisplayMember = "Size1";
            cboSize.ValueMember = "Id";

            
            cboCate.SelectedIndexChanged += cboCate_SelectedIndexChanged;
        }

        // Hàm load combobox product
        public void loadComboBoxProduct(int cate_id)
        {
            cboProduct.SelectedIndexChanged -= cboProduct_SelectedIndexChanged;
            cboProduct.DataSource = product.getProductsByCateId(cate_id);
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "Id";

            cboProduct.SelectedIndexChanged += cboProduct_SelectedIndexChanged;
        }

        // Hàm load danh sách các liên kết của sản phẩm lên dgDSSP
        public void loadList(int pro_id)
        {
            var provars = provar.getVariants(pro_id);
            dgDSSP.Rows.Clear();


            foreach (var p in provars)
            {
                dgDSSP.Rows.Add(p.Id, p.Pro_Id,p.Pro_Name,p.Size_Id,p.Size_Name,p.Quantity,p.Price);
            }
        }

        // Hàm dùng close các button khác khi thêm mới
        public void closeBtnWhenInsert()
        {
            btnDelete.Enabled=false;
            btnEdit.Enabled=false;
        }

        // Hàm mở các button thực hiện chức năng
        public void openBtn()
        {
            btnDelete.Enabled=true;
            btnCreate.Enabled=true;
            btnEdit.Enabled =true;
            cboProduct.Enabled = true;
            cboCate.Enabled = true;
        }

        // Hàm đóng tất cả các component
        public void closeComponent()
        {
            txtSoLuong.Enabled=false;
            txtPrice.Enabled=false;
            btnfix.Enabled=false;
            btnSave.Enabled=false;
            btn_cancelSave.Enabled=false;
            btnClear.Enabled=false;
            cboSize.Enabled=false;
        }

        // Hàm mở các component cho việc thêm mới liên kết
        public void openComponentForInsert()
        {
            txtSoLuong.Enabled = true;
            txtPrice.Enabled=true;
            btnSave.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnClear.Enabled = true;
            cboSize.Enabled = true;
        }

        // Hàm mở các component khi sửa liên kết
        public void openComponentForUpdate()
        {
            txtSoLuong.Enabled = true;
            txtPrice.Enabled=true;
            btnfix.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnClear.Enabled = true;
        }

        // Hàm đóng khi sửa
        public void closeBtnWhenUpdate()
        {
            btnDelete.Enabled = false;
            btnCreate.Enabled = false;
            cboCate.Enabled = false;
            cboProduct.Enabled = false;
        }

        // Hàm dùng reset thông tin nhập liệu
        public void clearInfor()
        {
            txtSoLuong.Text = "";
            txtPrice.Text = "";
        }

        // Hàm load chương trình khi lần đàu chạy
        private void UC_ADMIN_SIZE_Load(object sender, EventArgs e)
        {

            loadComboBox();
            int cate_id = int.Parse(cboCate.SelectedValue.ToString());
            loadComboBoxProduct(cate_id);
            closeComponent();
            int pro_id = int.Parse(cboProduct.SelectedValue.ToString());

            loadList(pro_id);

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

        // Hàm của btnSave lưu size mới
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("vui lòng nhập số lượng trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("vui lòng nhập số tiền trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int quantity=int.Parse(txtSoLuong.Text);
            decimal price=decimal.Parse(txtPrice.Text);
            int pro_id=int.Parse(cboProduct.SelectedValue.ToString());
            int size_id = int.Parse(cboSize.SelectedValue.ToString());

            if (string.IsNullOrEmpty(cboSize.SelectedValue.ToString()))
            {
                MessageBox.Show("Chọn size trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cboProduct.SelectedValue.ToString()))
            {
                MessageBox.Show("Chọn sản phẩm trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Nhập số lượng trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            if(string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Nhập giá trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            bool isExist=provar.checkProductVariant(pro_id, size_id);

            if(isExist)
            {
                MessageBox.Show("Liên kết đã tồn tại vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductVariant p = new ProductVariant
            {
                Pro_Id = pro_id,
                Size_Id = size_id,
                Quantity = quantity,
                Price = price,
            };
          
            bool checkSuccess=provar.insertProductVariant(p);
            if(checkSuccess)
            {
                clearInfor();
                closeComponent();
                openBtn();
                loadList(pro_id);
                MessageBox.Show("Thêm liên kết mới thành công !");
            }
            else
            {
                MessageBox.Show("Thêm lỗi vui lòng kiểm tra lại !");
            }    
        }

        // Hàm của btnDelete dùng xóa size
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgDSSP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn liên kết trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            DataGridViewRow selectedRow = dgDSSP.SelectedRows[0];
            string Name = selectedRow.Cells["ProName"].Value.ToString();
            int Id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
            string Size = selectedRow.Cells["SizeName"].Value.ToString();
            int Pro_id = int.Parse(selectedRow.Cells["Pro_Id"].Value.ToString());

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa liên kết: {Name} với size: {Size}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                try
                {
                    bool isDeleted = provar.deleteProductVarian(Id);

                    if (isDeleted)
                    {
                        MessageBox.Show($"Liên kết {Name} với size: {Size} đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInfor();
                        loadList(Pro_id);
                    }
                    else
                    {
                        MessageBox.Show($"Không thể xóa liên kết {Name} với size: {Size}. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi xóa size: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        // Hàm sự kiện khi tùy chỉnh chọn các cate
        private void cboCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCate.SelectedValue != null)
            {
                int cate_id = int.Parse(cboCate.SelectedValue.ToString());
                loadComboBoxProduct(cate_id);
            }

        }

        // Hàm sự kiện khi chọn các product
        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboProduct.SelectedValue != null)
            {
                int pro_id = int.Parse(cboProduct.SelectedValue.ToString());

                loadList(pro_id);
            }
           
        }

        // Hàm sự kiện btnEdit 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgDSSP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn liên kết trong danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            closeBtnWhenUpdate();
            openComponentForUpdate();
        }

       
        // Hàm sự kiện click của dgDSSP
        private void dgDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgDSSP.Rows[e.RowIndex];
                txtSoLuong.Text = selectedRow.Cells["Quantity"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
            }
        }

        // Hàm sửa liên kết sản phẩm khi click button fix
        private void btnfix_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgDSSP.SelectedRows[0];
            int quantity;
            if(string.IsNullOrEmpty(txtSoLuong.Text))
            {
               quantity = 0;
            }    
            quantity = int.Parse(txtSoLuong.Text);
            string Name = selectedRow.Cells["ProName"].Value.ToString();
            int pro_id = int.Parse(selectedRow.Cells["Pro_Id"].Value.ToString());
            string Size = selectedRow.Cells["SizeName"].Value.ToString();
            int id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
            decimal price;
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                price = 0;
            }
            price = decimal.Parse(txtPrice.Text);

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn sửa liên kết: {Name} với size {Size}?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                try
                {
                    bool isUpdate = provar.updateProductVariant(id,quantity,price);

                    if (isUpdate)
                    {

                        openBtn();
                        loadList(pro_id);
                        closeComponent();
                        clearInfor();
                        MessageBox.Show($"Liên kết đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show($"Không thể cập nhật liên kết {Name} với size {Size}. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi sửa liên kết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
