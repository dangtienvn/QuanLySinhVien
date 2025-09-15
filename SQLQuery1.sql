create database QLSV
go

use QLSV
go

create table TaiKhoan
(
    Id int identity(1,1) primary key,
    TenDangNhap varchar(255) unique,
    MatKhau varchar(255) not null,
    LoaiTaiKhoan nvarchar(40) default N'Giáo Viên'
)
go

create table Khoa
(
    Id int identity(1,1) primary key,
    MaKhoa varchar(255) unique,
    TenKhoa nvarchar(255) not null
)
go

create table Lop
(
    Id int identity(1,1) primary key,
    MaLop varchar(255) unique,
    TenLop nvarchar(255) not null,
    SoLuong int default 0,
    MaKhoa varchar(255) not null,
    foreign key (MaKhoa) references Khoa(MaKhoa)
)
go

create table GiaoVien
(
    Id int identity(1,1) primary key,
    MaGiaoVien varchar(255) unique,
    TenGiaoVien nvarchar(255) not null,
	NgaySinh Date default GETDATE(),
	GioiTinh nvarchar(4) not null,
	MaKhoa varchar(255) not null,
	MaLop varchar(255) not null,
	foreign key (MaKhoa) references Khoa(MaKhoa),
	foreign key (MaLop) references Lop(MaLop)
)
go

create table MonHoc
(
    Id int identity(1,1) primary key,
    MaMH varchar(255) unique,
    TenMH nvarchar(255) not null,
    SoTC int default 0,
    TietLT int default 0,  -- Số tiết lý thuyết
    TietTH int default 0   -- Số tiết thực hành
)
go

create table SinhVien
(
    Id int identity(1,1) primary key,
    MaSV varchar(255) unique,
    TenSV nvarchar(255) not null,
    NgaySinh date default GETDATE(),
    GioiTinh nvarchar(4) not null,
    QueQuan nvarchar(255) not null,
    NgayNhapHoc date default GETDATE(),
    MaLop varchar(255) not null,
    MaKhoa varchar(255) not null,
    MaGiaoVien varchar(255) not null,
    foreign key (MaLop) references Lop(MaLop),
    foreign key (MaKhoa) references Khoa(MaKhoa),
    foreign key (MaGiaoVien) references GiaoVien(MaGiaoVien)
)
go

create table Diem
(
    Id int identity(1,1) primary key,
    MaSV varchar(255) not null,
    MaMH varchar(255) not null,
    PhanTramTrenLop int default 0, -- Số tiết đi học
    PhanTramThi int default 0, -- Là tỉ lệ trọng số của điểm thi so với tổng điểm trung bình (DiemTB).
    DiemTrenLop float default 0,
    DiemThi float default 0,
    DiemTB float default 0,
    foreign key (MaSV) references SinhVien(MaSV),
    foreign key (MaMH) references MonHoc(MaMH)
)
go