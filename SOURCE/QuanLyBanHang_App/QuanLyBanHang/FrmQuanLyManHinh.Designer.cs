namespace QuanLyBanHang
{
    partial class FrmQuanLyManHinh
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
            System.Windows.Forms.Label maManHinhLabel;
            System.Windows.Forms.Label tenManHinhLabel;
            this.quanLyBanHang_DataSet = new QuanLyBanHang.QuanLyBanHang_DataSet();
            this.dM_ManHinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_ManHinhTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.DM_ManHinhTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager();
            this.dM_ManHinhDataGridView = new System.Windows.Forms.DataGridView();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlManHinhChucNang = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemPhanQuyen = new Guna.UI2.WinForms.Guna2GradientButton();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhomNguoiDungTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.pnlPhanQuyen = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.qL_NhomNguoiDungBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.qL_PhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PhanQuyenTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.QL_PhanQuyenTableAdapter();
            this.qL_PhanQuyenDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maManHinhTextBox = new System.Windows.Forms.TextBox();
            this.tenManHinhTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            maManHinhLabel = new System.Windows.Forms.Label();
            tenManHinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhDataGridView)).BeginInit();
            this.pnlManHinhChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            this.pnlPhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyBanHang_DataSet
            // 
            this.quanLyBanHang_DataSet.DataSetName = "QuanLyBanHang_DataSet";
            this.quanLyBanHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dM_ManHinhBindingSource
            // 
            this.dM_ManHinhBindingSource.DataMember = "DM_ManHinh";
            this.dM_ManHinhBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // dM_ManHinhTableAdapter
            // 
            this.dM_ManHinhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietDonHangTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuNhapTableAdapter = null;
            this.tableAdapterManager.DM_ManHinhTableAdapter = this.dM_ManHinhTableAdapter;
            this.tableAdapterManager.DonHangTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.KhuyenMaiTableAdapter = null;
            this.tableAdapterManager.LoaiSanPhamTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhanHoiKhachHangTableAdapter = null;
            this.tableAdapterManager.PhieuNhapHangTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = this.qL_PhanQuyenTableAdapter;
            this.tableAdapterManager.SanPhamTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.ThuongHieuTableAdapter = null;
            this.tableAdapterManager.TonKhoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dM_ManHinhDataGridView
            // 
            this.dM_ManHinhDataGridView.AutoGenerateColumns = false;
            this.dM_ManHinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dM_ManHinhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dM_ManHinhDataGridView.DataSource = this.dM_ManHinhBindingSource;
            this.dM_ManHinhDataGridView.Location = new System.Drawing.Point(17, 117);
            this.dM_ManHinhDataGridView.Name = "dM_ManHinhDataGridView";
            this.dM_ManHinhDataGridView.ReadOnly = true;
            this.dM_ManHinhDataGridView.RowHeadersWidth = 51;
            this.dM_ManHinhDataGridView.RowTemplate.Height = 24;
            this.dM_ManHinhDataGridView.Size = new System.Drawing.Size(572, 154);
            this.dM_ManHinhDataGridView.TabIndex = 1;
            this.dM_ManHinhDataGridView.SelectionChanged += new System.EventHandler(this.dM_ManHinhDataGridView_SelectionChanged);
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
            this.btnLuu.Location = new System.Drawing.Point(460, 13);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(143, 64);
            this.btnLuu.TabIndex = 26;
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
            this.btnSua.Location = new System.Drawing.Point(311, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(143, 64);
            this.btnSua.TabIndex = 25;
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
            this.btnXoa.Location = new System.Drawing.Point(161, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(143, 64);
            this.btnXoa.TabIndex = 24;
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
            this.btnThem.Location = new System.Drawing.Point(3, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(143, 64);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlManHinhChucNang
            // 
            this.pnlManHinhChucNang.Controls.Add(maManHinhLabel);
            this.pnlManHinhChucNang.Controls.Add(this.maManHinhTextBox);
            this.pnlManHinhChucNang.Controls.Add(tenManHinhLabel);
            this.pnlManHinhChucNang.Controls.Add(this.tenManHinhTextBox);
            this.pnlManHinhChucNang.Controls.Add(this.dM_ManHinhDataGridView);
            this.pnlManHinhChucNang.Controls.Add(this.btnLuu);
            this.pnlManHinhChucNang.Controls.Add(this.btnSua);
            this.pnlManHinhChucNang.Controls.Add(this.btnThem);
            this.pnlManHinhChucNang.Controls.Add(this.btnXoa);
            this.pnlManHinhChucNang.FillColor2 = System.Drawing.Color.Cyan;
            this.pnlManHinhChucNang.Location = new System.Drawing.Point(3, 13);
            this.pnlManHinhChucNang.Name = "pnlManHinhChucNang";
            this.pnlManHinhChucNang.ShadowDecoration.Parent = this.pnlManHinhChucNang;
            this.pnlManHinhChucNang.Size = new System.Drawing.Size(623, 280);
            this.pnlManHinhChucNang.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Quản lý màn hình chức năng";
            // 
            // btnThemPhanQuyen
            // 
            this.btnThemPhanQuyen.BackColor = System.Drawing.Color.Transparent;
            this.btnThemPhanQuyen.CheckedState.Parent = this.btnThemPhanQuyen;
            this.btnThemPhanQuyen.CustomImages.Parent = this.btnThemPhanQuyen;
            this.btnThemPhanQuyen.FillColor = System.Drawing.Color.Transparent;
            this.btnThemPhanQuyen.FillColor2 = System.Drawing.Color.Transparent;
            this.btnThemPhanQuyen.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhanQuyen.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThemPhanQuyen.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnThemPhanQuyen.HoverState.FillColor2 = System.Drawing.Color.Aqua;
            this.btnThemPhanQuyen.HoverState.Parent = this.btnThemPhanQuyen;
            this.btnThemPhanQuyen.Image = global::QuanLyBanHang.Properties.Resources.icons8_plus_50;
            this.btnThemPhanQuyen.ImageSize = new System.Drawing.Size(50, 50);
            this.btnThemPhanQuyen.Location = new System.Drawing.Point(17, 13);
            this.btnThemPhanQuyen.Name = "btnThemPhanQuyen";
            this.btnThemPhanQuyen.ShadowDecoration.Parent = this.btnThemPhanQuyen;
            this.btnThemPhanQuyen.Size = new System.Drawing.Size(211, 64);
            this.btnThemPhanQuyen.TabIndex = 27;
            this.btnThemPhanQuyen.Text = "Thêm Phân Quyền";
            this.btnThemPhanQuyen.Click += new System.EventHandler(this.btnThemPhanQuyen_Click);
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
            // pnlPhanQuyen
            // 
            this.pnlPhanQuyen.Controls.Add(this.guna2GradientButton1);
            this.pnlPhanQuyen.Controls.Add(this.label4);
            this.pnlPhanQuyen.Controls.Add(this.label3);
            this.pnlPhanQuyen.Controls.Add(this.qL_PhanQuyenDataGridView);
            this.pnlPhanQuyen.Controls.Add(this.qL_NhomNguoiDungDataGridView);
            this.pnlPhanQuyen.Controls.Add(this.btnThemPhanQuyen);
            this.pnlPhanQuyen.FillColor2 = System.Drawing.Color.Cyan;
            this.pnlPhanQuyen.Location = new System.Drawing.Point(3, 317);
            this.pnlPhanQuyen.Name = "pnlPhanQuyen";
            this.pnlPhanQuyen.ShadowDecoration.Parent = this.pnlPhanQuyen;
            this.pnlPhanQuyen.Size = new System.Drawing.Size(818, 326);
            this.pnlPhanQuyen.TabIndex = 28;
            // 
            // qL_NhomNguoiDungBindingSource1
            // 
            this.qL_NhomNguoiDungBindingSource1.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource1.DataSource = this.quanLyBanHang_DataSet;
            // 
            // qL_NhomNguoiDungDataGridView
            // 
            this.qL_NhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.qL_NhomNguoiDungDataGridView.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungDataGridView.Location = new System.Drawing.Point(21, 94);
            this.qL_NhomNguoiDungDataGridView.Name = "qL_NhomNguoiDungDataGridView";
            this.qL_NhomNguoiDungDataGridView.ReadOnly = true;
            this.qL_NhomNguoiDungDataGridView.RowHeadersWidth = 51;
            this.qL_NhomNguoiDungDataGridView.RowTemplate.Height = 24;
            this.qL_NhomNguoiDungDataGridView.Size = new System.Drawing.Size(300, 220);
            this.qL_NhomNguoiDungDataGridView.TabIndex = 27;
            this.qL_NhomNguoiDungDataGridView.SelectionChanged += new System.EventHandler(this.qL_NhomNguoiDungDataGridView_SelectionChanged);
            // 
            // qL_PhanQuyenBindingSource
            // 
            this.qL_PhanQuyenBindingSource.DataMember = "QL_PhanQuyen";
            this.qL_PhanQuyenBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // qL_PhanQuyenTableAdapter
            // 
            this.qL_PhanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // qL_PhanQuyenDataGridView
            // 
            this.qL_PhanQuyenDataGridView.AutoGenerateColumns = false;
            this.qL_PhanQuyenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_PhanQuyenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.qL_PhanQuyenDataGridView.DataSource = this.qL_PhanQuyenBindingSource;
            this.qL_PhanQuyenDataGridView.Location = new System.Drawing.Point(351, 94);
            this.qL_PhanQuyenDataGridView.Name = "qL_PhanQuyenDataGridView";
            this.qL_PhanQuyenDataGridView.RowHeadersWidth = 51;
            this.qL_PhanQuyenDataGridView.RowTemplate.Height = 24;
            this.qL_PhanQuyenDataGridView.Size = new System.Drawing.Size(447, 220);
            this.qL_PhanQuyenDataGridView.TabIndex = 27;
            this.qL_PhanQuyenDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qL_PhanQuyenDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(3, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quản lý phân quyền";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Màn Hình";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Màn Hình";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Nhóm";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên Nhóm";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ghi Chú";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Danh sách nhóm người dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(348, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Danh sách phân quyền";
            // 
            // maManHinhLabel
            // 
            maManHinhLabel.AutoSize = true;
            maManHinhLabel.BackColor = System.Drawing.Color.Transparent;
            maManHinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maManHinhLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maManHinhLabel.Location = new System.Drawing.Point(14, 90);
            maManHinhLabel.Name = "maManHinhLabel";
            maManHinhLabel.Size = new System.Drawing.Size(112, 18);
            maManHinhLabel.TabIndex = 26;
            maManHinhLabel.Text = "Mã Màn Hình:";
            // 
            // maManHinhTextBox
            // 
            this.maManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dM_ManHinhBindingSource, "MaManHinh", true));
            this.maManHinhTextBox.Location = new System.Drawing.Point(128, 89);
            this.maManHinhTextBox.Name = "maManHinhTextBox";
            this.maManHinhTextBox.Size = new System.Drawing.Size(127, 22);
            this.maManHinhTextBox.TabIndex = 27;
            // 
            // tenManHinhLabel
            // 
            tenManHinhLabel.AutoSize = true;
            tenManHinhLabel.BackColor = System.Drawing.Color.Transparent;
            tenManHinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenManHinhLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            tenManHinhLabel.Location = new System.Drawing.Point(276, 90);
            tenManHinhLabel.Name = "tenManHinhLabel";
            tenManHinhLabel.Size = new System.Drawing.Size(117, 18);
            tenManHinhLabel.TabIndex = 28;
            tenManHinhLabel.Text = "Tên Màn Hình:";
            // 
            // tenManHinhTextBox
            // 
            this.tenManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dM_ManHinhBindingSource, "TenManHinh", true));
            this.tenManHinhTextBox.Location = new System.Drawing.Point(400, 88);
            this.tenManHinhTextBox.Name = "tenManHinhTextBox";
            this.tenManHinhTextBox.Size = new System.Drawing.Size(189, 22);
            this.tenManHinhTextBox.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã Nhóm Người Dùng";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã Màn Hình";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Có Quyền";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.Aqua;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::QuanLyBanHang.Properties.Resources.icons8_close_50;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2GradientButton1.Location = new System.Drawing.Point(234, 13);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(211, 64);
            this.guna2GradientButton1.TabIndex = 32;
            this.guna2GradientButton1.Text = "Xoá Phân Quyền";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // FrmQuanLyManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlPhanQuyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlManHinhChucNang);
            this.Name = "FrmQuanLyManHinh";
            this.Size = new System.Drawing.Size(829, 644);
            this.Load += new System.EventHandler(this.FrmQuanLyManHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhDataGridView)).EndInit();
            this.pnlManHinhChucNang.ResumeLayout(false);
            this.pnlManHinhChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            this.pnlPhanQuyen.ResumeLayout(false);
            this.pnlPhanQuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyBanHang_DataSet quanLyBanHang_DataSet;
        private System.Windows.Forms.BindingSource dM_ManHinhBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.DM_ManHinhTableAdapter dM_ManHinhTableAdapter;
        private QuanLyBanHang_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dM_ManHinhDataGridView;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlManHinhChucNang;
        private System.Windows.Forms.Label label1;
        private QuanLyBanHang_DataSetTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private Guna.UI2.WinForms.Guna2GradientButton btnThemPhanQuyen;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlPhanQuyen;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource1;
        private QuanLyBanHang_DataSetTableAdapters.QL_PhanQuyenTableAdapter qL_PhanQuyenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView qL_PhanQuyenDataGridView;
        private System.Windows.Forms.BindingSource qL_PhanQuyenBindingSource;
        private System.Windows.Forms.DataGridView qL_NhomNguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maManHinhTextBox;
        private System.Windows.Forms.TextBox tenManHinhTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}
