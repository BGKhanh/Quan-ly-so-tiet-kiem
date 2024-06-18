-- Create nhanvien table
CREATE TABLE nhanvien (
    MaNV INT PRIMARY KEY,
    TenNV VARCHAR(100),
    SDT VARCHAR(15),
    GioiTinh VARCHAR(10),
    DiaChi VARCHAR(255),
    MatKhau VARCHAR(50)
);

-- Create khachhang table
CREATE TABLE khachhang (
    MaKH INT PRIMARY KEY,
    TenKH VARCHAR(100),
    CMND VARCHAR(12),
    GioiTinh VARCHAR(10),
    DiaChi VARCHAR(255),
    MatKhau VARCHAR(50)
);

-- Create loaikyhan table
CREATE TABLE loaiykhan (
    MaKyhan INT PRIMARY KEY,
    TenKyhan VARCHAR(100),
    LaiSuat DECIMAL(5,2),
    ThoiGianGoiToiThieu INT
);

-- Create sotietkiem table
CREATE TABLE sotietkiem (
    MaSo INT PRIMARY KEY,
    MaKH INT,
    MaKyhan INT,
    SoDu DECIMAL(18,2),
    NgayLapThe DATE,
    FOREIGN KEY (MaKH) REFERENCES khachhang(MaKH),
    FOREIGN KEY (MaKyhan) REFERENCES loaiykhan(MaKyhan)
);

-- Create phieugoitien table
CREATE TABLE phieugoitien (
    MaPGT INT PRIMARY KEY,
    MaKH INT,
    MaSo INT,
    NgayGoi DATE,
    SoTienGoi DECIMAL(18,2),
    MaNV INT,
    FOREIGN KEY (MaKH) REFERENCES khachhang(MaKH),
    FOREIGN KEY (MaSo) REFERENCES sotietkiem(MaSo),
    FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV)
);

-- Create phieuruttien table
CREATE TABLE phieuruttien (
    MaPRT INT PRIMARY KEY,
    MaKH INT,
    MaSo INT,
    NgayRut DATE,
    SoTienRut DECIMAL(18,2),
    MaNV INT,
    FOREIGN KEY (MaKH) REFERENCES khachhang(MaKH),
    FOREIGN KEY (MaSo) REFERENCES sotietkiem(MaSo),
    FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV)
);
