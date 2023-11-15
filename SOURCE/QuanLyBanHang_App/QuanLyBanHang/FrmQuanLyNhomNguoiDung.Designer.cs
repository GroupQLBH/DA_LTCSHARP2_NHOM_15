namespace QuanLyBanHang
{
    partial class FrmQuanLyNhomNguoiDung
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
            System.Windows.Forms.Label maNhomLabel;
            System.Windows.Forms.Label tenNhomLabel;
            System.Windows.Forms.Label ghiChuLabel;
            this.quanLyBanHang_DataSet = new QuanLyBanHang.QuanLyBanHang_DataSet();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhomNguoiDungTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager();
            this.qL_NguoiDungNhomNguoiDungTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.QL_NguoiDungNhomNguoiDungTableAdapter();
            this.qL_NguoiDungTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.QL_NguoiDungTableAdapter();
            this.qL_NhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.maNhomTextBox = new System.Windows.Forms.TextBox();
            this.tenNhomTextBox = new System.Windows.Forms.TextBox();
            this.ghiChuTextBox = new System.Windows.Forms.TextBox();
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qL_NguoiDungNhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungNhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.pnlQuanLy = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlChuyenDoi = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnToLeft = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnToRight = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maNhomLabel = new System.Windows.Forms.Label();
            tenNhomLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungDataGridView)).BeginInit();
            this.pnlQuanLy.SuspendLayout();
            this.pnlChuyenDoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // maNhomLabel
            // 
            maNhomLabel.AutoSize = true;
            maNhomLabel.BackColor = System.Drawing.Color.Transparent;
            maNhomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maNhomLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maNhomLabel.Location = new System.Drawing.Point(31, 83);
            maNhomLabel.Name = "maNhomLabel";
            maNhomLabel.Size = new System.Drawing.Size(86, 18);
            maNhomLabel.TabIndex = 2;
            maNhomLabel.Text = "Mã Nhóm:";
            // 
            // tenNhomLabel
            // 
            tenNhomLabel.AutoSize = true;
            tenNhomLabel.BackColor = System.Drawing.Color.Transparent;
            tenNhomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenNhomLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            tenNhomLabel.Location = new System.Drawing.Point(247, 83);
            tenNhomLabel.Name = "tenNhomLabel";
            tenNhomLabel.Size = new System.Drawing.Size(91, 18);
            tenNhomLabel.TabIndex = 4;
            tenNhomLabel.Text = "Tên Nhóm:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.BackColor = System.Drawing.Color.Transparent;
            ghiChuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ghiChuLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            ghiChuLabel.Location = new System.Drawing.Point(465, 84);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(74, 18);
            ghiChuLabel.TabIndex = 6;
            ghiChuLabel.Text = "Ghi Chú:";
            // 
            // quanLyBanHang_DataSet
            // 
            this.quanLyBanHang_DataSet.DataSetName = "QuanLyBanHang_DataSet";
            this.quanLyBanHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhanHoiKhachHangTableAdapter = null;
            this.tableAdapterManager.PhieuNhapHangTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = this.qL_NguoiDungNhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = this.qL_NguoiDungTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.SanPhamTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.ThuongHieuTableAdapter = null;
            this.tableAdapterManager.TonKhoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NguoiDungNhomNguoiDungTableAdapter
            // 
            this.qL_NguoiDungNhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NguoiDungTableAdapter
            // 
            this.qL_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NhomNguoiDungDataGridView
            // 
            this.qL_NhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.qL_NhomNguoiDungDataGridView.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungDataGridView.Location = new System.Drawing.Point(34, 141);
            this.qL_NhomNguoiDungDataGridView.Name = "qL_NhomNguoiDungDataGridView";
            this.qL_NhomNguoiDungDataGridView.ReadOnly = true;
            this.qL_NhomNguoiDungDataGridView.RowHeadersWidth = 51;
            this.qL_NhomNguoiDungDataGridView.RowTemplate.Height = 24;
            this.qL_NhomNguoiDungDataGridView.Size = new System.Drawing.Size(628, 188);
            this.qL_NhomNguoiDungDataGridView.TabIndex = 1;
            this.qL_NhomNguoiDungDataGridView.SelectionChanged += new System.EventHandler(this.qL_NhomNguoiDungDataGridView_SelectionChanged);
            // 
            // maNhomTextBox
            // 
            this.maNhomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NhomNguoiDungBindingSource, "MaNhom", true));
            this.maNhomTextBox.Location = new System.Drawing.Point(128, 80);
            this.maNhomTextBox.Name = "maNhomTextBox";
            this.maNhomTextBox.Size = new System.Drawing.Size(100, 22);
            this.maNhomTextBox.TabIndex = 3;
            // 
            // tenNhomTextBox
            // 
            this.tenNhomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NhomNguoiDungBindingSource, "TenNhom", true));
            this.tenNhomTextBox.Location = new System.Drawing.Point(344, 80);
            this.tenNhomTextBox.Name = "tenNhomTextBox";
            this.tenNhomTextBox.Size = new System.Drawing.Size(100, 22);
            this.tenNhomTextBox.TabIndex = 5;
            // 
            // ghiChuTextBox
            // 
            this.ghiChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NhomNguoiDungBindingSource, "GhiChu", true));
            this.ghiChuTextBox.Location = new System.Drawing.Point(562, 81);
            this.ghiChuTextBox.Name = "ghiChuTextBox";
            this.ghiChuTextBox.Size = new System.Drawing.Size(100, 22);
            this.ghiChuTextBox.TabIndex = 7;
            // 
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            this.qL_NguoiDungBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // qL_NguoiDungDataGridView
            // 
            this.qL_NguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.qL_NguoiDungDataGridView.DataSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungDataGridView.Location = new System.Drawing.Point(34, 48);
            this.qL_NguoiDungDataGridView.Name = "qL_NguoiDungDataGridView";
            this.qL_NguoiDungDataGridView.ReadOnly = true;
            this.qL_NguoiDungDataGridView.RowHeadersWidth = 51;
            this.qL_NguoiDungDataGridView.RowTemplate.Height = 24;
            this.qL_NguoiDungDataGridView.Size = new System.Drawing.Size(313, 220);
            this.qL_NguoiDungDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên Đăng Nhập";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HoatDong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Hoạt Động";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // qL_NguoiDungNhomNguoiDungBindingSource
            // 
            this.qL_NguoiDungNhomNguoiDungBindingSource.DataMember = "QL_NguoiDungNhomNguoiDung";
            this.qL_NguoiDungNhomNguoiDungBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // qL_NguoiDungNhomNguoiDungDataGridView
            // 
            this.qL_NguoiDungNhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungNhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungNhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.qL_NguoiDungNhomNguoiDungDataGridView.DataSource = this.qL_NguoiDungNhomNguoiDungBindingSource;
            this.qL_NguoiDungNhomNguoiDungDataGridView.Location = new System.Drawing.Point(562, 48);
            this.qL_NguoiDungNhomNguoiDungDataGridView.Name = "qL_NguoiDungNhomNguoiDungDataGridView";
            this.qL_NguoiDungNhomNguoiDungDataGridView.ReadOnly = true;
            this.qL_NguoiDungNhomNguoiDungDataGridView.RowHeadersWidth = 51;
            this.qL_NguoiDungNhomNguoiDungDataGridView.RowTemplate.Height = 24;
            this.qL_NguoiDungNhomNguoiDungDataGridView.Size = new System.Drawing.Size(383, 220);
            this.qL_NguoiDungNhomNguoiDungDataGridView.TabIndex = 22;
            // 
            // pnlQuanLy
            // 
            this.pnlQuanLy.BorderColor = System.Drawing.Color.Cyan;
            this.pnlQuanLy.Controls.Add(this.qL_NhomNguoiDungDataGridView);
            this.pnlQuanLy.Controls.Add(this.ghiChuTextBox);
            this.pnlQuanLy.Controls.Add(ghiChuLabel);
            this.pnlQuanLy.Controls.Add(this.btnLuu);
            this.pnlQuanLy.Controls.Add(this.tenNhomTextBox);
            this.pnlQuanLy.Controls.Add(this.btnSua);
            this.pnlQuanLy.Controls.Add(tenNhomLabel);
            this.pnlQuanLy.Controls.Add(this.btnXoa);
            this.pnlQuanLy.Controls.Add(this.maNhomTextBox);
            this.pnlQuanLy.Controls.Add(this.btnThem);
            this.pnlQuanLy.Controls.Add(maNhomLabel);
            this.pnlQuanLy.FillColor = System.Drawing.Color.Transparent;
            this.pnlQuanLy.FillColor2 = System.Drawing.Color.Cyan;
            this.pnlQuanLy.Location = new System.Drawing.Point(34, 18);
            this.pnlQuanLy.Name = "pnlQuanLy";
            this.pnlQuanLy.ShadowDecoration.Parent = this.pnlQuanLy;
            this.pnlQuanLy.Size = new System.Drawing.Size(708, 337);
            this.pnlQuanLy.TabIndex = 23;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
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
            this.btnLuu.Location = new System.Drawing.Point(454, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(143, 64);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
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
            this.btnSua.Location = new System.Drawing.Point(305, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(143, 64);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
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
            this.btnXoa.Location = new System.Drawing.Point(156, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(143, 64);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
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
            this.btnThem.Location = new System.Drawing.Point(7, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(143, 64);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(31, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản lý nhóm người dùng";
            // 
            // pnlChuyenDoi
            // 
            this.pnlChuyenDoi.BorderColor = System.Drawing.Color.Cyan;
            this.pnlChuyenDoi.Controls.Add(this.btnToLeft);
            this.pnlChuyenDoi.Controls.Add(this.btnToRight);
            this.pnlChuyenDoi.Controls.Add(this.qL_NguoiDungDataGridView);
            this.pnlChuyenDoi.Controls.Add(this.qL_NguoiDungNhomNguoiDungDataGridView);
            this.pnlChuyenDoi.FillColor2 = System.Drawing.Color.Cyan;
            this.pnlChuyenDoi.Location = new System.Drawing.Point(34, 378);
            this.pnlChuyenDoi.Name = "pnlChuyenDoi";
            this.pnlChuyenDoi.ShadowDecoration.Parent = this.pnlChuyenDoi;
            this.pnlChuyenDoi.Size = new System.Drawing.Size(962, 277);
            this.pnlChuyenDoi.TabIndex = 25;
            // 
            // btnToLeft
            // 
            this.btnToLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnToLeft.CheckedState.Parent = this.btnToLeft;
            this.btnToLeft.CustomImages.Parent = this.btnToLeft;
            this.btnToLeft.FillColor = System.Drawing.Color.Transparent;
            this.btnToLeft.FillColor2 = System.Drawing.Color.Transparent;
            this.btnToLeft.Font = new System.Drawing.Font("Alfa Slab One", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLeft.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnToLeft.HoverState.FillColor = System.Drawing.Color.Aqua;
            this.btnToLeft.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnToLeft.HoverState.Parent = this.btnToLeft;
            this.btnToLeft.Image = global::QuanLyBanHang.Properties.Resources.icons8_plus_50;
            this.btnToLeft.ImageSize = new System.Drawing.Size(50, 50);
            this.btnToLeft.Location = new System.Drawing.Point(396, 165);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.ShadowDecoration.Parent = this.btnToLeft;
            this.btnToLeft.Size = new System.Drawing.Size(143, 64);
            this.btnToLeft.TabIndex = 28;
            this.btnToLeft.Text = "<<";
            this.btnToLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // btnToRight
            // 
            this.btnToRight.BackColor = System.Drawing.Color.Transparent;
            this.btnToRight.CheckedState.Parent = this.btnToRight;
            this.btnToRight.CustomImages.Parent = this.btnToRight;
            this.btnToRight.FillColor = System.Drawing.Color.Transparent;
            this.btnToRight.FillColor2 = System.Drawing.Color.Transparent;
            this.btnToRight.Font = new System.Drawing.Font("Alfa Slab One", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToRight.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnToRight.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnToRight.HoverState.FillColor2 = System.Drawing.Color.Aqua;
            this.btnToRight.HoverState.Parent = this.btnToRight;
            this.btnToRight.Image = global::QuanLyBanHang.Properties.Resources.icons8_plus_50;
            this.btnToRight.ImageSize = new System.Drawing.Size(50, 50);
            this.btnToRight.Location = new System.Drawing.Point(396, 72);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.ShadowDecoration.Parent = this.btnToRight;
            this.btnToRight.Size = new System.Drawing.Size(143, 64);
            this.btnToRight.TabIndex = 27;
            this.btnToRight.Text = ">>";
            this.btnToRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(31, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quản lý chuyển đổi nhóm người dùng";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhóm";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Nhóm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ghi Chú";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tên Đăng Nhập";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã Nhóm Người Dùng";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ghi Chú";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // FrmQuanLyNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlChuyenDoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlQuanLy);
            this.Name = "FrmQuanLyNhomNguoiDung";
            this.Size = new System.Drawing.Size(1027, 669);
            this.Load += new System.EventHandler(this.FrmQuanLyNhomNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungDataGridView)).EndInit();
            this.pnlQuanLy.ResumeLayout(false);
            this.pnlQuanLy.PerformLayout();
            this.pnlChuyenDoi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyBanHang_DataSet quanLyBanHang_DataSet;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private QuanLyBanHang_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView qL_NhomNguoiDungDataGridView;
        private System.Windows.Forms.TextBox maNhomTextBox;
        private System.Windows.Forms.TextBox tenNhomTextBox;
        private System.Windows.Forms.TextBox ghiChuTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private QuanLyBanHang_DataSetTableAdapters.QL_NguoiDungNhomNguoiDungTableAdapter qL_NguoiDungNhomNguoiDungTableAdapter;
        private QuanLyBanHang_DataSetTableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private System.Windows.Forms.DataGridView qL_NguoiDungDataGridView;
        private System.Windows.Forms.BindingSource qL_NguoiDungNhomNguoiDungBindingSource;
        private System.Windows.Forms.DataGridView qL_NguoiDungNhomNguoiDungDataGridView;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlQuanLy;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlChuyenDoi;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnToLeft;
        private Guna.UI2.WinForms.Guna2GradientButton btnToRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
