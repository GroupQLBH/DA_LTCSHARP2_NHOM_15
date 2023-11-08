namespace QuanLyBanHang
{
    partial class FrmQuanLyThuongHieu
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
            System.Windows.Forms.Label maThuongHieuLabel;
            System.Windows.Forms.Label tenThuongHieuLabel;
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.quanLyBanHang_DataSet = new QuanLyBanHang.QuanLyBanHang_DataSet();
            this.thuongHieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuongHieuTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.ThuongHieuTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager();
            this.thuongHieuDataGridView = new System.Windows.Forms.DataGridView();
            this.maThuongHieuTextBox = new System.Windows.Forms.TextBox();
            this.tenThuongHieuTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maThuongHieuLabel = new System.Windows.Forms.Label();
            tenThuongHieuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuongHieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuongHieuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maThuongHieuLabel
            // 
            maThuongHieuLabel.AutoSize = true;
            maThuongHieuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maThuongHieuLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maThuongHieuLabel.Location = new System.Drawing.Point(140, 131);
            maThuongHieuLabel.Name = "maThuongHieuLabel";
            maThuongHieuLabel.Size = new System.Drawing.Size(136, 18);
            maThuongHieuLabel.TabIndex = 29;
            maThuongHieuLabel.Text = "Mã Thương Hiệu:";
            // 
            // tenThuongHieuLabel
            // 
            tenThuongHieuLabel.AutoSize = true;
            tenThuongHieuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenThuongHieuLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            tenThuongHieuLabel.Location = new System.Drawing.Point(140, 159);
            tenThuongHieuLabel.Name = "tenThuongHieuLabel";
            tenThuongHieuLabel.Size = new System.Drawing.Size(141, 18);
            tenThuongHieuLabel.TabIndex = 31;
            tenThuongHieuLabel.Text = "Tên Thương Hiệu:";
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
            this.txtTimKiem.TabIndex = 28;
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
            this.btnLuu.TabIndex = 27;
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
            this.btnSua.TabIndex = 26;
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
            this.btnXoa.TabIndex = 25;
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
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // quanLyBanHang_DataSet
            // 
            this.quanLyBanHang_DataSet.DataSetName = "QuanLyBanHang_DataSet";
            this.quanLyBanHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuongHieuBindingSource
            // 
            this.thuongHieuBindingSource.DataMember = "ThuongHieu";
            this.thuongHieuBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // thuongHieuTableAdapter
            // 
            this.thuongHieuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.SanPhamTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.ThuongHieuTableAdapter = this.thuongHieuTableAdapter;
            this.tableAdapterManager.TonKhoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // thuongHieuDataGridView
            // 
            this.thuongHieuDataGridView.AutoGenerateColumns = false;
            this.thuongHieuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thuongHieuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.thuongHieuDataGridView.DataSource = this.thuongHieuBindingSource;
            this.thuongHieuDataGridView.Location = new System.Drawing.Point(137, 188);
            this.thuongHieuDataGridView.Name = "thuongHieuDataGridView";
            this.thuongHieuDataGridView.RowHeadersWidth = 51;
            this.thuongHieuDataGridView.RowTemplate.Height = 24;
            this.thuongHieuDataGridView.Size = new System.Drawing.Size(340, 220);
            this.thuongHieuDataGridView.TabIndex = 29;
            this.thuongHieuDataGridView.SelectionChanged += new System.EventHandler(this.thuongHieuDataGridView_SelectionChanged);
            // 
            // maThuongHieuTextBox
            // 
            this.maThuongHieuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuongHieuBindingSource, "MaThuongHieu", true));
            this.maThuongHieuTextBox.Location = new System.Drawing.Point(287, 130);
            this.maThuongHieuTextBox.Name = "maThuongHieuTextBox";
            this.maThuongHieuTextBox.Size = new System.Drawing.Size(167, 22);
            this.maThuongHieuTextBox.TabIndex = 30;
            // 
            // tenThuongHieuTextBox
            // 
            this.tenThuongHieuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuongHieuBindingSource, "TenThuongHieu", true));
            this.tenThuongHieuTextBox.Location = new System.Drawing.Point(287, 158);
            this.tenThuongHieuTextBox.Name = "tenThuongHieuTextBox";
            this.tenThuongHieuTextBox.Size = new System.Drawing.Size(167, 22);
            this.tenThuongHieuTextBox.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaThuongHieu";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Thương Hiệu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenThuongHieu";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Thương Hiệu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FrmQuanLyThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(maThuongHieuLabel);
            this.Controls.Add(this.maThuongHieuTextBox);
            this.Controls.Add(tenThuongHieuLabel);
            this.Controls.Add(this.tenThuongHieuTextBox);
            this.Controls.Add(this.thuongHieuDataGridView);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "FrmQuanLyThuongHieu";
            this.Size = new System.Drawing.Size(624, 431);
            this.Load += new System.EventHandler(this.FrmQuanLyThuongHieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuongHieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuongHieuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private QuanLyBanHang_DataSet quanLyBanHang_DataSet;
        private System.Windows.Forms.BindingSource thuongHieuBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.ThuongHieuTableAdapter thuongHieuTableAdapter;
        private QuanLyBanHang_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView thuongHieuDataGridView;
        private System.Windows.Forms.TextBox maThuongHieuTextBox;
        private System.Windows.Forms.TextBox tenThuongHieuTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
