namespace CoffeeHouse_Winform
{
    partial class UC_ADMIN_ORDER
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
            this.label6 = new System.Windows.Forms.Label();
            this.panelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.cboStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboPaymentStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOrderId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClearFilter = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dg_donhang = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dg_chitietdonhang = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerPayment = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelControl.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_donhang)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_chitietdonhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(479, 52);
            this.label6.TabIndex = 18;
            this.label6.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl.BorderRadius = 16;
            this.panelControl.BorderThickness = 1;
            this.panelControl.Controls.Add(this.cboStatus);
            this.panelControl.Controls.Add(this.label13);
            this.panelControl.Controls.Add(this.cboPaymentStatus);
            this.panelControl.Controls.Add(this.dateTimePickerPayment);
            this.panelControl.Controls.Add(this.txtTotalPrice);
            this.panelControl.Controls.Add(this.txtCustomerName);
            this.panelControl.Controls.Add(this.txtOrderId);
            this.panelControl.Controls.Add(this.label5);
            this.panelControl.Controls.Add(this.label10);
            this.panelControl.Controls.Add(this.label11);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.label9);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Location = new System.Drawing.Point(28, 104);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1636, 179);
            this.panelControl.TabIndex = 29;
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboStatus.BorderColor = System.Drawing.Color.Green;
            this.cboStatus.BorderRadius = 10;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cboStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboStatus.ForeColor = System.Drawing.Color.Black;
            this.cboStatus.ItemHeight = 36;
            this.cboStatus.Location = new System.Drawing.Point(1298, 123);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(248, 42);
            this.cboStatus.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1295, 100);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 16);
            this.label13.TabIndex = 48;
            this.label13.Text = "Trạng thái đơn hàng";
            // 
            // cboPaymentStatus
            // 
            this.cboPaymentStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboPaymentStatus.BorderColor = System.Drawing.Color.Green;
            this.cboPaymentStatus.BorderRadius = 10;
            this.cboPaymentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentStatus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cboPaymentStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPaymentStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboPaymentStatus.ForeColor = System.Drawing.Color.Black;
            this.cboPaymentStatus.ItemHeight = 36;
            this.cboPaymentStatus.Location = new System.Drawing.Point(1298, 35);
            this.cboPaymentStatus.Name = "cboPaymentStatus";
            this.cboPaymentStatus.Size = new System.Drawing.Size(248, 42);
            this.cboPaymentStatus.TabIndex = 47;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderColor = System.Drawing.Color.Green;
            this.txtTotalPrice.BorderRadius = 10;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(993, 95);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotalPrice.PlaceholderText = "Tổng tiền";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(258, 43);
            this.txtTotalPrice.TabIndex = 35;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderColor = System.Drawing.Color.Green;
            this.txtCustomerName.BorderRadius = 10;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.Location = new System.Drawing.Point(311, 94);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCustomerName.PlaceholderText = "Tên khách hàng";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(243, 43);
            this.txtCustomerName.TabIndex = 36;
            // 
            // txtOrderId
            // 
            this.txtOrderId.BorderColor = System.Drawing.Color.Green;
            this.txtOrderId.BorderRadius = 10;
            this.txtOrderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderId.DefaultText = "";
            this.txtOrderId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrderId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrderId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderId.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtOrderId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.ForeColor = System.Drawing.Color.Black;
            this.txtOrderId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderId.Location = new System.Drawing.Point(18, 92);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.PasswordChar = '\0';
            this.txtOrderId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOrderId.PlaceholderText = "Mã đơn hàng";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.SelectedText = "";
            this.txtOrderId.Size = new System.Drawing.Size(230, 43);
            this.txtOrderId.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(990, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng thanh toán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(14, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(322, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "Thông tin chi tiết đơn hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 88);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1299, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng thái thanh toán";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 16;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnClearFilter);
            this.guna2Panel1.Controls.Add(this.comboBoxMonth);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.dg_donhang);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label12);
            this.guna2Panel1.Location = new System.Drawing.Point(28, 304);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(945, 636);
            this.guna2Panel1.TabIndex = 45;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BorderRadius = 12;
            this.btnClearFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearFilter.FillColor = System.Drawing.Color.Red;
            this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClearFilter.Location = new System.Drawing.Point(376, 99);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(180, 42);
            this.btnClearFilter.TabIndex = 48;
            this.btnClearFilter.Text = "Xoá bộ lọc";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxMonth.BorderColor = System.Drawing.Color.Green;
            this.comboBoxMonth.BorderRadius = 10;
            this.comboBoxMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxMonth.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMonth.ItemHeight = 36;
            this.comboBoxMonth.Location = new System.Drawing.Point(110, 99);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(248, 42);
            this.comboBoxMonth.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Chọn tháng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "Lọc theo";
            // 
            // dg_donhang
            // 
            this.dg_donhang.AllowUserToAddRows = false;
            this.dg_donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_donhang.Location = new System.Drawing.Point(19, 163);
            this.dg_donhang.Margin = new System.Windows.Forms.Padding(4);
            this.dg_donhang.Name = "dg_donhang";
            this.dg_donhang.RowHeadersWidth = 51;
            this.dg_donhang.Size = new System.Drawing.Size(911, 459);
            this.dg_donhang.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Danh sách đơn hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.BorderRadius = 16;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.dg_chitietdonhang);
            this.guna2Panel2.Controls.Add(this.label18);
            this.guna2Panel2.Controls.Add(this.label19);
            this.guna2Panel2.Location = new System.Drawing.Point(979, 304);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(685, 636);
            this.guna2Panel2.TabIndex = 50;
            // 
            // dg_chitietdonhang
            // 
            this.dg_chitietdonhang.AllowUserToAddRows = false;
            this.dg_chitietdonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_chitietdonhang.Location = new System.Drawing.Point(18, 64);
            this.dg_chitietdonhang.Margin = new System.Windows.Forms.Padding(4);
            this.dg_chitietdonhang.Name = "dg_chitietdonhang";
            this.dg_chitietdonhang.RowHeadersWidth = 51;
            this.dg_chitietdonhang.Size = new System.Drawing.Size(639, 558);
            this.dg_chitietdonhang.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(14, 16);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(210, 29);
            this.label18.TabIndex = 23;
            this.label18.Text = "Chi tiết đơn hàng";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 88);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 16);
            this.label19.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày thanh toán";
            // 
            // dateTimePickerPayment
            // 
            this.dateTimePickerPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerPayment.BorderColor = System.Drawing.Color.Green;
            this.dateTimePickerPayment.BorderRadius = 12;
            this.dateTimePickerPayment.BorderThickness = 1;
            this.dateTimePickerPayment.Checked = true;
            this.dateTimePickerPayment.FillColor = System.Drawing.Color.White;
            this.dateTimePickerPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerPayment.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerPayment.Location = new System.Drawing.Point(617, 96);
            this.dateTimePickerPayment.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerPayment.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerPayment.Name = "dateTimePickerPayment";
            this.dateTimePickerPayment.Size = new System.Drawing.Size(321, 43);
            this.dateTimePickerPayment.TabIndex = 42;
            this.dateTimePickerPayment.Value = new System.DateTime(2023, 12, 10, 10, 26, 18, 168);
            // 
            // UC_ADMIN_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.label6);
            this.Name = "UC_ADMIN_ORDER";
            this.Size = new System.Drawing.Size(1721, 1057);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_donhang)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_chitietdonhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel panelControl;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtOrderId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnClearFilter;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_donhang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView dg_chitietdonhang;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2ComboBox cboStatus;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox cboPaymentStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerPayment;
        private System.Windows.Forms.Label label4;
    }
}
