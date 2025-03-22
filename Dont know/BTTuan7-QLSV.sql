CREATE DATABASE BT_Tuan7_QuanLySinhVien 
GO

USE 
BT_Tuan7_QuanLySinhVien
GO

CREATE TABLE DangNhap(
	TenDangNhap varchar(50) primary key,
	HoTen nvarchar(100),
	MatKhau varchar(50) not null,
	Quyen nvarchar(50)
);
GO

create table Khoa(
	MaKhoa varchar(50) primary key,
	TenKhoa nvarchar(100)
);
GO


Create table SinhVien(
	MaSo int primary key,
	HoTen nvarchar(100),
	NgaySinh Datetime,
	Gioitinh bit,
	DiaChi nvarchar(100),
	DienThoai nvarchar(20) unique,
	MaKhoa varchar(50) references Khoa(Makhoa)
);
GO

create table MonHoc(
	MaMH varchar(50) primary key,
	TenMH nvarchar(100),
	SoTiet int
);
GO

create table KetQua(
	MaSo int,
	MaMH varchar(50) references MonHoc(MaMH),
	Diem decimal,
	primary key(MaSo, MaMH)
);
GO


insert into DangNhap VALUES
('lethanh',N'Lê Thị Vĩnh Thanh','lt123456',N'Admin'),
('minhtham',N'Nguyễn Thị minh Thắm','mt123456',N'Quản lý'),
('phandat',N'Phan Tấn Đạt','pd123456',N'Nhân viên');
GO

insert into DangNhap VALUES
('1',N'Bao','1',N'Admin');
GO

select * from DangNhap

insert into Khoa values
('CNTT',N'Công nghệ thông tin'),
('DL',N'Du lịch'),
('NN',N'Ngôn ngữ');
GO

select * from Khoa

insert into SINHVIEN VALUES
(1,N'Lê Văn A','2018-01-01',1,N'Vũng Tàu','1627669368','CNTT'),
(2,N'Lê Văn B','2018-01-02',0,N'Vũng Tàu','1627669369','DL'),
(3,N'Lê Văn C','2018-01-03',1,N'Vũng Tàu','1627669360','NN'),
(4,N'Lê Văn D','2018-01-04',0,N'Vũng Tàu','1627669361','CNTT'),
(5,N'Lê Văn E','2018-01-05',1,N'Vũng Tàu','1627669362','DL');
GO

select * from SINHVIEN

insert into MonHoc values
('CSDL',N'Cơ sở dữ liệu', 12),
('GTCB',N'Giao tiếp cơ bản',3),
('LTC#',N'Lập trình .Net',3),
('LTHDT',N'Lập trình hướng đối tượng',3),
('TACN',N'Tiếng anh chuyên ngành',15),
('TCC',N'Toán cao cấp',20);
GO

select * from MonHoc

insert into KetQua values
(1,'CSDL', 7),
(1,'LTHDT', 8),
(1,'TACN', 7.5),
(2,'GTCB', 5),
(3,'CSDL', 5),
(3,'LTHDT', 7),
(4,'GTCB', 3),
(4,'TACN', 8);
GO

select * from KetQua

 SELECT MaMH, TenMH, SoTiet
            FROM MonHoc