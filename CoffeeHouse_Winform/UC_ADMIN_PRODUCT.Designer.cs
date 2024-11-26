namespace CoffeeHouse_Winform
{
    partial class UC_ADMIN_PRODUCT
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.panelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_cancelSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnfix = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDataList = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dgDSSP = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePro = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboCate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnImage = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBoxUp = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panelControl.SuspendLayout();
            this.panelDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(471, 52);
            this.label6.TabIndex = 17;
            this.label6.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl.BorderRadius = 16;
            this.panelControl.BorderThickness = 1;
            this.panelControl.Controls.Add(this.btnSave);
            this.panelControl.Controls.Add(this.pictureBoxUp);
            this.panelControl.Controls.Add(this.guna2CirclePictureBox1);
            this.panelControl.Controls.Add(this.guna2PictureBox1);
            this.panelControl.Controls.Add(this.btnImage);
            this.panelControl.Controls.Add(this.cboCate);
            this.panelControl.Controls.Add(this.cboType);
            this.panelControl.Controls.Add(this.txtName);
            this.panelControl.Controls.Add(this.btn_cancelSave);
            this.panelControl.Controls.Add(this.btnfix);
            this.panelControl.Controls.Add(this.btnClear);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.btnCreate);
            this.panelControl.Controls.Add(this.btnDelete);
            this.panelControl.Controls.Add(this.btnEdit);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.label8);
            this.panelControl.Controls.Add(this.label9);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Location = new System.Drawing.Point(19, 130);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1646, 267);
            this.panelControl.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.Green;
            this.txtName.BorderRadius = 10;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(18, 113);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "Nhập tên sản phẩm";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(373, 43);
            this.txtName.TabIndex = 34;
            // 
            // btn_cancelSave
            // 
            this.btn_cancelSave.BorderRadius = 12;
            this.btn_cancelSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelSave.ForeColor = System.Drawing.Color.White;
            this.btn_cancelSave.Location = new System.Drawing.Point(753, 195);
            this.btn_cancelSave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelSave.Name = "btn_cancelSave";
            this.btn_cancelSave.Size = new System.Drawing.Size(140, 50);
            this.btn_cancelSave.TabIndex = 14;
            this.btn_cancelSave.Text = "Không lưu";
            this.btn_cancelSave.Click += new System.EventHandler(this.btn_cancelSave_Click);
            // 
            // btnfix
            // 
            this.btnfix.BorderRadius = 12;
            this.btnfix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfix.FillColor = System.Drawing.Color.Green;
            this.btnfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfix.ForeColor = System.Drawing.Color.White;
            this.btnfix.Location = new System.Drawing.Point(407, 195);
            this.btnfix.Margin = new System.Windows.Forms.Padding(4);
            this.btnfix.Name = "btnfix";
            this.btnfix.Size = new System.Drawing.Size(140, 50);
            this.btnfix.TabIndex = 13;
            this.btnfix.Text = "Sửa ";
            this.btnfix.Click += new System.EventHandler(this.btnfix_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 12;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(921, 195);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(178, 50);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Xoá thông tin";
            this.btnClear.UseTransparentBackground = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1232, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ảnh sản phẩm";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderRadius = 12;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.LimeGreen;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(1050, 18);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 45);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.Text = "Thêm sản phẩm";
            this.btnCreate.UseTransparentBackground = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 12;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1249, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Xoá sản phẩm";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 12;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1446, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 45);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(834, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh mục sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(14, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Thông tin chi tiết sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên sản phẩm";
            // 
            // panelDataList
            // 
            this.panelDataList.BackColor = System.Drawing.Color.White;
            this.panelDataList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDataList.BorderRadius = 16;
            this.panelDataList.BorderThickness = 1;
            this.panelDataList.Controls.Add(this.label11);
            this.panelDataList.Controls.Add(this.dgDSSP);
            this.panelDataList.Location = new System.Drawing.Point(19, 403);
            this.panelDataList.Name = "panelDataList";
            this.panelDataList.Size = new System.Drawing.Size(1646, 544);
            this.panelDataList.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(14, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "Danh sách sản phẩm";
            // 
            // dgDSSP
            // 
            this.dgDSSP.AllowUserToAddRows = false;
            this.dgDSSP.BackgroundColor = System.Drawing.Color.White;
            this.dgDSSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgDSSP.ColumnHeadersHeight = 40;
            this.dgDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ImagePro,
            this.ProName,
            this.Type,
            this.Cate});
            this.dgDSSP.Location = new System.Drawing.Point(18, 58);
            this.dgDSSP.Margin = new System.Windows.Forms.Padding(4);
            this.dgDSSP.Name = "dgDSSP";
            this.dgDSSP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgDSSP.RowHeadersWidth = 40;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Green;
            this.dgDSSP.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgDSSP.Size = new System.Drawing.Size(1608, 468);
            this.dgDSSP.TabIndex = 0;
            this.dgDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSSP_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // ImagePro
            // 
            this.ImagePro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImagePro.HeaderText = "Ảnh";
            this.ImagePro.MinimumWidth = 6;
            this.ImagePro.Name = "ImagePro";
            // 
            // ProName
            // 
            this.ProName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProName.FillWeight = 200F;
            this.ProName.HeaderText = "Tên Sản Phẩm";
            this.ProName.MinimumWidth = 6;
            this.ProName.Name = "ProName";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Loại";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // Cate
            // 
            this.Cate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cate.HeaderText = "Danh mục";
            this.Cate.MinimumWidth = 6;
            this.Cate.Name = "Cate";
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.Transparent;
            this.cboType.BorderRadius = 10;
            this.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboType.ItemHeight = 30;
            this.cboType.Location = new System.Drawing.Point(424, 116);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(373, 36);
            this.cboType.TabIndex = 38;
            // 
            // cboCate
            // 
            this.cboCate.BackColor = System.Drawing.Color.Transparent;
            this.cboCate.BorderRadius = 10;
            this.cboCate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCate.ItemHeight = 30;
            this.cboCate.Location = new System.Drawing.Point(837, 116);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(373, 36);
            this.cboCate.TabIndex = 39;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.Transparent;
            this.btnImage.BorderRadius = 12;
            this.btnImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImage.FillColor = System.Drawing.Color.LimeGreen;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(1233, 111);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(180, 45);
            this.btnImage.TabIndex = 40;
            this.btnImage.Text = "Tải ảnh";
            this.btnImage.UseTransparentBackground = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1471, 113);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.TabIndex = 41;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1434, 130);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(112, 26);
            this.guna2CirclePictureBox1.TabIndex = 42;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.ImageRotate = 0F;
            this.pictureBoxUp.Location = new System.Drawing.Point(1446, 78);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(147, 113);
            this.pictureBoxUp.TabIndex = 43;
            this.pictureBoxUp.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 12;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(580, 195);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 50);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Lưu mới";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UC_ADMIN_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDataList);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.label6);
            this.Name = "UC_ADMIN_PRODUCT";
            this.Size = new System.Drawing.Size(1700, 1026);
            this.Load += new System.EventHandler(this.UC_ADMIN_PRODUCT_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelDataList.ResumeLayout(false);
            this.panelDataList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel panelControl;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button btn_cancelSave;
        private Guna.UI2.WinForms.Guna2Button btnfix;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panelDataList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgDSSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn ImagePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cate;
        private Guna.UI2.WinForms.Guna2ComboBox cboCate;
        private Guna.UI2.WinForms.Guna2ComboBox cboType;
        private Guna.UI2.WinForms.Guna2Button btnImage;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxUp;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}
