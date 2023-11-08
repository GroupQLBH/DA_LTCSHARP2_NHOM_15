namespace QuanLyBanHang
{
    partial class FrmQuanLySanPham
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
            System.Windows.Forms.Label maSanPhamLabel;
            System.Windows.Forms.Label tenSanPhamLabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label moTaSanPhamLabel;
            System.Windows.Forms.Label hinhAnhLabel;
            System.Windows.Forms.Label ngayCapNhatLabel;
            System.Windows.Forms.Label maKhuyenMaiLabel;
            System.Windows.Forms.Label trangThaiLabel;
            System.Windows.Forms.Label maThuongHieuLabel;
            System.Windows.Forms.Label maLoaiLabel;
            this.quanLyBanHang_DataSet = new QuanLyBanHang.QuanLyBanHang_DataSet();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.SanPhamTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager();
            this.sanPhamDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.tenSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.giaTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTextBox = new System.Windows.Forms.TextBox();
            this.moTaSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.hinhAnhTextBox = new System.Windows.Forms.TextBox();
            this.ngayCapNhatDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maKhuyenMaiTextBox = new System.Windows.Forms.TextBox();
            this.trangThaiTextBox = new System.Windows.Forms.TextBox();
            this.maThuongHieuTextBox = new System.Windows.Forms.TextBox();
            this.maLoaiTextBox = new System.Windows.Forms.TextBox();
            maSanPhamLabel = new System.Windows.Forms.Label();
            tenSanPhamLabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            moTaSanPhamLabel = new System.Windows.Forms.Label();
            hinhAnhLabel = new System.Windows.Forms.Label();
            ngayCapNhatLabel = new System.Windows.Forms.Label();
            maKhuyenMaiLabel = new System.Windows.Forms.Label();
            trangThaiLabel = new System.Windows.Forms.Label();
            maThuongHieuLabel = new System.Windows.Forms.Label();
            maLoaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyBanHang_DataSet
            // 
            this.quanLyBanHang_DataSet.DataSetName = "QuanLyBanHang_DataSet";
            this.quanLyBanHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.quanLyBanHang_DataSet;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SanPhamTableAdapter = this.sanPhamTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.ThuongHieuTableAdapter = null;
            this.tableAdapterManager.TonKhoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.QuanLyBanHang_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sanPhamDataGridView
            // 
            this.sanPhamDataGridView.AutoGenerateColumns = false;
            this.sanPhamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanPhamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.sanPhamDataGridView.DataSource = this.sanPhamBindingSource;
            this.sanPhamDataGridView.Location = new System.Drawing.Point(14, 272);
            this.sanPhamDataGridView.Name = "sanPhamDataGridView";
            this.sanPhamDataGridView.RowHeadersWidth = 51;
            this.sanPhamDataGridView.RowTemplate.Height = 24;
            this.sanPhamDataGridView.Size = new System.Drawing.Size(1426, 251);
            this.sanPhamDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSanPham";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaSanPham";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSanPham";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenSanPham";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gia";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn4.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MoTaSanPham";
            this.dataGridViewTextBoxColumn5.HeaderText = "MoTaSanPham";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HinhAnh";
            this.dataGridViewTextBoxColumn6.HeaderText = "HinhAnh";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NgayCapNhat";
            this.dataGridViewTextBoxColumn7.HeaderText = "NgayCapNhat";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MaKhuyenMai";
            this.dataGridViewTextBoxColumn8.HeaderText = "MaKhuyenMai";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TrangThai";
            this.dataGridViewTextBoxColumn9.HeaderText = "TrangThai";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MaThuongHieu";
            this.dataGridViewTextBoxColumn10.HeaderText = "MaThuongHieu";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MaLoai";
            this.dataGridViewTextBoxColumn11.HeaderText = "MaLoai";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // maSanPhamLabel
            // 
            maSanPhamLabel.AutoSize = true;
            maSanPhamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSanPhamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maSanPhamLabel.Location = new System.Drawing.Point(14, 106);
            maSanPhamLabel.Name = "maSanPhamLabel";
            maSanPhamLabel.Size = new System.Drawing.Size(106, 16);
            maSanPhamLabel.TabIndex = 1;
            maSanPhamLabel.Text = "Ma San Pham:";
            // 
            // maSanPhamTextBox
            // 
            this.maSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamBindingSource, "MaSanPham", true));
            this.maSanPhamTextBox.Location = new System.Drawing.Point(150, 103);
            this.maSanPhamTextBox.Name = "maSanPhamTextBox";
            this.maSanPhamTextBox.Size = new System.Drawing.Size(200, 22);
            this.maSanPhamTextBox.TabIndex = 2;
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.AutoSize = true;
            tenSanPhamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenSanPhamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            tenSanPhamLabel.Location = new System.Drawing.Point(14, 134);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new System.Drawing.Size(112, 16);
            tenSanPhamLabel.TabIndex = 3;
            tenSanPhamLabel.Text = "Ten San Pham:";
            // 
            // tenSanPhamTextBox
            // 
            this.tenSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamBindingSource, "TenSanPham", true));
            this.tenSanPhamTextBox.Location = new System.Drawing.Point(150, 131);
            this.tenSanPhamTextBox.Name = "tenSanPhamTextBox";
            this.tenSanPhamTextBox.Size = new System.Drawing.Size(200, 22);
            this.tenSanPhamTextBox.TabIndex = 4;
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            giaLabel.Location = new System.Drawing.Point(14, 162);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(35, 16);
            giaLabel.TabIndex = 5;
            giaLabel.Text = "Gia:";
            // 
            // giaTextBox
            // 
            this.giaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamBindingSource, "Gia", true));
            this.giaTextBox.Location = new System.Drawing.Point(150, 159);
            this.giaTextBox.Name = "giaTextBox";
            this.giaTextBox.Size = new System.Drawing.Size(200, 22);
            this.giaTextBox.TabIndex = 6;
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            soLuongLabel.Location = new System.Drawing.Point(14, 190);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(76, 16);
            soLuongLabel.TabIndex = 7;
            soLuongLabel.Text = "So Luong:";
            // 
            // soLuongTextBox
            // 
            this.soLuongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamBindingSource, "SoLuong", true));
            this.soLuongTextBox.Location = new System.Drawing.Point(150, 187);
            this.soLuongTextBox.Name = "soLuongTextBox";
            this.soLuongTextBox.Size = new System.Drawing.Size(200, 22);
            this.soLuongTextBox.TabIndex = 8;
            // 
            // moTaSanPhamLabel
            // 
            moTaSanPhamLabel.AutoSize = true;
            moTaSanPhamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            moTaSanPhamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            moTaSanPhamLabel.Location = new System.Drawing.Point(14, 218);
            moTaSanPhamLabel.Name = "moTaSanPhamLabel";
            moTaSanPhamLabel.Size = new System.Drawing.Size(129, 16);
            moTaSanPhamLabel.TabIndex = 9;
            moTaSanPhamLabel.Text = "Mo Ta San Pham:";
            // 
            // moTaSanPhamTextBox
            // 
            this.moTaSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamBindingSource, "MoTaSanPham", true));
            this.moTaSanPhamTextBox.Location = new System.Drawing.Point(150, 215);
            this.moTaSanPhamTextBox.Name = "moTaSanPhamTextBox";
            this.moTaSanPhamTextBox.Size = new System.Drawing.Size(200, 22);
            this.moTaSanPhamTextBox.TabIndex = 10;
            // 
            // hinhAnhLabel
            // 
            hinhAnhLabel.AutoSize = true;
            hinhAnhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hinhAnhLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            hinhAnhLabel.Location = new System.Drawing.Point(14, 246);
            hinhAnhLabel.Name = "hinhAnhLabel";
            hinhAnhLabel.Size = new System.Drawing.Size(72, 16);
            hinhAnhLabel.TabIndex = 11;
            hinhAnhLabel.Text = "Hinh Anh:";
            // 
            // hinhAnhTextBox
            // 
            this.hinhAnhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamBindingSource, "HinhAnh", true));
            this.hinhAnhTextBox.Location = new System.Drawing.Point(150, 243);
            this.hinhAnhTextBox.Name = "hinhAnhTextBox";
            this.hinhAnhTextBox.Size = new System.Drawing.Size(200, 22);
            this.hinhAnhTextBox.TabIndex = 12;
            // 
            // ngayCapNhatLabel
            // 
            ngayCapNhatLabel.AutoSize = true;
            ngayCapNhatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayCapNhatLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            ngayCapNhatLabel.Location = new System.Drawing.Point(375, 107);
            ngayCapNhatLabel.Name = "ngayCapNhatLabel";
            ngayCapNhatLabel.Size = new System.Drawing.Size(116, 16);
            ngayCapNhatLabel.TabIndex = 13;
            ngayCapNhatLabel.Text = "Ngay Cap Nhat:";
            // 
            // ngayCapNhatDateTimePicker
            // 
            this.ngayCapNhatDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sanPhamBindingSource, "NgayCapNhat", true));
            this.ngayCapNhatDateTimePicker.Location = new System.Drawing.Point(511, 103);
            this.ngayCapNhatDateTimePicker.Name = "ngayCapNhatDateTimePicker";
            this.ngayCapNhatDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngayCapNhatDateTimePicker.TabIndex = 14;
            // 
            // maKhuyenMaiLabel
            // 
            maKhuyenMaiLabel.AutoSize = true;
            maKhuyenMaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhuyenMaiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maKhuyenMaiLabel.Location = new System.Drawing.Point(375, 134);
            maKhuyenMaiLabel.Name = "maKhuyenMaiLabel";
            maKhuyenMaiLabel.Size = new System.Drawing.Size(115, 16);
            maKhuyenMaiLabel.TabIndex = 15;
            maKhuyenMaiLabel.Text = "Ma Khuyen Mai:";
            // 
            // maKhuyenMaiTextBox
            // 
            this.maKhuyenMaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamBindingSource, "MaKhuyenMai", true));
            this.maKhuyenMaiTextBox.Location = new System.Drawing.Point(511, 131);
            this.maKhuyenMaiTextBox.Name = "maKhuyenMaiTextBox";
            this.maKhuyenMaiTextBox.Size = new System.Drawing.Size(200, 22);
            this.maKhuyenMaiTextBox.TabIndex = 16;
            // 
            // trangThaiLabel
            // 
            trangThaiLabel.AutoSize = true;
            trangThaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trangThaiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            trangThaiLabel.Location = new System.Drawing.Point(375, 162);
            trangThaiLabel.Name = "trangThaiLabel";
            trangThaiLabel.Size = new System.Drawing.Size(87, 16);
            trangThaiLabel.TabIndex = 17;
            trangThaiLabel.Text = "Trang Thai:";
            // 
            // trangThaiTextBox
            // 
            this.trangThaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamBindingSource, "TrangThai", true));
            this.trangThaiTextBox.Location = new System.Drawing.Point(511, 159);
            this.trangThaiTextBox.Name = "trangThaiTextBox";
            this.trangThaiTextBox.Size = new System.Drawing.Size(200, 22);
            this.trangThaiTextBox.TabIndex = 18;
            // 
            // maThuongHieuLabel
            // 
            maThuongHieuLabel.AutoSize = true;
            maThuongHieuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maThuongHieuLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maThuongHieuLabel.Location = new System.Drawing.Point(375, 190);
            maThuongHieuLabel.Name = "maThuongHieuLabel";
            maThuongHieuLabel.Size = new System.Drawing.Size(124, 16);
            maThuongHieuLabel.TabIndex = 19;
            maThuongHieuLabel.Text = "Ma Thuong Hieu:";
            // 
            // maThuongHieuTextBox
            // 
            this.maThuongHieuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamBindingSource, "MaThuongHieu", true));
            this.maThuongHieuTextBox.Location = new System.Drawing.Point(511, 187);
            this.maThuongHieuTextBox.Name = "maThuongHieuTextBox";
            this.maThuongHieuTextBox.Size = new System.Drawing.Size(200, 22);
            this.maThuongHieuTextBox.TabIndex = 20;
            // 
            // maLoaiLabel
            // 
            maLoaiLabel.AutoSize = true;
            maLoaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLoaiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            maLoaiLabel.Location = new System.Drawing.Point(375, 218);
            maLoaiLabel.Name = "maLoaiLabel";
            maLoaiLabel.Size = new System.Drawing.Size(66, 16);
            maLoaiLabel.TabIndex = 21;
            maLoaiLabel.Text = "Ma Loai:";
            // 
            // maLoaiTextBox
            // 
            this.maLoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamBindingSource, "MaLoai", true));
            this.maLoaiTextBox.Location = new System.Drawing.Point(511, 215);
            this.maLoaiTextBox.Name = "maLoaiTextBox";
            this.maLoaiTextBox.Size = new System.Drawing.Size(200, 22);
            this.maLoaiTextBox.TabIndex = 22;
            // 
            // FrmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(maSanPhamLabel);
            this.Controls.Add(this.maSanPhamTextBox);
            this.Controls.Add(tenSanPhamLabel);
            this.Controls.Add(this.tenSanPhamTextBox);
            this.Controls.Add(giaLabel);
            this.Controls.Add(this.giaTextBox);
            this.Controls.Add(soLuongLabel);
            this.Controls.Add(this.soLuongTextBox);
            this.Controls.Add(moTaSanPhamLabel);
            this.Controls.Add(this.moTaSanPhamTextBox);
            this.Controls.Add(hinhAnhLabel);
            this.Controls.Add(this.hinhAnhTextBox);
            this.Controls.Add(ngayCapNhatLabel);
            this.Controls.Add(this.ngayCapNhatDateTimePicker);
            this.Controls.Add(maKhuyenMaiLabel);
            this.Controls.Add(this.maKhuyenMaiTextBox);
            this.Controls.Add(trangThaiLabel);
            this.Controls.Add(this.trangThaiTextBox);
            this.Controls.Add(maThuongHieuLabel);
            this.Controls.Add(this.maThuongHieuTextBox);
            this.Controls.Add(maLoaiLabel);
            this.Controls.Add(this.maLoaiTextBox);
            this.Controls.Add(this.sanPhamDataGridView);
            this.Name = "FrmQuanLySanPham";
            this.Size = new System.Drawing.Size(1460, 543);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyBanHang_DataSet quanLyBanHang_DataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private QuanLyBanHang_DataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private QuanLyBanHang_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sanPhamDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox maSanPhamTextBox;
        private System.Windows.Forms.TextBox tenSanPhamTextBox;
        private System.Windows.Forms.TextBox giaTextBox;
        private System.Windows.Forms.TextBox soLuongTextBox;
        private System.Windows.Forms.TextBox moTaSanPhamTextBox;
        private System.Windows.Forms.TextBox hinhAnhTextBox;
        private System.Windows.Forms.DateTimePicker ngayCapNhatDateTimePicker;
        private System.Windows.Forms.TextBox maKhuyenMaiTextBox;
        private System.Windows.Forms.TextBox trangThaiTextBox;
        private System.Windows.Forms.TextBox maThuongHieuTextBox;
        private System.Windows.Forms.TextBox maLoaiTextBox;
    }
}
