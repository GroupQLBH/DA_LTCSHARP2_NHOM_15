namespace QuanLyBanHang
{
    partial class FrmNhapHang
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
            System.Windows.Forms.Label maKhoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHang_DataSet = new QuanLyBanHang.QuanLyBanHang_DataSet();
            this.sanPhamTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.SanPhamTableAdapter();
            this.cboNhaCungCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.NhaCungCapTableAdapter();
            this.cboKho = new Guna.UI2.WinForms.Guna2ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.KhoTableAdapter();
            this.btnTaoPhieu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chiTietPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietPhieuNhapTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.ChiTietPhieuNhapTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager();
            this.dataGChiTietNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maPhieuNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietPhieuNhapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnHuy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMaPhieuNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDonGiaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            maKhoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGChiTietNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuNhapBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // maKhoLabel
            // 
            maKhoLabel.AutoSize = true;
            maKhoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhoLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maKhoLabel.Location = new System.Drawing.Point(3, 78);
            maKhoLabel.Name = "maKhoLabel";
            maKhoLabel.Size = new System.Drawing.Size(228, 18);
            maKhoLabel.TabIndex = 35;
            maKhoLabel.Text = "Chọn thông tin nhà cung cấp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.DodgerBlue;
            label1.Location = new System.Drawing.Point(3, 168);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(330, 18);
            label1.TabIndex = 36;
            label1.Text = "Chọn thông tin sản phẩm và kho cần thêm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.DodgerBlue;
            label2.Location = new System.Drawing.Point(3, 240);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(442, 18);
            label2.TabIndex = 40;
            label2.Text = "Double click vào dach sách bên dưới để xóa một chi tiết sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.DodgerBlue;
            label3.Location = new System.Drawing.Point(448, 168);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 18);
            label3.TabIndex = 43;
            label3.Text = "Đơn giá nhập:";
            // 
            // cboSanPham
            // 
            this.cboSanPham.BackColor = System.Drawing.Color.Transparent;
            this.cboSanPham.BorderRadius = 20;
            this.cboSanPham.DataSource = this.sanPhamBindingSource;
            this.cboSanPham.DisplayMember = "TenSanPham";
            this.cboSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.FocusedColor = System.Drawing.Color.Empty;
            this.cboSanPham.FocusedState.Parent = this.cboSanPham;
            this.cboSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.HoverState.Parent = this.cboSanPham;
            this.cboSanPham.ItemHeight = 30;
            this.cboSanPham.ItemsAppearance.Parent = this.cboSanPham;
            this.cboSanPham.Location = new System.Drawing.Point(3, 189);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.ShadowDecoration.Parent = this.cboSanPham;
            this.cboSanPham.Size = new System.Drawing.Size(215, 36);
            this.cboSanPham.TabIndex = 0;
            this.cboSanPham.ValueMember = "MaSanPham";
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // quanLyBanHang_DataSet
            // 
            this.quanLyBanHang_DataSet.DataSetName = "QuanLyBanHang_DataSet";
            this.quanLyBanHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.cboNhaCungCap.BorderRadius = 20;
            this.cboNhaCungCap.DataSource = this.nhaCungCapBindingSource;
            this.cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            this.cboNhaCungCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.FocusedColor = System.Drawing.Color.Empty;
            this.cboNhaCungCap.FocusedState.Parent = this.cboNhaCungCap;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.HoverState.Parent = this.cboNhaCungCap;
            this.cboNhaCungCap.ItemHeight = 30;
            this.cboNhaCungCap.ItemsAppearance.Parent = this.cboNhaCungCap;
            this.cboNhaCungCap.Location = new System.Drawing.Point(3, 101);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.ShadowDecoration.Parent = this.cboNhaCungCap;
            this.cboNhaCungCap.Size = new System.Drawing.Size(215, 36);
            this.cboNhaCungCap.TabIndex = 1;
            this.cboNhaCungCap.ValueMember = "MaNhaCungCap";
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // cboKho
            // 
            this.cboKho.BackColor = System.Drawing.Color.Transparent;
            this.cboKho.BorderRadius = 20;
            this.cboKho.DataSource = this.khoBindingSource;
            this.cboKho.DisplayMember = "TenKho";
            this.cboKho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FocusedColor = System.Drawing.Color.Empty;
            this.cboKho.FocusedState.Parent = this.cboKho;
            this.cboKho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKho.FormattingEnabled = true;
            this.cboKho.HoverState.Parent = this.cboKho;
            this.cboKho.ItemHeight = 30;
            this.cboKho.ItemsAppearance.Parent = this.cboKho;
            this.cboKho.Location = new System.Drawing.Point(224, 189);
            this.cboKho.Name = "cboKho";
            this.cboKho.ShadowDecoration.Parent = this.cboKho;
            this.cboKho.Size = new System.Drawing.Size(215, 36);
            this.cboKho.TabIndex = 2;
            this.cboKho.ValueMember = "MaKho";
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.CheckedState.Parent = this.btnTaoPhieu;
            this.btnTaoPhieu.CustomImages.Parent = this.btnTaoPhieu;
            this.btnTaoPhieu.FillColor = System.Drawing.Color.Transparent;
            this.btnTaoPhieu.FillColor2 = System.Drawing.Color.Transparent;
            this.btnTaoPhieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnTaoPhieu.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnTaoPhieu.HoverState.FillColor2 = System.Drawing.Color.Aqua;
            this.btnTaoPhieu.HoverState.Parent = this.btnTaoPhieu;
            this.btnTaoPhieu.Image = global::QuanLyBanHang.Properties.Resources.icons8_plus_50;
            this.btnTaoPhieu.ImageSize = new System.Drawing.Size(50, 50);
            this.btnTaoPhieu.Location = new System.Drawing.Point(0, 0);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.ShadowDecoration.Parent = this.btnTaoPhieu;
            this.btnTaoPhieu.Size = new System.Drawing.Size(198, 64);
            this.btnTaoPhieu.TabIndex = 30;
            this.btnTaoPhieu.Text = "Tạo phiếu nhập";
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(221, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(143, 64);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnThem.Location = new System.Drawing.Point(637, 175);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(133, 64);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // chiTietPhieuNhapBindingSource
            // 
            this.chiTietPhieuNhapBindingSource.DataMember = "ChiTietPhieuNhap";
            this.chiTietPhieuNhapBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // chiTietPhieuNhapTableAdapter
            // 
            this.chiTietPhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietDonHangTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuNhapTableAdapter = this.chiTietPhieuNhapTableAdapter;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.DonHangTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.KhuyenMaiTableAdapter = null;
            this.tableAdapterManager.LoaiSanPhamTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = this.nhaCungCapTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhanHoiKhachHangTableAdapter = null;
            this.tableAdapterManager.PhieuNhapHangTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.SanPhamTableAdapter = this.sanPhamTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.ThuongHieuTableAdapter = null;
            this.tableAdapterManager.TonKhoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGChiTietNhap
            // 
            this.dataGChiTietNhap.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGChiTietNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGChiTietNhap.AutoGenerateColumns = false;
            this.dataGChiTietNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGChiTietNhap.BackgroundColor = System.Drawing.Color.White;
            this.dataGChiTietNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGChiTietNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGChiTietNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGChiTietNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGChiTietNhap.ColumnHeadersHeight = 27;
            this.dataGChiTietNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuNhapDataGridViewTextBoxColumn,
            this.maSanPhamDataGridViewTextBoxColumn,
            this.soLuongNhapDataGridViewTextBoxColumn,
            this.donGiaNhapDataGridViewTextBoxColumn,
            this.maKhoDataGridViewTextBoxColumn});
            this.dataGChiTietNhap.DataSource = this.chiTietPhieuNhapBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGChiTietNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGChiTietNhap.EnableHeadersVisualStyles = false;
            this.dataGChiTietNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGChiTietNhap.Location = new System.Drawing.Point(6, 261);
            this.dataGChiTietNhap.Name = "dataGChiTietNhap";
            this.dataGChiTietNhap.RowHeadersVisible = false;
            this.dataGChiTietNhap.RowHeadersWidth = 51;
            this.dataGChiTietNhap.RowTemplate.Height = 24;
            this.dataGChiTietNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGChiTietNhap.Size = new System.Drawing.Size(764, 247);
            this.dataGChiTietNhap.TabIndex = 37;
            this.dataGChiTietNhap.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGChiTietNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGChiTietNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGChiTietNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGChiTietNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGChiTietNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGChiTietNhap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGChiTietNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGChiTietNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGChiTietNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGChiTietNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGChiTietNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGChiTietNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGChiTietNhap.ThemeStyle.HeaderStyle.Height = 27;
            this.dataGChiTietNhap.ThemeStyle.ReadOnly = false;
            this.dataGChiTietNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGChiTietNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGChiTietNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGChiTietNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGChiTietNhap.ThemeStyle.RowsStyle.Height = 24;
            this.dataGChiTietNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGChiTietNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGChiTietNhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGChiTietNhap_CellDoubleClick);
            this.dataGChiTietNhap.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGChiTietNhap_CellEndEdit);
            // 
            // maPhieuNhapDataGridViewTextBoxColumn
            // 
            this.maPhieuNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maPhieuNhapDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuNhap";
            this.maPhieuNhapDataGridViewTextBoxColumn.Frozen = true;
            this.maPhieuNhapDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu Nhập";
            this.maPhieuNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhieuNhapDataGridViewTextBoxColumn.Name = "maPhieuNhapDataGridViewTextBoxColumn";
            this.maPhieuNhapDataGridViewTextBoxColumn.ReadOnly = true;
            this.maPhieuNhapDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.maPhieuNhapDataGridViewTextBoxColumn.Width = 148;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            this.maSanPhamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            this.maSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.maSanPhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            this.maSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSanPhamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.maSanPhamDataGridViewTextBoxColumn.Width = 148;
            // 
            // soLuongNhapDataGridViewTextBoxColumn
            // 
            this.soLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNhap";
            this.soLuongNhapDataGridViewTextBoxColumn.HeaderText = "Số Lượng Nhập";
            this.soLuongNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongNhapDataGridViewTextBoxColumn.Name = "soLuongNhapDataGridViewTextBoxColumn";
            this.soLuongNhapDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // donGiaNhapDataGridViewTextBoxColumn
            // 
            this.donGiaNhapDataGridViewTextBoxColumn.DataPropertyName = "DonGiaNhap";
            this.donGiaNhapDataGridViewTextBoxColumn.HeaderText = "Đơn Giá Nhập";
            this.donGiaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaNhapDataGridViewTextBoxColumn.Name = "donGiaNhapDataGridViewTextBoxColumn";
            this.donGiaNhapDataGridViewTextBoxColumn.ReadOnly = true;
            this.donGiaNhapDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // maKhoDataGridViewTextBoxColumn
            // 
            this.maKhoDataGridViewTextBoxColumn.DataPropertyName = "MaKho";
            this.maKhoDataGridViewTextBoxColumn.HeaderText = "Mã Kho";
            this.maKhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhoDataGridViewTextBoxColumn.Name = "maKhoDataGridViewTextBoxColumn";
            this.maKhoDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKhoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chiTietPhieuNhapBindingSource1
            // 
            this.chiTietPhieuNhapBindingSource1.DataMember = "ChiTietPhieuNhap";
            this.chiTietPhieuNhapBindingSource1.DataSource = this.quanLyBanHang_DataSet;
            // 
            // btnHuy
            // 
            this.btnHuy.CheckedState.Parent = this.btnHuy;
            this.btnHuy.CustomImages.Parent = this.btnHuy;
            this.btnHuy.FillColor = System.Drawing.Color.Transparent;
            this.btnHuy.FillColor2 = System.Drawing.Color.Transparent;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnHuy.HoverState.FillColor2 = System.Drawing.Color.Aqua;
            this.btnHuy.HoverState.Parent = this.btnHuy;
            this.btnHuy.Image = global::QuanLyBanHang.Properties.Resources.icons8_close_50;
            this.btnHuy.ImageSize = new System.Drawing.Size(50, 50);
            this.btnHuy.Location = new System.Drawing.Point(385, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ShadowDecoration.Parent = this.btnHuy;
            this.btnHuy.Size = new System.Drawing.Size(143, 64);
            this.btnHuy.TabIndex = 39;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.BorderRadius = 20;
            this.txtMaPhieuNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieuNhap.DefaultText = "";
            this.txtMaPhieuNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhieuNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhieuNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieuNhap.DisabledState.Parent = this.txtMaPhieuNhap;
            this.txtMaPhieuNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieuNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieuNhap.FocusedState.Parent = this.txtMaPhieuNhap;
            this.txtMaPhieuNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieuNhap.HoverState.Parent = this.txtMaPhieuNhap;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(225, 101);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.PasswordChar = '\0';
            this.txtMaPhieuNhap.PlaceholderText = "";
            this.txtMaPhieuNhap.SelectedText = "";
            this.txtMaPhieuNhap.ShadowDecoration.Parent = this.txtMaPhieuNhap;
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(214, 36);
            this.txtMaPhieuNhap.TabIndex = 41;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.BorderRadius = 20;
            this.txtDonGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGiaNhap.DefaultText = "";
            this.txtDonGiaNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGiaNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGiaNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGiaNhap.DisabledState.Parent = this.txtDonGiaNhap;
            this.txtDonGiaNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGiaNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGiaNhap.FocusedState.Parent = this.txtDonGiaNhap;
            this.txtDonGiaNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGiaNhap.HoverState.Parent = this.txtDonGiaNhap;
            this.txtDonGiaNhap.Location = new System.Drawing.Point(446, 189);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.PasswordChar = '\0';
            this.txtDonGiaNhap.PlaceholderText = "";
            this.txtDonGiaNhap.SelectedText = "";
            this.txtDonGiaNhap.ShadowDecoration.Parent = this.txtDonGiaNhap;
            this.txtDonGiaNhap.Size = new System.Drawing.Size(184, 36);
            this.txtDonGiaNhap.TabIndex = 42;
            this.txtDonGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaNhap_KeyPress);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblThanhTien.Location = new System.Drawing.Point(446, 525);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(91, 18);
            this.lblThanhTien.TabIndex = 44;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // FrmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtMaPhieuNhap);
            this.Controls.Add(label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dataGChiTietNhap);
            this.Controls.Add(label1);
            this.Controls.Add(maKhoLabel);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaoPhieu);
            this.Controls.Add(this.cboKho);
            this.Controls.Add(this.cboNhaCungCap);
            this.Controls.Add(this.cboSanPham);
            this.Name = "FrmNhapHang";
            this.Size = new System.Drawing.Size(773, 603);
            this.Load += new System.EventHandler(this.FrmNhapHang_Load);
            this.Leave += new System.EventHandler(this.FrmNhapHang_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGChiTietNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuNhapBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cboSanPham;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private QuanLyBanHang_DataSet quanLyBanHang_DataSet;
        private QuanLyBanHang_DataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhaCungCap;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox cboKho;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private Guna.UI2.WinForms.Guna2GradientButton btnTaoPhieu;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private System.Windows.Forms.BindingSource chiTietPhieuNhapBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.ChiTietPhieuNhapTableAdapter chiTietPhieuNhapTableAdapter;
        private QuanLyBanHang_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2DataGridView dataGChiTietNhap;
        private System.Windows.Forms.BindingSource chiTietPhieuNhapBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2GradientButton btnHuy;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhieuNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label lblThanhTien;
    }
}
