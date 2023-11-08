namespace QuanLyBanHang
{
    partial class FrmQuanLyNguoiDung
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
            System.Windows.Forms.Label maNhanVienLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label chucVuLabel;
            System.Windows.Forms.Label cCCDLabel;
            System.Windows.Forms.Label soDienThoaiLabel;
            System.Windows.Forms.Label luongLabel;
            System.Windows.Forms.Label label1;
            this.quanLyBanHang_DataSet = new QuanLyBanHang.QuanLyBanHang_DataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager();
            this.maNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.chucVuTextBox = new System.Windows.Forms.TextBox();
            this.cCCDTextBox = new System.Windows.Forms.TextBox();
            this.soDienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.luongTextBox = new System.Windows.Forms.TextBox();
            this.nhanVienDataGridView = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTaiKhoan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TaiKhoanTableAdapter();
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.QL_NguoiDungTableAdapter();
            this.qL_NguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maNhanVienLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            chucVuLabel = new System.Windows.Forms.Label();
            cCCDLabel = new System.Windows.Forms.Label();
            soDienThoaiLabel = new System.Windows.Forms.Label();
            luongLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maNhanVienLabel
            // 
            maNhanVienLabel.AutoSize = true;
            maNhanVienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maNhanVienLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maNhanVienLabel.Location = new System.Drawing.Point(25, 71);
            maNhanVienLabel.Name = "maNhanVienLabel";
            maNhanVienLabel.Size = new System.Drawing.Size(117, 18);
            maNhanVienLabel.TabIndex = 1;
            maNhanVienLabel.Text = "Mã Nhân Viên:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoTenLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            hoTenLabel.Location = new System.Drawing.Point(25, 99);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(68, 18);
            hoTenLabel.TabIndex = 3;
            hoTenLabel.Text = "Họ Tên:";
            // 
            // chucVuLabel
            // 
            chucVuLabel.AutoSize = true;
            chucVuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chucVuLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            chucVuLabel.Location = new System.Drawing.Point(25, 127);
            chucVuLabel.Name = "chucVuLabel";
            chucVuLabel.Size = new System.Drawing.Size(76, 18);
            chucVuLabel.TabIndex = 5;
            chucVuLabel.Text = "Chức Vụ:";
            // 
            // cCCDLabel
            // 
            cCCDLabel.AutoSize = true;
            cCCDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cCCDLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            cCCDLabel.Location = new System.Drawing.Point(396, 71);
            cCCDLabel.Name = "cCCDLabel";
            cCCDLabel.Size = new System.Drawing.Size(61, 18);
            cCCDLabel.TabIndex = 7;
            cCCDLabel.Text = "CCCD:";
            // 
            // soDienThoaiLabel
            // 
            soDienThoaiLabel.AutoSize = true;
            soDienThoaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soDienThoaiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            soDienThoaiLabel.Location = new System.Drawing.Point(396, 99);
            soDienThoaiLabel.Name = "soDienThoaiLabel";
            soDienThoaiLabel.Size = new System.Drawing.Size(120, 18);
            soDienThoaiLabel.TabIndex = 9;
            soDienThoaiLabel.Text = "Số Điện Thoại:";
            // 
            // luongLabel
            // 
            luongLabel.AutoSize = true;
            luongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            luongLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            luongLabel.Location = new System.Drawing.Point(396, 127);
            luongLabel.Name = "luongLabel";
            luongLabel.Size = new System.Drawing.Size(54, 18);
            luongLabel.TabIndex = 11;
            luongLabel.Text = "Lương";
            // 
            // quanLyBanHang_DataSet
            // 
            this.quanLyBanHang_DataSet.DataSetName = "QuanLyBanHang_DataSet";
            this.quanLyBanHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietDonHangTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuNhapTableAdapter = null;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.DonHangTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.KhuyenMaiTableAdapter = null;
            this.tableAdapterManager.LoaiSanPhamTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
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
            // maNhanVienTextBox
            // 
            this.maNhanVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNhanVien", true));
            this.maNhanVienTextBox.Location = new System.Drawing.Point(151, 70);
            this.maNhanVienTextBox.Name = "maNhanVienTextBox";
            this.maNhanVienTextBox.Size = new System.Drawing.Size(218, 22);
            this.maNhanVienTextBox.TabIndex = 2;
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "HoTen", true));
            this.hoTenTextBox.Location = new System.Drawing.Point(151, 98);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(218, 22);
            this.hoTenTextBox.TabIndex = 4;
            // 
            // chucVuTextBox
            // 
            this.chucVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "ChucVu", true));
            this.chucVuTextBox.Location = new System.Drawing.Point(151, 126);
            this.chucVuTextBox.Name = "chucVuTextBox";
            this.chucVuTextBox.Size = new System.Drawing.Size(218, 22);
            this.chucVuTextBox.TabIndex = 6;
            // 
            // cCCDTextBox
            // 
            this.cCCDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "CCCD", true));
            this.cCCDTextBox.Location = new System.Drawing.Point(522, 70);
            this.cCCDTextBox.Name = "cCCDTextBox";
            this.cCCDTextBox.Size = new System.Drawing.Size(310, 22);
            this.cCCDTextBox.TabIndex = 8;
            // 
            // soDienThoaiTextBox
            // 
            this.soDienThoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "SoDienThoai", true));
            this.soDienThoaiTextBox.Location = new System.Drawing.Point(522, 98);
            this.soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            this.soDienThoaiTextBox.Size = new System.Drawing.Size(310, 22);
            this.soDienThoaiTextBox.TabIndex = 10;
            // 
            // luongTextBox
            // 
            this.luongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "Luong", true));
            this.luongTextBox.Location = new System.Drawing.Point(522, 126);
            this.luongTextBox.Name = "luongTextBox";
            this.luongTextBox.Size = new System.Drawing.Size(310, 22);
            this.luongTextBox.TabIndex = 12;
            this.luongTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.luongTextBox_KeyPress);
            // 
            // nhanVienDataGridView
            // 
            this.nhanVienDataGridView.AllowDrop = true;
            this.nhanVienDataGridView.AllowUserToOrderColumns = true;
            this.nhanVienDataGridView.AutoGenerateColumns = false;
            this.nhanVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.nhanVienDataGridView.DataSource = this.nhanVienBindingSource;
            this.nhanVienDataGridView.Location = new System.Drawing.Point(26, 162);
            this.nhanVienDataGridView.MultiSelect = false;
            this.nhanVienDataGridView.Name = "nhanVienDataGridView";
            this.nhanVienDataGridView.ReadOnly = true;
            this.nhanVienDataGridView.RowHeadersWidth = 51;
            this.nhanVienDataGridView.RowTemplate.Height = 24;
            this.nhanVienDataGridView.Size = new System.Drawing.Size(806, 220);
            this.nhanVienDataGridView.TabIndex = 13;
            this.nhanVienDataGridView.SelectionChanged += new System.EventHandler(this.nhanVienDataGridView_SelectionChanged);
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
            this.txtTimKiem.Location = new System.Drawing.Point(28, 487);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập thông tin cần tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(806, 36);
            this.txtTimKiem.TabIndex = 19;
            this.txtTimKiem.IconRightClick += new System.EventHandler(this.txtTimKiem_IconRightClick);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.CheckedState.Parent = this.btnTaiKhoan;
            this.btnTaiKhoan.CustomImages.Parent = this.btnTaiKhoan;
            this.btnTaiKhoan.FillColor = System.Drawing.Color.Transparent;
            this.btnTaiKhoan.FillColor2 = System.Drawing.Color.Transparent;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnTaiKhoan.HoverState.FillColor2 = System.Drawing.Color.Aqua;
            this.btnTaiKhoan.HoverState.Parent = this.btnTaiKhoan;
            this.btnTaiKhoan.Image = global::QuanLyBanHang.Properties.Resources.icons8_user_default_50;
            this.btnTaiKhoan.ImageSize = new System.Drawing.Size(50, 50);
            this.btnTaiKhoan.Location = new System.Drawing.Point(596, 0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.ShadowDecoration.Parent = this.btnTaiKhoan;
            this.btnTaiKhoan.Size = new System.Drawing.Size(236, 64);
            this.btnTaiKhoan.TabIndex = 18;
            this.btnTaiKhoan.Text = "Thêm Tài Khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(447, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(143, 64);
            this.btnLuu.TabIndex = 17;
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
            this.btnSua.Location = new System.Drawing.Point(298, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(143, 64);
            this.btnSua.TabIndex = 16;
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
            this.btnXoa.Location = new System.Drawing.Point(149, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(143, 64);
            this.btnXoa.TabIndex = 15;
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
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(143, 64);
            this.btnThem.TabIndex = 14;
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
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            this.qL_NguoiDungBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // qL_NguoiDungTableAdapter
            // 
            this.qL_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NguoiDungDataGridView
            // 
            this.qL_NguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.qL_NguoiDungDataGridView.DataSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungDataGridView.Location = new System.Drawing.Point(28, 406);
            this.qL_NguoiDungDataGridView.Name = "qL_NguoiDungDataGridView";
            this.qL_NguoiDungDataGridView.ReadOnly = true;
            this.qL_NguoiDungDataGridView.RowHeadersWidth = 51;
            this.qL_NguoiDungDataGridView.RowTemplate.Height = 24;
            this.qL_NguoiDungDataGridView.Size = new System.Drawing.Size(308, 76);
            this.qL_NguoiDungDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn7.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HoatDong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "HoatDong";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.DodgerBlue;
            label1.Location = new System.Drawing.Point(23, 385);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(195, 18);
            label1.TabIndex = 20;
            label1.Text = "Tài khoản của nhân viên:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhanVien";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ Tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ChucVu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Chức Vụ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CCCD";
            this.dataGridViewTextBoxColumn4.HeaderText = "CCCD";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SoDienThoai";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số Điện Thoại";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Luong";
            this.dataGridViewTextBoxColumn6.HeaderText = "Lương";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(label1);
            this.Controls.Add(this.qL_NguoiDungDataGridView);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTaiKhoan);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.nhanVienDataGridView);
            this.Controls.Add(maNhanVienLabel);
            this.Controls.Add(this.maNhanVienTextBox);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.hoTenTextBox);
            this.Controls.Add(chucVuLabel);
            this.Controls.Add(this.chucVuTextBox);
            this.Controls.Add(cCCDLabel);
            this.Controls.Add(this.cCCDTextBox);
            this.Controls.Add(soDienThoaiLabel);
            this.Controls.Add(this.soDienThoaiTextBox);
            this.Controls.Add(luongLabel);
            this.Controls.Add(this.luongTextBox);
            this.Name = "FrmQuanLyNguoiDung";
            this.Size = new System.Drawing.Size(854, 657);
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyBanHang_DataSet quanLyBanHang_DataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QuanLyBanHang_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maNhanVienTextBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.TextBox chucVuTextBox;
        private System.Windows.Forms.TextBox cCCDTextBox;
        private System.Windows.Forms.TextBox soDienThoaiTextBox;
        private System.Windows.Forms.TextBox luongTextBox;
        private System.Windows.Forms.DataGridView nhanVienDataGridView;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter;
        private System.Windows.Forms.DataGridView qL_NguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
