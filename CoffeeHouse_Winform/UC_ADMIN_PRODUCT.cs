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
    public partial class UC_ADMIN_PRODUCT : UserControl
    {
        private ProductBLL pro;
        private CategoryBLL cate;
        public UC_ADMIN_PRODUCT()
        {
            InitializeComponent();
            pro = new ProductBLL();
            cate=new CategoryBLL();
        }

        // Hàm load danh sách sản phẩm lên dgDSSP
        public void loadList()
        {
            var products = pro.getProductsAndCateName();
            dgDSSP.Rows.Clear();


            foreach (var product in products)
            {

                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", product.Image);


                System.Drawing.Image img = null;

                if (File.Exists(imagePath))
                {

                    using (var imageSharp = Image.Load(imagePath)) // Đọc ảnh bằng ImageSharp
                    {
                        // Chuyển đổi từ ImageSharp sang System.Drawing.Image
                        img = ConvertToImage(imageSharp);
                    }
                }


                System.Drawing.Image thumbnail = img.GetThumbnailImage(100, 100, null, IntPtr.Zero);
                int rowHeight = thumbnail.Height;
                dgDSSP.RowTemplate.Height = rowHeight;

                dgDSSP.Rows.Add(product.Id, thumbnail, product.Name, product.Type, product.CategoryName);
            }
        }

        // Hàm Load các combobox
        public void loadComboBox()
        {
            cboCate.DataSource=cate.getCategories();
            cboCate.DisplayMember="Name";
            cboCate.ValueMember="Id";

            string[] type = { "New", "Hot" };
            cboType.DataSource=type;

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
            cboType.Enabled=false;
            cboCate.Enabled=false;
            btnfix.Enabled=false;
            btnSave.Enabled=false;
            btn_cancelSave.Enabled=false;
            btnImage.Enabled=false;
            btnClear.Enabled=false;
        }

        // Hàm mở các component cho việc thêm mới sản phẩm
        public void openComponentForInsert()
        {
            txtName.Enabled = true;
            cboType.Enabled = true;
            cboCate.Enabled = true;
            btnSave.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnImage.Enabled = true;
            btnClear.Enabled = true;
        }

        // Hàm mở các component cho việc cập nhật sản phẩm
        public void openComponentForUpdate()
        {
            txtName.Enabled = true;
            cboType.Enabled = true;
            cboCate.Enabled = true;
            btnfix.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnImage.Enabled = true;
            btnClear.Enabled = true;
        }

        // Hàm dùng reset thông tin nhập liệu
        public void clearInfor()
        {
            txtName.Text = "";
            cboCate.SelectedIndex = 0;
            cboType.SelectedIndex = 0;
            if (pictureBoxUp.Image != null)
            {
                pictureBoxUp.Image.Dispose();
                pictureBoxUp.Image = null;
            }
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
            loadComboBox();
            closeComponent();
            
        }

        // Hàm convertImage chủ yếu là image có đuôi Webp không dùng System.Drawing bình thường được
        private System.Drawing.Image ConvertToImage(SixLabors.ImageSharp.Image imageSharp)
        {
            using (var ms = new MemoryStream())
            {
                
                imageSharp.SaveAsBmp(ms);
                ms.Seek(0, SeekOrigin.Begin); 

               
                return System.Drawing.Image.FromStream(ms);
            }
        }

        // Biến toàn cục đường dẫn ảnh tải lên
        private string imagePath = "";

        // Biến toàn cục đường dẫn đến Web
        private string webImagePath = "D:\\HK7\\Ứng dụng thông minh\\Đồ án\\Web\\Web-CoffeeHouse\\CoffeeHouse\\wwwroot\\imgs";

        // Sự kiện nút up ảnh lên
        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Chỉ định các loại file ảnh có thể chọn
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.webp";
                openFileDialog.Title = "Chọn ảnh để tải lên";

                // Nếu người dùng nhấn OK và chọn file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName; // Lấy đường dẫn file đã chọn
                    imagePath = openFileDialog.FileName;
                    try
                    {
                        // Dùng ImageSharp để xử lý tất cả các định dạng ảnh
                        using (var imageSharp = SixLabors.ImageSharp.Image.Load(selectedFilePath))
                        {
                            // Resize ảnh về 100x100
                            imageSharp.Mutate(x => x.Resize(100, 100));

                            // Chuyển đổi từ ImageSharp sang System.Drawing.Image
                            var resizedImage = ConvertToImage(imageSharp);

                            // Hiển thị ảnh đã resize lên PictureBox
                            if (pictureBoxUp.Image != null)
                            {
                                pictureBoxUp.Image.Dispose(); // Giải phóng ảnh cũ
                            }

                            pictureBoxUp.Image = resizedImage; // Gán ảnh mới
                        }

                       
                        MessageBox.Show("Tải ảnh lên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show($"Không thể tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                txtName.Text = selectedRow.Cells["ProName"].Value.ToString();
                string typeValue = selectedRow.Cells["Type"].Value.ToString();

                for (int i = 0; i < cboType.Items.Count; i++)
                {
                    if (cboType.Items[i].ToString() == typeValue)
                    {
                        cboType.SelectedIndex = i;
                        break;
                    }
                }

                string categoryValue = selectedRow.Cells["Cate"].Value.ToString();
                for (int i = 0; i < cboCate.Items.Count; i++)
                {
                    
                    var item = cboCate.Items[i];
                    if (item is DataRowView dataRowView && dataRowView["Name"].ToString() == categoryValue)
                    {
                        cboCate.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        // Sự kiện thêm ảnh vào trong các folder
        public void upImageToFolders(string imageName)
        {
            // Đảm bảo lấy đúng thư mục gốc của dự án
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imageDirectory = Path.Combine(projectDirectory, "Images");

            // Lấy trong bin đang chạy
            string projectDirectoryBin = AppDomain.CurrentDomain.BaseDirectory;
            string imageDirectoryBin = Path.Combine(projectDirectoryBin, "Images");

            // Kiểm tra nếu thư mục Images chưa tồn tại, tạo mới
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }

            if (!Directory.Exists(imageDirectoryBin))
            {
                Directory.CreateDirectory(imageDirectoryBin);
            }
            if (!Directory.Exists(webImagePath))
            {
                Directory.CreateDirectory(webImagePath);
            }

            // Đường dẫn đầy đủ của ảnh sao chép
            string destinationImagePath = Path.Combine(imageDirectory, imageName);
            string destinationImagePathBin = Path.Combine(imageDirectoryBin, imageName);
            string destinationImagePathWeb = Path.Combine(webImagePath, imageName);
            try
            {
                // Kiểm tra xem ảnh có tồn tại không, nếu có thì xóa đi
                if (File.Exists(destinationImagePath))
                {
                    File.Delete(destinationImagePath);
                }
                if (File.Exists(destinationImagePathBin))
                {
                    File.Delete(destinationImagePathBin);
                }
                if (File.Exists(destinationImagePathWeb))
                {
                    File.Delete(destinationImagePathWeb);
                }

                // Sao chép ảnh vào thư mục Images
                File.Copy(imagePath, destinationImagePath);
                File.Copy(imagePath, destinationImagePathBin);
                File.Copy(imagePath, destinationImagePathWeb);

                loadList();
                clearInfor();
                closeComponent();
                openBtn();
                MessageBox.Show("Sản phẩm và ảnh đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm của btnSave lưu sản phẩm mới
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            string slug=ToSlug(name);
            string type=cboType.SelectedItem.ToString();    
            int cate_id=int.Parse(cboCate.SelectedValue.ToString());
            string image = imagePath;

            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập tên trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
          
            if (string.IsNullOrEmpty(image))
            {
                MessageBox.Show("Vui lòng tải ảnh lên trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string imageName = Path.GetFileName(imagePath);
           
            Product product = new Product
            {
                Name = name,
                Slug = slug,
                Type = type,
                Image = imageName,
                Cate_Id = cate_id,
            };
          
            bool checkSuccess=pro.insertProduct(product);
            if(checkSuccess)
            {
                upImageToFolders(imageName);
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
                MessageBox.Show("Vui lòng chọn sản phẩm trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            DataGridViewRow selectedRow = dgDSSP.SelectedRows[0];
            string productName = selectedRow.Cells["ProName"].Value.ToString();
            int Id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
            
            
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm: {productName}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                try
                {
                    bool isDeleted = pro.deleteProduct(Id);

                    if (isDeleted)
                    {
                        MessageBox.Show($"Sản phẩm {productName} đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInfor();
                        loadList();
                    }
                    else
                    {
                        MessageBox.Show($"Không thể xóa sản phẩm {productName}. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi xóa sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm của btnEdit dùng để kích hoạt các component update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgDSSP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            
            string type = cboType.SelectedItem.ToString();
            int cate_id = int.Parse(cboCate.SelectedValue.ToString());
            string image = imagePath;

            string imageName = "";
            if (!string.IsNullOrEmpty(image))
            {
                imageName = Path.GetFileName(imagePath);
            }
           

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn sửa sản phẩm: {name}?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                try
                {
                    bool isUpdate = pro.updateProduct(id,name,slug,type,cate_id,imageName);

                    if (isUpdate)
                    {
                        if(!string.IsNullOrEmpty(imageName))
                        {
                            upImageToFolders(imageName);
                        }
                       
                        else
                        {
                            openBtn();
                            loadList();
                            closeComponent();
                            clearInfor();
                            MessageBox.Show($"Sản phẩm {name} đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    

                    }
                    else
                    {
                        MessageBox.Show($"Không thể cập nhật sản phẩm {name}. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi sửa sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
