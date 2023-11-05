CREATE DATABASE QuanLyBanHang;

-- Sử dụng cơ sở dữ liệu vừa tạo

USE QuanLyBanHang;

CREATE TABLE ThuongHieu
(
	MaThuongHieu nvarchar(5) PRIMARY KEY,
	TenThuongHieu nvarchar(50) unique,
)

CREATE TABLE LoaiSanPham
(
	MaLoai nvarchar(5) PRIMARY KEY,
	TenLoai nvarchar(50) unique,
)

-- Bảng nhân viên
CREATE TABLE NhanVien (
    MaNhanVien nvarchar(5) PRIMARY KEY,
    HoTen NVARCHAR(255),
    ChucVu NVARCHAR(255),
	CCCD CHAR(12),
	SoDienThoai CHAR(10),
    Luong DECIMAL(10, 2)
);
-- Bảng DM_ManHinh
CREATE TABLE DM_ManHinh (
    MaManHinh NVARCHAR(5) PRIMARY KEY,
    TenManHinh NVARCHAR(255)
);

-- Bảng QL_NguoiDung
CREATE TABLE QL_NguoiDung (
    TenDangNhap NVARCHAR(5) PRIMARY KEY,
    MatKhau NVARCHAR(255),
    HoatDong BIT
	FOREIGN KEY (TenDangNhap) REFERENCES NhanVien(MaNhanVien),
	
);

-- Bảng QL_NhomNguoiDung
CREATE TABLE QL_NhomNguoiDung (
    MaNhom NVARCHAR(5) PRIMARY KEY,
    TenNhom NVARCHAR(255),
    GhiChu NVARCHAR(255)
);

-- Bảng QL_NguoiDungNhomNguoiDung
CREATE TABLE QL_NguoiDungNhomNguoiDung (
    TenDangNhap NVARCHAR(5),
    MaNhomNguoiDung NVARCHAR(5),
    GhiChu NVARCHAR(255),
	PRIMARY KEY(TenDangNhap,MaNhomNguoiDung),
    FOREIGN KEY (TenDangNhap) REFERENCES QL_NguoiDung(TenDangNhap),
    FOREIGN KEY (MaNhomNguoiDung) REFERENCES QL_NhomNguoiDung(MaNhom)
);

-- Bảng khuyến mãi
CREATE TABLE KhuyenMai (
    MaKhuyenMai NVARCHAR(5) PRIMARY KEY,
    TenChuongTrinh NVARCHAR(255),
    NgayBatDau DATE,
    NgayKetThuc DATE,
    GiamGia DECIMAL(5, 2)
);
-- Bảng sản phẩm
CREATE TABLE SanPham (
    MaSanPham NVARCHAR(5) PRIMARY KEY,
    TenSanPham NVARCHAR(255),
    Gia DECIMAL(10, 2),
    SoLuong INT,
    MoTaSanPham NVARCHAR(MAX),
    HinhAnh NVARCHAR(255),
    NgayCapNhat DATE,
	MaKhuyenMai NVARCHAR(5),
    TrangThai NVARCHAR(50)
	FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai)
);

alter table SanPham
add MaThuongHieu nvarchar(5)

alter table SanPham
add MaLoai nvarchar(5)

alter table SanPham
add constraint fk_SP_MaThuongHieu foreign key(MaThuongHieu) references ThuongHieu(MaThuongHieu)

alter table SanPham
add constraint fk_SP_MaLoai foreign key(MaLoai) references LoaiSanPham(MaLoai)

-- Bảng khách hàng
CREATE TABLE KhachHang (
    MaKhachHang NVARCHAR(5) PRIMARY KEY,
    TenKhachHang NVARCHAR(255),
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(20),
    Email NVARCHAR(255),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10)
);

-- Bảng đơn hàng
CREATE TABLE DonHang (
    MaDonHang NVARCHAR(5) PRIMARY KEY,
    NgayDat DATE,
    TongGia DECIMAL(10, 2),
    TrangThaiDonHang NVARCHAR(50),
    MaKhachHang NVARCHAR(5),
    NgayShipHang DATE,
	MaNhanVien NVARCHAR(5),
	FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

-- Bảng chi tiết đơn hàng
CREATE TABLE ChiTietDonHang (
    MaDonHang NVARCHAR(5),
    MaSanPham NVARCHAR(5),
    SoLuong INT,
    DonGia DECIMAL(10, 2),
    ThanhTien DECIMAL(10, 2),
	PRIMARY KEY(MaDonHang,MaSanPham),
    FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);

-- Bảng QL_PhanQuyen
CREATE TABLE QL_PhanQuyen (
    MaNhomNguoiDung NVARCHAR(5),
    MaManHinh NVARCHAR(5),
    CoQuyen BIT,
	PRIMARY KEY(MaNhomNguoiDung,MaManHinh),
    FOREIGN KEY (MaNhomNguoiDung) REFERENCES QL_NhomNguoiDung(MaNhom),
    FOREIGN KEY (MaManHinh) REFERENCES DM_ManHinh(MaManHinh)
);

-- Bảng nhà cung cấp
CREATE TABLE NhaCungCap (
    MaNhaCungCap NVARCHAR(5) PRIMARY KEY,
    TenNhaCungCap NVARCHAR(255),
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(20),
    Email NVARCHAR(255)
);

-- Bảng phiếu nhập hàng
CREATE TABLE PhieuNhapHang (
    MaPhieuNhap NVARCHAR(5) PRIMARY KEY,
    NgayNhap DATE,
    MaNhaCungCap NVARCHAR(5),
	MaNhanVien NVARCHAR(5),
	FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap)
);

-- Bảng chi tiết phiếu nhập
CREATE TABLE ChiTietPhieuNhap (
    MaPhieuNhap NVARCHAR(5),
    MaSanPham NVARCHAR(5),
    SoLuongNhap INT,
    DonGiaNhap DECIMAL(10, 2),
	PRIMARY KEY(MaPhieuNhap,MaSanPham),
    FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhapHang(MaPhieuNhap),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);

-- Bảng kho
CREATE TABLE Kho (
    MaKho NVARCHAR(5) PRIMARY KEY,
    TenKho NVARCHAR(255),
	MaNhanVien NVARCHAR(5),
    DiaChiKho NVARCHAR(255)
	FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng tồn kho
CREATE TABLE TonKho (
    MaKho NVARCHAR(5),
    MaSanPham NVARCHAR(5),
    SoLuongTon INT,
	PRIMARY KEY (MaKho,MaSanPham),
    FOREIGN KEY (MaKho) REFERENCES Kho(MaKho),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);

CREATE TABLE TaiKhoan(
	MaKhachHang NVARCHAR(5) PRIMARY KEY,
	TenTaiKhoan CHAR(11) Unique,
	MatKhau CHAR(50),
	FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
)

-- Bảng phản hồi khách hàng
CREATE TABLE PhanHoiKhachHang (
    MaPhanHoi NVARCHAR(5) PRIMARY KEY,
    NoiDungPhanHoi NVARCHAR(MAX),
    DiemDanhGia INT,
    MaKhachHang NVARCHAR(5),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

INSERT INTO NhanVien (MaNhanVien, HoTen, ChucVu, CCCD, SoDienThoai, Luong)
VALUES
('NV01', N'Nguyễn Văn A', N'Quản lý', '123456789123', '0123456789', 15000000),
('NV02', N'Trần Thị B', N'Nhân viên', '987654321987', '0987654321', 10000000),
('NV03', N'Lê Văn C', N'Nhân viên', '456789123123', '0232345678', 9000000),
('NV04', N'Phạm Thị D', N'Nhân viên', '258369147123', '0909123456', 8500000),
('NV05', N'Hoàng Minh E', N'Bảo vệ', '369258147222', '0988776655', 7000000);

INSERT INTO DM_ManHinh (MaManHinh, TenManHinh)
VALUES
('MH01', N'Trang chủ'),
('MH02', N'Quản lý nhân viên'),
('MH03', N'Quản lý sản phẩm'),
('MH04', N'Quản lý khách hàng'),
('MH05', N'Quản lý đơn hàng');

INSERT INTO QL_NguoiDung (TenDangNhap, MatKhau, HoatDong)
VALUES
('NV01', '123', 1),
('NV02', '456', 1),
('NV03', '789', 0),
('NV04', '246', 1),
('NV05', '135', 1);

INSERT INTO QL_NhomNguoiDung (MaNhom, TenNhom, GhiChu)
VALUES
('NN01', N'Nhóm quản trị', NULL),
('NN02', N'Nhóm nhân viên', NULL),
('NN03', N'Nhóm kế toán', NULL);

INSERT INTO QL_NguoiDungNhomNguoiDung (TenDangNhap, MaNhomNguoiDung, GhiChu)

VALUES
('NV01', 'NN01', NULL),
('NV02', 'NN02', NULL),
('NV03', 'NN02', NULL),
('NV04', 'NN03', NULL),
('NV05', 'NN02', NULL);

INSERT INTO KhuyenMai (MaKhuyenMai, TenChuongTrinh, NgayBatDau, NgayKetThuc, GiamGia)
VALUES
('KM01', N'Chương trình giảm giá mùa hè', '2023-05-01', '2023-08-31', 0.1),
('KM02', N'Ưu đãi sinh nhật cửa hàng', '2023-12-01', '2023-12-31', 0.2),
('KM03', N'Khuyến mãi Black Friday', '2023-11-25', '2023-11-30', 0.3);

INSERT INTO SanPham (MaSanPham, TenSanPham, Gia, SoLuong, MoTaSanPham, HinhAnh, NgayCapNhat, MaKhuyenMai, TrangThai)
VALUES
('SP01', N'Điện thoại iPhone 14 Pro Max', 31990000, 10, N'Điện thoại iPhone 14 Pro Max 128GB chính hãng VN/A', 'iphone14promax.jpg', '2023-02-15', NULL, N'Còn hàng'),

('SP02', N'Điện thoại Samsung Galaxy Z Fold4', 34990000, 5, N'Điện thoại Samsung Galaxy Z Fold4 512GB chính hãng', 'samsungfold4.jpg', '2023-08-30', 'KM02', N'Còn hàng'),
('SP03', N'Laptop ASUS Zenbook Pro 15', 21990000, 8, N'Laptop ASUS Zenbook Pro 15 i7 12700H/16GB/1TB/RTX 3050', 'asuszenbook15.jpg', '2023-05-12', NULL, N'Còn hàng');

INSERT INTO KhachHang (MaKhachHang, TenKhachHang, DiaChi, SoDienThoai, Email, NgaySinh, GioiTinh)
VALUES

('KH01', N'Lê Thị Kim Ngân', N'123 Nguyễn Huệ, Q1, TP.HCM', '090xxxxxxx', 'nganle@gmail.com', '2000-03-25', N'Nữ'),
('KH02', N'Nguyễn Minh Tuấn', N'456 Lê Lợi, Q.Tân Bình, TP.HCM', '093yyyyyyy', 'tuannm@gmail.com', '1997-07-12', N'Nam'),
('KH03', N'Trần Thanh Tâm', N'789 CMT8, Q.Tân Phú, TP.HCM', '098zzzzzzz', 'tamtt@gmail.com', '1995-02-02', N'Nữ');

INSERT INTO DonHang (MaDonHang, NgayDat, TongGia, TrangThaiDonHang, MaKhachHang, NgayShipHang, MaNhanVien)
VALUES
('DH01', '2023-01-21', 31990000, N'Đã giao', 'KH01', '2023-01-23', 'NV01'),
('DH02', '2023-02-14', 34990000, N'Đang giao', 'KH02', NULL, 'NV02'),
('DH03', '2023-03-12', 21990000 * 2, N'Đã đặt', 'KH03', NULL, NULL);

INSERT INTO ChiTietDonHang (MaDonHang, MaSanPham, SoLuong, DonGia, ThanhTien)
VALUES
('DH01', 'SP01', 1, 31990000, 31990000),
('DH02', 'SP02', 1, 34990000, 34990000),
('DH03', 'SP03', 2, 21990000, 43980000);

INSERT INTO QL_PhanQuyen (MaNhomNguoiDung, MaManHinh, CoQuyen)
VALUES

('NN01', 'MH01', 1),
('NN01', 'MH02', 1),
('NN01', 'MH03', 1),
('NN01', 'MH04', 1),
('NN01', 'MH05', 1),
('NN02', 'MH01', 1),
('NN02', 'MH03', 1),
('NN02', 'MH04', 1),
('NN02', 'MH05', 1),
('NN03', 'MH01', 1),
('NN03', 'MH05', 1);

INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, DiaChi, SoDienThoai, Email)
VALUES
('NCC01', N'Công ty TNHH Thương mại Dịch vụ ABCD', N'123 Nguyễn Văn Cừ, Q.5, TP.HCM', '0288888888', 'abcd@email.com'),

('NCC02', N'Công ty Cổ phần Điện máy XYZ', N'456 Quang Trung, Q.Gò Vấp, TP.HCM', '0289999999', 'xyz@email.com'),
('NCC03', N'Công ty Cổ phần XNK Thiên Long', N'789 Lý Thường Kiệt, Q.11, TP.HCM', '0290000000', 'thienlong@email.com');

INSERT INTO PhieuNhapHang (MaPhieuNhap, NgayNhap, MaNhaCungCap, MaNhanVien)
VALUES
('PN01', '2023-01-15', 'NCC01', 'NV01'),
('PN02', '2023-02-28', 'NCC02', 'NV02'),
('PN03', '2023-03-20', 'NCC03', 'NV03');

INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaSanPham, SoLuongNhap, DonGiaNhap)
VALUES

('PN01', 'SP01', 5, 28000000),
('PN01', 'SP02', 3, 32000000),
('PN02', 'SP01', 2, 28000000),
('PN02', 'SP03', 5, 18000000),
('PN03', 'SP02', 2, 32000000),
('PN03', 'SP03', 3, 18000000);

INSERT INTO Kho (MaKho, TenKho, DiaChiKho, MaNhanVien)
VALUES
('K01', N'Kho hàng 1', N'123 Võ Văn Ngân, Q.Thủ Đức, TP.HCM', 'NV01'),
('K02', N'Kho hàng 2', N'456 Đinh Bộ Lĩnh, Bình Thạnh, TP.HCM', 'NV02');

INSERT INTO TonKho (MaKho, MaSanPham, SoLuongTon)

VALUES
('K01', 'SP01', 7),
('K01', 'SP02', 3),
('K01', 'SP03', 8),
('K02', 'SP01', 3),
('K02', 'SP02', 2),
('K02', 'SP03', 5);

INSERT INTO PhanHoiKhachHang (MaPhanHoi, NoiDungPhanHoi, DiemDanhGia, MaKhachHang)
VALUES
('PH01', N'Sản phẩm tốt, giao hàng nhanh.', 10, 'KH01'),
('PH02', N'Cửa hàng phục vụ chu đáo, tư vấn nhiệt tình', 9, 'KH02'),
('PH03', N'Giá cả phải chăng, sẽ ủng hộ tiếp.', 8, 'KH03');