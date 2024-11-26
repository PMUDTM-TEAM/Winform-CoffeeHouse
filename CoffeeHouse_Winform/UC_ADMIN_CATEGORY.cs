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
    public partial class UC_ADMIN_CATEGORY : UserControl
    {
        private ProductBLL pro;
        private CategoryBLL cate;

        public UC_ADMIN_CATEGORY()
        {
            InitializeComponent();
            pro = new ProductBLL();
            cate=new CategoryBLL();
        }

        // Hàm load danh sách sản phẩm lên dgDSSP
        public void loadList()
        {
            var categories = cate.getCateWithProducts();
            dgDSSP.Rows.Clear();


            foreach (var category in categories)
            {
                dgDSSP.Rows.Add(category.Id,category.Name,category.CountProducts);
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
            btnfix.Enabled=false;
            btnSave.Enabled=false;
            btn_cancelSave.Enabled=false;
            btnClear.Enabled=false;
        }

        // Hàm mở các component cho việc thêm mới sản phẩm
        public void openComponentForInsert()
        {
            txtName.Enabled = true;
            btnSave.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnClear.Enabled = true;
        }

        // Hàm mở các component cho việc cập nhật sản phẩm
        public void openComponentForUpdate()
        {
            txtName.Enabled = true;
            btnfix.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnClear.Enabled = true;
        }

        // Hàm dùng reset thông tin nhập liệu
        public void clearInfor()
        {
            txtName.Text = "";
           
        }

        // Hàm tạo Slug
        public static string ToSlug(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

        
            string normalizedText = text.ToLowerInvariant();

            
            normalizedText = RemoveDiacritics(normalizedText);

         
            normalizedText = Regex.Replace(normalizedText, @"[^a-z0-9\s-]", "");

            
            normalizedText = Regex.Replace(normalizedText, @"[\s-]+", "-").Trim('-');

            return normalizedText;
        }

        // Hàm bỏ dấu tiếng việt
        private static string RemoveDiacritics(string text)
        {
            var normalizedText = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedText)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
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
                txtName.Text = selectedRow.Cells["CateName"].Value.ToString();
            }
        }

        // Hàm của btnSave lưu sản phẩm mới
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            string slug=ToSlug(name);

            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập tên trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }         
           
            Category category = new Category
            {
                Name = name,
                Slug = slug,
            };
          
            bool checkSuccess=cate.insertCategory(category);
            if(checkSuccess)
            {
                clearInfor();
                closeComponent();
                openBtn();
                loadList();
                MessageBox.Show("Thêm danh mục mới thành công !");
            }
            else
            {
                MessageBox.Show("Thêm lỗi vui lòng kiểm tra lại !");
            }    
        }

        // Hàm của btnDelete dùng xóa sản phẩm
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgDSSP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            DataGridViewRow selectedRow = dgDSSP.SelectedRows[0];
            string cateName = selectedRow.Cells["CateName"].Value.ToString();
            int Id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
            
            
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa danh mục: {cateName}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                try
                {
                    bool isDeleted = cate.deleteCategory(Id);

                    if (isDeleted)
                    {
                        MessageBox.Show($"Danh mục {cateName} đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInfor();
                        loadList();
                    }
                    else
                    {
                        MessageBox.Show($"Không thể xóa danh mục {cateName}. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi xóa danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm của btnEdit dùng để kích hoạt các component update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgDSSP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục trong danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            closeBtnWhenUpdate();
            openComponentForUpdate();
        }

        // Hàm của btnFix dùng để cập nhật sản phẩm
        private void btnfix_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgDSSP.SelectedRows[0];
            string name = txtName.Text;
            int id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
            string slug = "";
            if (!string.IsNullOrEmpty(name))
            {
                 slug = ToSlug(name);
            }    


            DialogResult result = MessageBox.Show($"Bạn có chắc muốn sửa danh mục: {name}?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                try
                {
                    bool isUpdate = cate.updateCategory(id,name,slug);

                    if (isUpdate)
                    {
                       
                            openBtn();
                            loadList();
                            closeComponent();
                            clearInfor();
                            MessageBox.Show($"Danh mục đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           

                    }
                    else
                    {
                        MessageBox.Show($"Không thể cập nhật danh mục {name}. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi xóa danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
