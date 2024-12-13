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
    public partial class UC_ADMIN_WAREHOUSE : UserControl
    {
        private SizeBLL size;
        private ProductBLL product;
        private ProductVariantBLL provar;
        private CategoryBLL cate;
        private WarehouseBLL ware;

        public UC_ADMIN_WAREHOUSE()
        {
            InitializeComponent();
            size=new SizeBLL();
            product=new ProductBLL();
            provar=new ProductVariantBLL();
            cate=new CategoryBLL();
            ware=new WarehouseBLL();
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

        // Hàm load danh sách nhập kho của sản phẩm
        public void loadDgvNhaphang(int[] Provar_id)
        {
            var warehouse =ware.getWarehouse(Provar_id);
            dgvNhapHang.Rows.Clear();
            foreach (var p in warehouse)
            {
                dgvNhapHang.Rows.Add(p.Id, p.Provar_id, p.Pro_Name, p.Size_Name, p.Quantity, p.Day_In);
            }
        }

        // Hàm dùng close các button khác khi thêm mới
        public void closeBtnWhenInsert()
        {
          
          
        }

        // Hàm mở các button thực hiện chức năng
        public void openBtn()
        {
            
            btnCreate.Enabled=true;
           
            cboProduct.Enabled = true;
            cboCate.Enabled = true;
        }

        // Hàm đóng tất cả các component
        public void closeComponent()
        {
          
            txtQuantity.Enabled=false;
           
            btnSave.Enabled=false;
            btn_cancelSave.Enabled=false;
            btnClear.Enabled=false;
            cboSize.Enabled=false;
        }

        // Hàm mở các component cho việc thêm mới liên kết
        public void openComponentForInsert()
        {
            
            txtQuantity.Enabled=true;
            btnSave.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnClear.Enabled = true;
            cboSize.Enabled = true;
        }

        // Hàm mở các component khi sửa liên kết
        public void openComponentForUpdate()
        {
          
            txtQuantity.Enabled=true;
          
            btn_cancelSave.Enabled = true;
            btnClear.Enabled = true;
        }

        // Hàm đóng khi sửa
        public void closeBtnWhenUpdate()
        {
           
            btnCreate.Enabled = false;
            cboCate.Enabled = false;
            cboProduct.Enabled = false;
        }

        // Hàm dùng reset thông tin nhập liệu
        public void clearInfor()
        {
          
            txtQuantity.Text = "";
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
            if(dgDSSP.Rows.Count > 0)
            {
                List<int> Provar_idList = new List<int>();

                for (int i = 0; i < dgDSSP.Rows.Count; i++)
                {
                    
                    var cellValue = dgDSSP.Rows[i].Cells["Id"].Value;

                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                    {
                        Provar_idList.Add(id); 
                    }
                }

                int[] Provar_id = Provar_idList.ToArray();

                loadDgvNhaphang(Provar_id);

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

        // Hàm của btnSave lưu size mới
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("vui lòng nhập số lượng nhập hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
           
            int quantity=int.Parse(txtQuantity.Text);
            if(!(quantity > 0))
            {
                MessageBox.Show("vui lòng nhập số lượng nhập hàng lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            int pro_id=int.Parse(cboProduct.SelectedValue.ToString());
            int size_id = int.Parse(cboSize.SelectedValue.ToString());
            string Name=cboProduct.Text;
            string Size=cboSize.Text;
            if (string.IsNullOrEmpty(cboSize.SelectedValue.ToString()))
            {
                MessageBox.Show("Chọn size trước nhập hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cboProduct.SelectedValue.ToString()))
            {
                MessageBox.Show("Chọn sản phẩm trước khi nhập hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if(string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Nhập số lượng đẻ nhập hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            bool isExist=provar.checkProductVariant(pro_id, size_id);

            if(!isExist)
            {
                MessageBox.Show($"Sản phẩm {Name} hiện không có size: {Size}. Vui lòng nhập hàng lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool checkInsertWarehouse=ware.insertWarehouse(quantity,pro_id, size_id);
            bool checkInsertQuantityProvar=provar.insertQuantityProductVariant(quantity,pro_id, size_id);   
            if(checkInsertWarehouse && checkInsertQuantityProvar)
            {
                clearInfor();
                closeComponent();
                openBtn();
                loadList(pro_id);
                if (dgDSSP.Rows.Count > 0)
                {
                    List<int> Provar_idList = new List<int>();

                    for (int i = 0; i < dgDSSP.Rows.Count; i++)
                    {

                        var cellValue = dgDSSP.Rows[i].Cells["Id"].Value;

                        if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                        {
                            Provar_idList.Add(id);
                        }
                    }

                    int[] Provar_id = Provar_idList.ToArray();

                    loadDgvNhaphang(Provar_id);

                }

                MessageBox.Show($"Sản phẩm {Name} size: {Size} đã nhập hàng thành công. Thêm {quantity} sản phẩm!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            else
            {
                MessageBox.Show($"Lỗi kìa trời check lại coi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
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
                if (dgDSSP.Rows.Count > 0)
                {
                    List<int> Provar_idList = new List<int>();

                    for (int i = 0; i < dgDSSP.Rows.Count; i++)
                    {

                        var cellValue = dgDSSP.Rows[i].Cells["Id"].Value;

                        if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                        {
                            Provar_idList.Add(id);
                        }
                    }

                    int[] Provar_id = Provar_idList.ToArray();

                    loadDgvNhaphang(Provar_id);

                }

            }
           
        }

       

       
        // Hàm sự kiện click của dgDSSP
        private void dgDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgDSSP.Rows[e.RowIndex];
               
                txtQuantity.Text = selectedRow.Cells["Price"].Value.ToString();
            }
        }

        // Hàm sự kiện click của dgvNhapHang
        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
