CREATE DATABASE QuanLySinhVien;
GO

USE QuanLySinhVien;
GO

-- 1. Đăng Nhập 
CREATE TABLE DangNhap (
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
    GhiChu NVARCHAR(50)
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- 4. Sinh Viên 
CREATE TABLE SinhVien (
    MaSV NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50),
    NgaySinh DATE,
    GioiTinh NVARCHAR(5),
    DiaChi NVARCHAR(100),
    TenTonGiao NVARCHAR(50),
    MaLop NVARCHAR(10),
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);

-- 5. Đia chỉ
CREATE TABLE DiaChi (
    MaSV NVARCHAR(10) UNIQUE,
    MaTinh INT PRIMARY KEY,
    SoNha NVARCHAR(150),
    Xa NVARCHAR(50),
    Tinh NVARCHAR(50),
    GhiChu NVARCHAR(50)
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
    GhiChu NVARCHAR(50)
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- 7. Môn học
CREATE TABLE MonHoc (
    MaMH NVARCHAR(10) PRIMARY KEY,
    TenMH NVARCHAR(50),
    GhiChu NVARCHAR(50),
    SoTinChi INT
);

-- 8. Giang day: trung gian giua GiangVien - MonHoc (quan hệ n-n)
CREATE TABLE GiangDay (
    MaGV NVARCHAR(10),
    MaMH NVARCHAR(10),
    GhiChu NVARCHAR(50),
    PRIMARY KEY(MaGV, MaMH),
    FOREIGN KEY(MaGV) REFERENCES GiangVien(MaGV),
    FOREIGN KEY(MaMH) REFERENCES MonHoc(MaMH)
);

-- 9. Diem (quan hệ n-n SinhVien - MonHoc)
CREATE TABLE Diem (
    MaSV NVARCHAR(10),
    MaMH NVARCHAR(10),
    Diem FLOAT,
    GhiChu NVARCHAR(50),
    PRIMARY KEY(MaSV, MaMH),
    FOREIGN KEY(MaSV) REFERENCES SinhVien(MaSV),
    FOREIGN KEY(MaMH) REFERENCES MonHoc(MaMH)
);

--Them du lieu
INSERT INTO DangNhap
       VALUES('VanNguyen','123456@')

