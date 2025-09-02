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
	DanToc NVARCHAR(20),
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
-- 1. Đăng nhập
INSERT INTO DangNhap 
			VALUES('VanNguyen','123456@');
INSERT INTO DangNhap 
			VALUES('AnhNgoc','78910@');
INSERT INTO DangNhap 
			VALUES('ThanhTien','11111@');

-- 2. Khoa
INSERT INTO Khoa 
			VALUES('CNTT', N'Cong nghe thong tin');
INSERT INTO Khoa 
			VALUES('CK', N'Co khi');
INSERT INTO Khoa	
			VALUES('KT', N'Kinh te');

-- 3. Lop
INSERT INTO Lop 
			VALUES('LTMT1', N'Lap trinh may tinh 1', 'CNTT', N'Lop ly thuyet');
INSERT INTO Lop 
			VALUES('CK1', N'Co khi 1', 'CK', N'Lop thuc hanh');

INSERT INTO Lop 
			VALUES('KT1', N'Ke Toan 1', 'KT', N'Lop ly thuyet');

-- 4. Sinh vien
INSERT INTO SinhVien 
			VALUES('SV01', N'Nguyen Tien Tai Van', '2005-05-12', N'Nam', N'Kinh', N'Khong', 'LTMT1');
INSERT INTO SinhVien 
			VALUES('SV02', N'Nguyen Anh Ngoc', '2005-08-12', N'Nu', N'Kinh', N'Khong', 'LTMT2');
INSERT INTO SinhVien 
			VALUES('SV03', N'Nguyen Thanh Tien', '2005-07-1717', N'Nam', N'Nghe An', N'HMong', 'CK1');

-- 5. Dia chi
INSERT INTO DiaChi 
			VALUES(101,'SV01','Thuong tru', N'16 Hoang Mai', N'Thanh Xuan', N'Ha Noi', N'Gan truong');
INSERT INTO DiaChi 
			VALUES(102,'SV02','Tam tru', N'12 Hai Trung', N'Hai Hau', N'Nam Dinh', N'Gan truong');
INSERT INTO DiaChi 
			VALUES(103,'SV03','Que quan', N'78 Tran Phu', N'Vinh', N'Nghe An', N'Que nha');

-- 6. Giang vien
INSERT INTO GiangVien 
			VALUES('GV01', N'Nguyen Thi Lan', N'Nu', '1980-03-22', N'Ha Noi', 'CNTT', N'Truong khoa');
INSERT INTO GiangVien 
			VALUES('GV02', N'Pham Van Hung', N'Nam', '1975-09-11', N'Hai Duong', 'CK', N'Pho khoa');
INSERT INTO GiangVien 
			VALUES('GV03', N'Le Thi Mai', N'Nu', '1983-01-05', N'Hai Phong', 'KT', N'GV Chu Nhiem');

-- 7. Mon hoc
INSERT INTO MonHoc 
			VALUES('MH01', N'Co so du lieu', N'Mon chuyen nganh CNTT', 3);
INSERT INTO MonHoc 
			VALUES('MH02', N'Ky thuat kap rap', N'Mon chuyen nganh', 4);
INSERT INTO MonHoc 
			VALUES('MH03', N'Ke toan doanh nghiep', N'Mon chuyen nganh', 3);

-- 8. Giang day
INSERT INTO GiangDay 
			VALUES('GV01','MH01',N'Giang day chinh');
INSERT INTO GiangDay 
			VALUES('GV02','MH02',N'Giang day');
INSERT INTO GiangDay 
			VALUES('GV03','MH03',N'Giang day');

-- 9. Diem
INSERT INTO Diem 
			VALUES('SV01','MH01', '1',8.5,N'Kha');
INSERT INTO Diem 
			VALUES('SV02','MH01','1',9.0,N'Gioi');
INSERT INTO Diem 
			VALUES('SV03','MH03','2',6.5,N'Trung binh'); 




