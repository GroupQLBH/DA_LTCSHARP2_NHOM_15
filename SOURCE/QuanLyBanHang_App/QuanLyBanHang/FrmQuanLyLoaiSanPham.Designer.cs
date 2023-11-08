namespace QuanLyBanHang
{
    partial class FrmQuanLyLoaiSanPham
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
            System.Windows.Forms.Label maLoaiLabel;
            System.Windows.Forms.Label tenLoaiLabel;
            this.quanLyBanHang_DataSet = new QuanLyBanHang.QuanLyBanHang_DataSet();
            this.loaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiSanPhamTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.LoaiSanPhamTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager();
            this.loaiSanPhamDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiTextBox = new System.Windows.Forms.TextBox();
            this.tenLoaiTextBox = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            maLoaiLabel = new System.Windows.Forms.Label();
            tenLoaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maLoaiLabel
            // 
            maLoaiLabel.AutoSize = true;
            maLoaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLoaiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maLoaiLabel.Location = new System.Drawing.Point(141, 133);
            maLoaiLabel.Name = "maLoaiLabel";
            maLoaiLabel.Size = new System.Drawing.Size(66, 16);
            maLoaiLabel.TabIndex = 1;
            maLoaiLabel.Text = "Mã Loại:";
            // 
            // tenLoaiLabel
            // 
            tenLoaiLabel.AutoSize = true;
            tenLoaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLoaiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            tenLoaiLabel.Location = new System.Drawing.Point(141, 161);
            tenLoaiLabel.Name = "tenLoaiLabel";
            tenLoaiLabel.Size = new System.Drawing.Size(72, 16);
            tenLoaiLabel.TabIndex = 3;
            tenLoaiLabel.Text = "Tên Loại:";
            // 
            // quanLyBanHang_DataSet
            // 
            this.quanLyBanHang_DataSet.DataSetName = "QuanLyBanHang_DataSet";
            this.quanLyBanHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiSanPhamBindingSource
            // 
            this.loaiSanPhamBindingSource.DataMember = "LoaiSanPham";
            this.loaiSanPhamBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // loaiSanPhamTableAdapter
            // 
            this.loaiSanPhamTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LoaiSanPhamTableAdapter = this.loaiSanPhamTableAdapter;
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
            // loaiSanPhamDataGridView
            // 
            this.loaiSanPhamDataGridView.AutoGenerateColumns = false;
            this.loaiSanPhamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loaiSanPhamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.loaiSanPhamDataGridView.DataSource = this.loaiSanPhamBindingSource;
            this.loaiSanPhamDataGridView.Location = new System.Drawing.Point(144, 208);
            this.loaiSanPhamDataGridView.Name = "loaiSanPhamDataGridView";
            this.loaiSanPhamDataGridView.RowHeadersWidth = 51;
            this.loaiSanPhamDataGridView.RowTemplate.Height = 24;
            this.loaiSanPhamDataGridView.Size = new System.Drawing.Size(300, 220);
            this.loaiSanPhamDataGridView.TabIndex = 1;
            this.loaiSanPhamDataGridView.SelectionChanged += new System.EventHandler(this.loaiSanPhamDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLoai";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Loại";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenLoai";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Loại";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // maLoaiTextBox
            // 
            this.maLoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiSanPhamBindingSource, "MaLoai", true));
            this.maLoaiTextBox.Location = new System.Drawing.Point(219, 130);
            this.maLoaiTextBox.Name = "maLoaiTextBox";
            this.maLoaiTextBox.Size = new System.Drawing.Size(225, 22);
            this.maLoaiTextBox.TabIndex = 2;
            // 
            // tenLoaiTextBox
            // 
            this.tenLoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiSanPhamBindingSource, "TenLoai", true));
            this.tenLoaiTextBox.Location = new System.Drawing.Point(219, 158);
            this.tenLoaiTextBox.Name = "tenLoaiTextBox";
            this.tenLoaiTextBox.Size = new System.Drawing.Size(225, 22);
            this.tenLoaiTextBox.TabIndex = 4;
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
            this.txtTimKiem.Location = new System.Drawing.Point(33, 74);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập thông tin cần tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(536, 41);
            this.txtTimKiem.TabIndex = 33;
            this.txtTimKiem.IconRightClick += new System.EventHandler(this.txtTimKiem_IconRightClick);
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
            this.btnLuu.Location = new System.Drawing.Point(450, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(143, 64);
            this.btnLuu.TabIndex = 32;
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
            this.btnSua.Location = new System.Drawing.Point(301, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(143, 64);
            this.btnSua.TabIndex = 31;
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
            this.btnXoa.Location = new System.Drawing.Point(152, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(143, 64);
            this.btnXoa.TabIndex = 30;
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
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(143, 64);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmQuanLyLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(maLoaiLabel);
            this.Controls.Add(this.maLoaiTextBox);
            this.Controls.Add(tenLoaiLabel);
            this.Controls.Add(this.tenLoaiTextBox);
            this.Controls.Add(this.loaiSanPhamDataGridView);
            this.Name = "FrmQuanLyLoaiSanPham";
            this.Size = new System.Drawing.Size(615, 447);
            this.Load += new System.EventHandler(this.FrmQuanLyLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyBanHang_DataSet quanLyBanHang_DataSet;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.LoaiSanPhamTableAdapter loaiSanPhamTableAdapter;
        private QuanLyBanHang_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView loaiSanPhamDataGridView;
        private System.Windows.Forms.TextBox maLoaiTextBox;
        private System.Windows.Forms.TextBox tenLoaiTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
    }
}
