CREATE DATABASE QLThuVien
GO

USE QLThuVien
GO

--Tạo bảng DANGNHAP
CREATE TABLE DANGNHAP (
    TenDn VARCHAR(50) PRIMARY KEY,
    HoTen NVARCHAR(100),
    MatKhau VARCHAR(50),
    Quyen NVARCHAR(50)
);
GO

-- Tạo bảng DOCGIA
CREATE TABLE DOCGIA (
    MaDG VARCHAR(50) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATETIME,
    GioiTinh BIT,
    DonVi NVARCHAR(100)
);
GO

--Tạo bảng DMSACH
CREATE TABLE DMSACH(
	Masach VARCHAR(50) PRIMARY KEY,
	TenSach NVARCHAR(100),
	Nxb NVARCHAR(100),
	Tacgia NVARCHAR(100),
	Soluong INT
)
GO

--Tạo bảng DMCUON
CREATE TABLE DMCUON(
	Macuon VARCHAR(50) PRIMARY KEY,
	Masach VARCHAR(50) REFERENCES DMSACH(Masach) ,
	Trangthai BIT
)
GO

--Tạo bảng PHIEUMUON
CREATE TABLE PHIEUMUON(
	Sophieu INT PRIMARY KEY,
	NgayMuon DATETIME,
	Madg VARCHAR(50) REFERENCES DOCGIA(Madg)
)
GO

--Tạo bảng CTPHIEU
CREATE TABLE CTPHIEU(
	Sophieu INT,
	Macuon VARCHAR(50) REFERENCES DMCUON(Macuon),
	Ngayhentra DATETIME,
	Ngaytra DATETIME,
	TTTRA BIT,
	PRIMARY KEY (Sophieu, Macuon)
)
GO


-- Thêm dữ liệu vào bảng DANGNHAP
INSERT INTO DANGNHAP (TenDn, HoTen, MatKhau, Quyen) VALUES
('LeDuong', N'Lê Thanh Dương', '101010', N'Quản lý'),
('HoangAnh', N'Hoàng Anh', '191919', N'Nhân viên'),
('VuMinh', N'Vũ Đức Minh', '111222', N'Admin');
GO

-- Thêm dữ liệu vào bảng DOCGIA
INSERT INTO DOCGIA (MaDG, HoTen, NgaySinh, GioiTinh, DonVi) VALUES
('DG001', N'Nguyễn Văn Hòa', '1993-12-02', 1, N'Khoa CNTT'),
('DG002', N'Lê Văn Phong', '1991-12-19', 1, N'Khoa Kinh tế'),
('DG003', N'Trần Thị Thanh Hà', '1979-03-05', 0, N'DH10TH'),
('DG004', N'Mai Phương Mai', '1979-05-03', 1, N'Khoa CNTT'),
('DG005', N'Nguyễn Cao Bằng', '1993-04-01', 0, N'DH11TH'),
('DG006', N'Nguyễn Cao Trí', '2000-03-17', 0, N'DH12TH'),
('DG007', N'Ngô Thanh Mai', '2002-01-01', 0, N'DH12TH'),
('DG008', N'Trần Quốc Công', '2005-08-03', 0, N'DH12TH'),
('DG009', N'Nguyễn Thanh Mai', '2003-06-19', 0, N'DH12TH'),
('DG010', N'Lê Gia Bảo', '2000-02-05', 0, N'DH12TH'),
('DG011', N'Lê Thị Thanh', '1995-12-30', 0, N'DH12TH');
GO

--Thêm dữ liệu vào bảng DMSACH
INSERT INTO DMSACH(Masach,TenSach,Nxb, Tacgia, Soluong) VALUES
('CSDL', N'Cơ sở dữ liệu', N'Giáo dục và đào tạo', N'Hồ Cẩm Hà', 3),
('DLBP', N'Du lịch bốn phương', N'Thanh niên', N'Hoài Anh', 3),
('KTVM', N'Kinh tế vĩ mô', N'Thống kê', N'Nguyễn Thu Ba', 2),
('LTQL', N'Lập trình quản lý', N'Giáo dục và đào tạo', N'Nguyễn Xuân Huy', 3),
('LTHDT', N'Lập trình hướng đối tượng', N'Giáo dục và đào tạo', N'Nguyễn Nam Cao', 5),
('KTLT', N'Kỹ thuật lập trình', N'Giáo dục và đào tạo', N'Nguyễn Tấn Phương', 7),
('CTDLGT', N'Cấu trúc dữ liệu và giải thuật', N'Giáo dục và đào tạo', N'Nguyễn Minh Công', 10);
GO

--Thêm dữ liệu vào bảng DMCUON
INSERT INTO DMCUON(Macuon,Masach, Trangthai) VALUES
('CSDL1', 'CSDL', 1),
('CSDL2', 'CSDL', 0),
('CSDL3', 'CSDL', 0),
('DLBP1', 'DLBP', 1),
('DLBP2', 'DLBP', 0),
('DLBP3', 'DLBP', 0),
('KTVM1', 'KTVM', 0),
('KTVM2', 'KTVM', 0),
('LTQL1', 'LTQL', 0),
('LTQL2', 'LTQL', 0),
('LTQL3', 'LTQL', 0),
('KTLT1', 'KTLT',0),
('KTLT2', 'KTLT',0),
('KTLT3', 'KTLT',0),
('KTLT4', 'KTLT',0),
('KTLT5', 'KTLT',0),
('KTLT6', 'KTLT',0),
('KTLT7', 'KTLT',0),
('CTDLGT1', 'CTDLGT',0),
('CTDLGT2', 'CTDLGT',0),
('CTDLGT3', 'CTDLGT',0),
('CTDLGT4', 'CTDLGT',0),
('CTDLGT5', 'CTDLGT',0),
('CTDLGT6', 'CTDLGT',0),
('CTDLGT7', 'CTDLGT',0),
('CTDLGT8', 'CTDLGT',0),
('CTDLGT9', 'CTDLGT',0),
('CTDLGT10', 'CTDLGT',0),
('LTHDT1','LTHDT',0),
('LTHDT2','LTHDT',0),
('LTHDT3','LTHDT',0),
('LTHDT4','LTHDT',0),
('LTHDT5','LTHDT',0);
GO

--THêm dữ liệu vào bảng PHIEUMUON
INSERT INTO PHIEUMUON(Sophieu, Ngaymuon, Madg) VALUES
(001,'2013-12-19', 'DG001'),
(003,'2013-12-19','DG003')
GO
UPDATE PHIEUMUON
SET Sophieu = 002
WHERE Sophieu = 001
GO

--THêm dữ liệu vào bảng CTPHIEU
INSERT INTO CTPHIEU(Sophieu,Macuon,Ngayhentra, Ngaytra, TTTRA) VALUES
(001,'CSDL1','2013-12-19','',0),
(001,'LTQL1','2013-12-19','2013-12-19',1),
(003,'DLBP2','2013-12-19','2013-12-19',1),
(003,'KTVM1','2013-12-19','',0)
GO




