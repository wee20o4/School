CREATE database QuanLyRapPhim
GO

USE QuanLyRapPhim
GO


CREATE TABLE Users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    rank NVARCHAR(30) NOT NULL DEFAULT 'Client',
    username NVARCHAR(100) NOT NULL,
    password NVARCHAR(100) NOT NULL DEFAULT '0',
    email NVARCHAR(100) NOT NULL,
    phone NVARCHAR(11) NOT NULL
)
GO

CREATE TABLE UsersInfo (
    id INT PRIMARY KEY,
    firstname NVARCHAR(100) COLLATE Vietnamese_CI_AS NOT NULL,
    lastname NVARCHAR(100) COLLATE Vietnamese_CI_AS NOT NULL,
    age INT NOT NULL DEFAULT 0,
	  gender NVARCHAR(3) COLLATE Vietnamese_CI_AS NOT NULL,
    FOREIGN KEY (id) REFERENCES Users(id)
)
GO

CREATE TABLE Manager (
    id INT PRIMARY KEY,
    namecinema NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
    FOREIGN KEY (id) REFERENCES Users(id)
)
GO

CREATE TABLE Client (
    id INT PRIMARY KEY,
    accumulate INT NOT NULL DEFAULT 0,
    customertype NVARCHAR(100) NOT NULL DEFAULT 'Thường', --Thường, Thành Viên
    FOREIGN KEY (id) REFERENCES Users(id)
)
GO

CREATE TABLE Staff (
    id INT PRIMARY KEY,
    salary FLOAT NOT NULL DEFAULT 0,
    kpi FLOAT NOT NULL DEFAULT 0,
    FOREIGN KEY (id) REFERENCES Users(id)
)
GO

CREATE TABLE Movie (
    id INT IDENTITY(1000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    durationoftime TIME(0) NOT NULL DEFAULT '00:00',
)
GO


CREATE TABLE Room (
    id INT IDENTITY(2000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    capacity INT NOT NULL DEFAULT 0, --sức chứa
    status INT NOT NULL DEFAULT 0,
)
GO

CREATE TABLE Seat (
    id INT IDENTITY(3000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    idroom INT NOT NULL,
    status INT NOT NULL DEFAULT 0,
    FOREIGN KEY (idroom) REFERENCES Room(id)
)
GO

CREATE TABLE Showtimes (
  id INT IDENTITY(7000,1) PRIMARY KEY,
  dates DATETIME NOT NULL DEFAULT GETDATE(),
  showtime TIME(0) NOT NULL DEFAULT '00:00',
  idmanager INT NOT NULL,
  idmovie INT NOT NULL,
  idroom INT NOT NULL,
  FOREIGN KEY (idmanager) REFERENCES Manager(id),
  FOREIGN KEY (idmovie) REFERENCES Movie(id),
  FOREIGN KEY (idroom) REFERENCES Room(id)
)
GO

CREATE TABLE ProductCategory (
    id INT IDENTITY(4000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Product (
    id INT IDENTITY(5000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    idcategory INT NOT NULL,
    FOREIGN KEY (idcategory) REFERENCES ProductCategory(id)
)
GO

CREATE TABLE Bill (
    id INT IDENTITY(6000,1) PRIMARY KEY,
    dateorder DATE NOT NULL DEFAULT GETDATE(),
    status INT NOT NULL DEFAULT 0,
    iduserpayer INT NOT NULL,
    FOREIGN KEY (iduserpayer) REFERENCES UsersInfo(id),
)
GO

CREATE TABLE BillInfo (
    id INT PRIMARY KEY,
    countProduct INT DEFAULT 0,
    totalamount FLOAT DEFAULT 0,
    status INT NOT NULL DEFAULT 0,
    idproduct INT,
    idseat INT NOT NULL,
    idshowtime INT NOT NULL,
    FOREIGN KEY (id) REFERENCES Bill(id),
    FOREIGN KEY (idseat) REFERENCES Seat(id),
    FOREIGN KEY (idproduct) REFERENCES Product(id),
    FOREIGN KEY (idshowtime) REFERENCES Showtimes(id)
)
GO


INSERT INTO Users (rank, username, password, email, phone) VALUES 
('Manager', 'siri', 'password123', 'siri@gmail.com', '0865000000'),
('Manager', 'minhcuong', 'password123', 'minhcuong@gmail.com', '0865000001'),
('Client', 'client1', 'password123', 'client1@gmail.com', '0865000002'),
('Client', 'client2', 'password123', 'client2@gmail.com', '0865000003'),
('Staff', 'staff1', 'password123', 'staff1@gmail.com', '0865000004'),
('Staff', 'staff2', 'password123', 'staff2@gmail.com', '0865000005');

Select * From Users;

INSERT INTO UsersInfo (id, firstname, lastname, age, gender) VALUES
(1, 'Bao', 'Hoang', 20, N'Nam'),
(2, 'Minh', 'Cuong', 20, N'Nam'),
(3, 'Khach', 'Hang A', 29, N'Nữ'),
(4, 'Khach', 'Hang B', 26, N'Nữ'),
(5, 'Staff', 'A', 24, N'Nam'),
(6, 'Staff', 'B', 24, N'Nữ');

Select * From UsersInfo;

INSERT INTO Manager (id, namecinema) VALUES 
(1, 'Cinema C'),
(2, 'Cinema D');

INSERT INTO Client (id, accumulate, customertype) VALUES
(3, 200, 'Thường'),
(4, 300, 'Thành Viên');

INSERT INTO Staff (id, salary, kpi) VALUES
(5, 28000, 88),
(6, 26000, 85);

INSERT INTO Movie (name, price, durationoftime) VALUES
('Movie D', 15.0, '02:20:00'),
('Movie E', 7.0, '01:50:00'),
('Movie F', 9.0, '02:05:00');

INSERT INTO Room (name, capacity, status) VALUES
('Room 4', 130, 0),
('Room 5', 140, 1),
('Room 6', 160, 1);

INSERT INTO Seat (name, idroom, status) VALUES
('Seat D1', 2000, 1),
('Seat D2', 2001, 1),
('Seat E1', 2002, 0);

INSERT INTO Showtimes (dates, showtime, idmanager, idmovie, idroom) VALUES
('2024-07-01', '10:00:00', 1, 1000, 2000),
('2024-07-01', '14:00:00', 1, 1001, 2001),
('2024-07-01', '18:00:00', 1, 1002, 2002),
('2024-07-02', '10:00:00', 2, 1000, 2000),
('2024-07-02', '14:00:00', 2, 1001, 2001),
('2024-07-02', '18:00:00', 2, 1002, 2002);

SELECT * FROM Showtimes;


INSERT INTO ProductCategory (name) VALUES
('Meals'),
('Drink'),
('Popcorn');

INSERT INTO Product (name, price, idcategory) VALUES
('Hot Dog', 6.0, 4000),
('Burger', 8.0, 4001),
('Fries', 3.5, 4002);

INSERT INTO Bill (dateorder, status, iduserpayer) VALUES
('2024-06-30', 1, 1),
('2024-06-20', 0, 2),
('2024-06-10', 1, 3);

INSERT INTO BillInfo (id, countProduct, totalamount, status, idproduct, idseat, idshowtime) VALUES
(6000, 2, 12.0, 1, 5000, 3000, 7000),
(6001, 1, 8.0, 0, 5001, 3001, 7001),
(6002, 3, 21.0, 1, 5002, 3002, 7002);
