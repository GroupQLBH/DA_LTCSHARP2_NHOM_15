namespace QuanLyBanHang
{
    partial class FrmQuanLyKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maKhachHangLabel;
            System.Windows.Forms.Label tenKhachHangLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label soDienThoaiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label label1;
            this.quanLyBanHang_DataSet = new QuanLyBanHang.QuanLyBanHang_DataSet();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager();
            this.khachHangDataGridView = new System.Windows.Forms.DataGridView();
            this.maKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.tenKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.soDienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhTextBox = new System.Windows.Forms.ComboBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TaiKhoanTableAdapter();
            this.taiKhoanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            maKhachHangLabel = new System.Windows.Forms.Label();
            tenKhachHangLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            soDienThoaiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maKhachHangLabel
            // 
            maKhachHangLabel.AutoSize = true;
            maKhachHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhachHangLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maKhachHangLabel.Location = new System.Drawing.Point(30, 74);
            maKhachHangLabel.Name = "maKhachHangLabel";
            maKhachHangLabel.Size = new System.Drawing.Size(132, 18);
            maKhachHangLabel.TabIndex = 2;
            maKhachHangLabel.Text = "Mã Khách Hàng:";
            // 
            // tenKhachHangLabel
            // 
            tenKhachHangLabel.AutoSize = true;
            tenKhachHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenKhachHangLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            tenKhachHangLabel.Location = new System.Drawing.Point(30, 102);
            tenKhachHangLabel.Name = "tenKhachHangLabel";
            tenKhachHangLabel.Size = new System.Drawing.Size(137, 18);
            tenKhachHangLabel.TabIndex = 4;
            tenKhachHangLabel.Text = "Tên Khách Hàng:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            diaChiLabel.Location = new System.Drawing.Point(30, 130);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(68, 18);
            diaChiLabel.TabIndex = 6;
            diaChiLabel.Text = "Địa Chỉ:";
            // 
            // soDienThoaiLabel
            // 
            soDienThoaiLabel.AutoSize = true;
            soDienThoaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soDienThoaiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            soDienThoaiLabel.Location = new System.Drawing.Point(508, 77);
            soDienThoaiLabel.Name = "soDienThoaiLabel";
            soDienThoaiLabel.Size = new System.Drawing.Size(120, 18);
            soDienThoaiLabel.TabIndex = 8;
            soDienThoaiLabel.Text = "Số Diện Thoại:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            emailLabel.Location = new System.Drawing.Point(508, 105);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(55, 18);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            ngaySinhLabel.Location = new System.Drawing.Point(508, 134);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(89, 18);
            ngaySinhLabel.TabIndex = 12;
            ngaySinhLabel.Text = "Ngày Sinh:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioiTinhLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            gioiTinhLabel.Location = new System.Drawing.Point(508, 161);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(81, 18);
            gioiTinhLabel.TabIndex = 14;
            gioiTinhLabel.Text = "Giới Tính:";
            // 
            // quanLyBanHang_DataSet
            // 
            this.quanLyBanHang_DataSet.DataSetName = "QuanLyBanHang_DataSet";
            this.quanLyBanHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietDonHangTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuNhapTableAdapter = null;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.DonHangTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.KhuyenMaiTableAdapter = null;
            this.tableAdapterManager.LoaiSanPhamTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhanHoiKhachHangTableAdapter = null;
            this.tableAdapterManager.PhieuNhapHangTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.SanPhamTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.ThuongHieuTableAdapter = null;
            this.tableAdapterManager.TonKhoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khachHangDataGridView
            // 
            this.khachHangDataGridView.AutoGenerateColumns = false;
            this.khachHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.khachHangDataGridView.DataSource = this.khachHangBindingSource;
            this.khachHangDataGridView.Location = new System.Drawing.Point(33, 214);
            this.khachHangDataGridView.Name = "khachHangDataGridView";
            this.khachHangDataGridView.ReadOnly = true;
            this.khachHangDataGridView.RowHeadersWidth = 51;
            this.khachHangDataGridView.RowTemplate.Height = 24;
            this.khachHangDataGridView.Size = new System.Drawing.Size(921, 220);
            this.khachHangDataGridView.TabIndex = 1;
            this.khachHangDataGridView.SelectionChanged += new System.EventHandler(this.khachHangDataGridView_SelectionChanged);
            // 
            // maKhachHangTextBox
            // 
            this.maKhachHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "MaKhachHang", true));
            this.maKhachHangTextBox.Location = new System.Drawing.Point(172, 71);
            this.maKhachHangTextBox.Name = "maKhachHangTextBox";
            this.maKhachHangTextBox.Size = new System.Drawing.Size(200, 22);
            this.maKhachHangTextBox.TabIndex = 3;
            // 
            // tenKhachHangTextBox
            // 
            this.tenKhachHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "TenKhachHang", true));
            this.tenKhachHangTextBox.Location = new System.Drawing.Point(172, 99);
            this.tenKhachHangTextBox.Name = "tenKhachHangTextBox";
            this.tenKhachHangTextBox.Size = new System.Drawing.Size(200, 22);
            this.tenKhachHangTextBox.TabIndex = 5;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(172, 127);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(200, 22);
            this.diaChiTextBox.TabIndex = 7;
            // 
            // soDienThoaiTextBox
            // 
            this.soDienThoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "SoDienThoai", true));
            this.soDienThoaiTextBox.Location = new System.Drawing.Point(650, 74);
            this.soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            this.soDienThoaiTextBox.Size = new System.Drawing.Size(200, 22);
            this.soDienThoaiTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(650, 102);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 11;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.khachHangBindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(650, 130);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngaySinhDateTimePicker.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKhachHang";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Khách Hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKhachHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Khách Hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoDienThoai";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Điện Thoại";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày Sinh";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn7.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.FormattingEnabled = true;
            this.gioiTinhTextBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioiTinhTextBox.Location = new System.Drawing.Point(650, 154);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(112, 24);
            this.gioiTinhTextBox.TabIndex = 15;
            // 
            // btnLuu
            // 
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.Transparent;
            this.btnLuu.FillColor2 = System.Drawing.Color.Transparent;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLuu.HoverState.FillColor2 = System.Drawing.Color.Aqua;
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Image = global::QuanLyBanHang.Properties.Resources.icons8_done_50;
            this.btnLuu.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLuu.Location = new System.Drawing.Point(447, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(143, 64);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.Transparent;
            this.btnSua.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSua.HoverState.FillColor2 = System.Drawing.Color.Aqua;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = global::QuanLyBanHang.Properties.Resources.icons8_support_50;
            this.btnSua.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSua.Location = new System.Drawing.Point(298, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(143, 64);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Transparent;
            this.btnXoa.FillColor2 = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnXoa.HoverState.FillColor2 = System.Drawing.Color.Aqua;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = global::QuanLyBanHang.Properties.Resources.icons8_close_50;
            this.btnXoa.ImageSize = new System.Drawing.Size(50, 50);
            this.btnXoa.Location = new System.Drawing.Point(149, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(143, 64);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.Transparent;
            this.btnThem.FillColor2 = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnThem.HoverState.FillColor2 = System.Drawing.Color.Aqua;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = global::QuanLyBanHang.Properties.Resources.icons8_plus_50;
            this.btnThem.ImageSize = new System.Drawing.Size(50, 50);
            this.btnThem.Location = new System.Drawing.Point(0, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(143, 64);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanDataGridView
            // 
            this.taiKhoanDataGridView.AutoGenerateColumns = false;
            this.taiKhoanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taiKhoanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.taiKhoanDataGridView.DataSource = this.taiKhoanBindingSource;
            this.taiKhoanDataGridView.Location = new System.Drawing.Point(33, 460);
            this.taiKhoanDataGridView.Name = "taiKhoanDataGridView";
            this.taiKhoanDataGridView.ReadOnly = true;
            this.taiKhoanDataGridView.RowHeadersWidth = 51;
            this.taiKhoanDataGridView.RowTemplate.Height = 24;
            this.taiKhoanDataGridView.Size = new System.Drawing.Size(305, 52);
            this.taiKhoanDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MaKhachHang";
            this.dataGridViewTextBoxColumn8.HeaderText = "MaKhachHang";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TenTaiKhoan";
            this.dataGridViewTextBoxColumn9.HeaderText = "TenTaiKhoan";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.DodgerBlue;
            label1.Location = new System.Drawing.Point(30, 437);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(210, 18);
            label1.TabIndex = 22;
            label1.Text = "Tài khoản của khách hàng:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 20;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.IconRight = global::QuanLyBanHang.Properties.Resources.icons8_search_50;
            this.txtTimKiem.IconRightSize = new System.Drawing.Size(40, 40);
            this.txtTimKiem.Location = new System.Drawing.Point(637, 13);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập thông tin cần tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(341, 41);
            this.txtTimKiem.TabIndex = 23;
            this.txtTimKiem.IconRightClick += new System.EventHandler(this.txtTimKiem_IconRightClick);
            // 
            // FrmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(label1);
            this.Controls.Add(this.taiKhoanDataGridView);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gioiTinhTextBox);
            this.Controls.Add(maKhachHangLabel);
            this.Controls.Add(this.maKhachHangTextBox);
            this.Controls.Add(tenKhachHangLabel);
            this.Controls.Add(this.tenKhachHangTextBox);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(soDienThoaiLabel);
            this.Controls.Add(this.soDienThoaiTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.ngaySinhDateTimePicker);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(this.khachHangDataGridView);
            this.Name = "FrmQuanLyKhachHang";
            this.Size = new System.Drawing.Size(1000, 535);
            this.Load += new System.EventHandler(this.FrmQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyBanHang_DataSet quanLyBanHang_DataSet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private QuanLyBanHang_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView khachHangDataGridView;
        private System.Windows.Forms.TextBox maKhachHangTextBox;
        private System.Windows.Forms.TextBox tenKhachHangTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox soDienThoaiTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox gioiTinhTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.DataGridView taiKhoanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}
