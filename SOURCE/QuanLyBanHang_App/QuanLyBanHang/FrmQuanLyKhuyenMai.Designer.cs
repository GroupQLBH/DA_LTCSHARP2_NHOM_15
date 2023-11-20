namespace QuanLyBanHang
{
    partial class FrmQuanLyKhuyenMai
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
            System.Windows.Forms.Label maKhuyenMaiLabel;
            System.Windows.Forms.Label tenChuongTrinhLabel;
            System.Windows.Forms.Label ngayBatDauLabel;
            System.Windows.Forms.Label ngayKetThucLabel;
            System.Windows.Forms.Label giamGiaLabel;
            this.quanLyBanHang_DataSet = new QuanLyBanHang.QuanLyBanHang_DataSet();
            this.khuyenMaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khuyenMaiTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.KhuyenMaiTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager();
            this.khuyenMaiDataGridView = new System.Windows.Forms.DataGridView();
            this.maKhuyenMaiTextBox = new System.Windows.Forms.TextBox();
            this.tenChuongTrinhTextBox = new System.Windows.Forms.TextBox();
            this.ngayBatDauDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ngayKetThucDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.giamGiaTextBox = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maKhuyenMaiLabel = new System.Windows.Forms.Label();
            tenChuongTrinhLabel = new System.Windows.Forms.Label();
            ngayBatDauLabel = new System.Windows.Forms.Label();
            ngayKetThucLabel = new System.Windows.Forms.Label();
            giamGiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyBanHang_DataSet
            // 
            this.quanLyBanHang_DataSet.DataSetName = "QuanLyBanHang_DataSet";
            this.quanLyBanHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khuyenMaiBindingSource
            // 
            this.khuyenMaiBindingSource.DataMember = "KhuyenMai";
            this.khuyenMaiBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // khuyenMaiTableAdapter
            // 
            this.khuyenMaiTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KhuyenMaiTableAdapter = this.khuyenMaiTableAdapter;
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
            // khuyenMaiDataGridView
            // 
            this.khuyenMaiDataGridView.AutoGenerateColumns = false;
            this.khuyenMaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khuyenMaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.khuyenMaiDataGridView.DataSource = this.khuyenMaiBindingSource;
            this.khuyenMaiDataGridView.Location = new System.Drawing.Point(12, 238);
            this.khuyenMaiDataGridView.Name = "khuyenMaiDataGridView";
            this.khuyenMaiDataGridView.ReadOnly = true;
            this.khuyenMaiDataGridView.RowHeadersWidth = 51;
            this.khuyenMaiDataGridView.RowTemplate.Height = 24;
            this.khuyenMaiDataGridView.Size = new System.Drawing.Size(686, 220);
            this.khuyenMaiDataGridView.TabIndex = 1;
            this.khuyenMaiDataGridView.SelectionChanged += new System.EventHandler(this.khuyenMaiDataGridView_SelectionChanged);
            // 
            // maKhuyenMaiLabel
            // 
            maKhuyenMaiLabel.AutoSize = true;
            maKhuyenMaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhuyenMaiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maKhuyenMaiLabel.Location = new System.Drawing.Point(18, 154);
            maKhuyenMaiLabel.Name = "maKhuyenMaiLabel";
            maKhuyenMaiLabel.Size = new System.Drawing.Size(128, 18);
            maKhuyenMaiLabel.TabIndex = 1;
            maKhuyenMaiLabel.Text = "Mã Khuyến Mãi:";
            // 
            // maKhuyenMaiTextBox
            // 
            this.maKhuyenMaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khuyenMaiBindingSource, "MaKhuyenMai", true));
            this.maKhuyenMaiTextBox.Location = new System.Drawing.Point(168, 151);
            this.maKhuyenMaiTextBox.Name = "maKhuyenMaiTextBox";
            this.maKhuyenMaiTextBox.Size = new System.Drawing.Size(200, 22);
            this.maKhuyenMaiTextBox.TabIndex = 2;
            // 
            // tenChuongTrinhLabel
            // 
            tenChuongTrinhLabel.AutoSize = true;
            tenChuongTrinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenChuongTrinhLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            tenChuongTrinhLabel.Location = new System.Drawing.Point(18, 182);
            tenChuongTrinhLabel.Name = "tenChuongTrinhLabel";
            tenChuongTrinhLabel.Size = new System.Drawing.Size(147, 18);
            tenChuongTrinhLabel.TabIndex = 3;
            tenChuongTrinhLabel.Text = "Tên Chương Trình:";
            // 
            // tenChuongTrinhTextBox
            // 
            this.tenChuongTrinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khuyenMaiBindingSource, "TenChuongTrinh", true));
            this.tenChuongTrinhTextBox.Location = new System.Drawing.Point(168, 179);
            this.tenChuongTrinhTextBox.Name = "tenChuongTrinhTextBox";
            this.tenChuongTrinhTextBox.Size = new System.Drawing.Size(200, 22);
            this.tenChuongTrinhTextBox.TabIndex = 4;
            // 
            // ngayBatDauLabel
            // 
            ngayBatDauLabel.AutoSize = true;
            ngayBatDauLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayBatDauLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            ngayBatDauLabel.Location = new System.Drawing.Point(376, 153);
            ngayBatDauLabel.Name = "ngayBatDauLabel";
            ngayBatDauLabel.Size = new System.Drawing.Size(116, 18);
            ngayBatDauLabel.TabIndex = 5;
            ngayBatDauLabel.Text = "Ngày Bắt Đầu:";
            // 
            // ngayBatDauDateTimePicker
            // 
            this.ngayBatDauDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.khuyenMaiBindingSource, "NgayBatDau", true));
            this.ngayBatDauDateTimePicker.Location = new System.Drawing.Point(498, 149);
            this.ngayBatDauDateTimePicker.Name = "ngayBatDauDateTimePicker";
            this.ngayBatDauDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngayBatDauDateTimePicker.TabIndex = 6;
            // 
            // ngayKetThucLabel
            // 
            ngayKetThucLabel.AutoSize = true;
            ngayKetThucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayKetThucLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            ngayKetThucLabel.Location = new System.Drawing.Point(376, 181);
            ngayKetThucLabel.Name = "ngayKetThucLabel";
            ngayKetThucLabel.Size = new System.Drawing.Size(123, 18);
            ngayKetThucLabel.TabIndex = 7;
            ngayKetThucLabel.Text = "Ngày Kết Thúc:";
            // 
            // ngayKetThucDateTimePicker
            // 
            this.ngayKetThucDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.khuyenMaiBindingSource, "NgayKetThuc", true));
            this.ngayKetThucDateTimePicker.Location = new System.Drawing.Point(498, 177);
            this.ngayKetThucDateTimePicker.Name = "ngayKetThucDateTimePicker";
            this.ngayKetThucDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngayKetThucDateTimePicker.TabIndex = 8;
            // 
            // giamGiaLabel
            // 
            giamGiaLabel.AutoSize = true;
            giamGiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giamGiaLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            giamGiaLabel.Location = new System.Drawing.Point(376, 208);
            giamGiaLabel.Name = "giamGiaLabel";
            giamGiaLabel.Size = new System.Drawing.Size(84, 18);
            giamGiaLabel.TabIndex = 9;
            giamGiaLabel.Text = "Giảm Giá:";
            // 
            // giamGiaTextBox
            // 
            this.giamGiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khuyenMaiBindingSource, "GiamGia", true));
            this.giamGiaTextBox.Location = new System.Drawing.Point(498, 205);
            this.giamGiaTextBox.Name = "giamGiaTextBox";
            this.giamGiaTextBox.Size = new System.Drawing.Size(200, 22);
            this.giamGiaTextBox.TabIndex = 10;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKhuyenMai";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Khuyến Mãi";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenChuongTrinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Chương Trình";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayBatDau";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày Bắt Đầu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NgayKetThuc";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày Kết Thúc";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GiamGia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giảm Giá";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // FrmQuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(maKhuyenMaiLabel);
            this.Controls.Add(this.maKhuyenMaiTextBox);
            this.Controls.Add(tenChuongTrinhLabel);
            this.Controls.Add(this.tenChuongTrinhTextBox);
            this.Controls.Add(ngayBatDauLabel);
            this.Controls.Add(this.ngayBatDauDateTimePicker);
            this.Controls.Add(ngayKetThucLabel);
            this.Controls.Add(this.ngayKetThucDateTimePicker);
            this.Controls.Add(giamGiaLabel);
            this.Controls.Add(this.giamGiaTextBox);
            this.Controls.Add(this.khuyenMaiDataGridView);
            this.Name = "FrmQuanLyKhuyenMai";
            this.Size = new System.Drawing.Size(714, 470);
            this.Load += new System.EventHandler(this.FrmQuanLyKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyBanHang_DataSet quanLyBanHang_DataSet;
        private System.Windows.Forms.BindingSource khuyenMaiBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.KhuyenMaiTableAdapter khuyenMaiTableAdapter;
        private QuanLyBanHang_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView khuyenMaiDataGridView;
        private System.Windows.Forms.TextBox maKhuyenMaiTextBox;
        private System.Windows.Forms.TextBox tenChuongTrinhTextBox;
        private System.Windows.Forms.DateTimePicker ngayBatDauDateTimePicker;
        private System.Windows.Forms.DateTimePicker ngayKetThucDateTimePicker;
        private System.Windows.Forms.TextBox giamGiaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
    }
}
