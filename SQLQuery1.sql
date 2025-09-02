CREATE DATABASE QuanLySinhVien;
GO

USE QuanLySinhVien;
GO

-- 1. Đăng Nhập 
CREATE TABLE DangNhap (
  MaTK NVARCHAR(10) PRIMARY KEY, 
  TenTaiKhoan NVARCHAR(50),
  MatKhau NVARCHAR(50)
);

-- 2. Khoa
CREATE TABLE Khoa (
    MaKhoa NVARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(50)
);

-- 3. Lớp
CREATE TABLE Lop (
    MaLop NVARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(50),
    MaKhoa NVARCHAR(10),
    GhiChu NVARCHAR(100),
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- 4. Sinh Viên 
CREATE TABLE SinhVien (
    MaSV NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50),
    NgaySinh DATE,
    GioiTinh NVARCHAR(5),
    MaLop NVARCHAR(10),
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);

-- 5. Đia chỉ
CREATE TABLE DiaChi (
    MaDC INT PRIMARY KEY IDENTITY,
    MaSV NVARCHAR(10),
    LoaiDiaChi NVARCHAR(20), -- thường trú / tạm trú / quê quán ...
    SoNha NVARCHAR(100),
    Xa NVARCHAR(100),
    Phuong NVARCHAR(100),
    ThanhPho NVARCHAR(100),
    GhiChu NVARCHAR(100),
    FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV)
);

-- 6. GiảngViên
CREATE TABLE GiangVien (
    MaGV NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50),
    GioiTinh NVARCHAR(5),
    NgaySinh DATE,
    DiaChi NVARCHAR(100),
    MaKhoa NVARCHAR(10),
    GhiChu NVARCHAR(100),
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- 7. Môn học
CREATE TABLE MonHoc (
    MaMH NVARCHAR(10) PRIMARY KEY,
    TenMH NVARCHAR(50),
    SoTinChi INT,
    GhiChu NVARCHAR(50)
);

-- 8. Giảng dạy
CREATE TABLE GiangDay (
    MaGV NVARCHAR(10),
    MaMH NVARCHAR(10),
    MaLop NVARCHAR(10),
    HocKy INT,
    NamHoc INT,
    GhiChu NVARCHAR(50),
    PRIMARY KEY(MaGV, MaMH, MaLop, HocKy, NamHoc),
    FOREIGN KEY(MaGV) REFERENCES GiangVien(MaGV),
    FOREIGN KEY(MaMH) REFERENCES MonHoc(MaMH),
    FOREIGN KEY(MaLop) REFERENCES Lop(MaLop)
);

-- 9. Diem (quan hệ n-n SinhVien - MonHoc)
CREATE TABLE Diem (
    MaSV NVARCHAR(10),
    MaMH NVARCHAR(10),
    LanThi INT,
    Diem FLOAT,
    GhiChu NVARCHAR(50),
    PRIMARY KEY(MaSV, MaMH, LanThi),
    FOREIGN KEY(MaSV) REFERENCES SinhVien(MaSV),
    FOREIGN KEY(MaMH) REFERENCES MonHoc(MaMH)
);

--Them du lieu
INSERT INTO DangNhap
       VALUES('VanNguyen','123456@')



