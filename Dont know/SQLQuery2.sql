create database sqltestt
use sqltestt
go

CREATE TABLE Users (
    id INT IDENTITY(2000,1) PRIMARY KEY,
    rank NVARCHAR(30) NOT NULL DEFAULT 'Client',
    username NVARCHAR(100) NOT NULL,
    password NVARCHAR(100) NOT NULL DEFAULT '0',
    email NVARCHAR(100) NOT NULL,
    phone NVARCHAR(11) NOT NULL
);

CREATE TABLE UsersInfo (
    id INT PRIMARY KEY,
    firstname NVARCHAR(100) NOT NULL,
    lastname NVARCHAR(100) NOT NULL,
    age INT NOT NULL DEFAULT 0,
    FOREIGN KEY (id) REFERENCES Users(id)
);

CREATE TABLE Manager (
    id INT PRIMARY KEY,
    namecinema NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
    FOREIGN KEY (id) REFERENCES Users(id)
);

CREATE TABLE Client (
    id INT PRIMARY KEY,
    accumulate INT NOT NULL DEFAULT 0,
    customertype NVARCHAR(100) NOT NULL DEFAULT 'Thường',--Thường, Thành Viên
    FOREIGN KEY (id) REFERENCES Users(id)
);

CREATE TABLE Staff (
    id INT PRIMARY KEY,
    salary FLOAT NOT NULL DEFAULT 0,
    kpi FLOAT NOT NULL DEFAULT 0,
    FOREIGN KEY (id) REFERENCES Users(id)
);

CREATE TABLE Movie (
    id INT IDENTITY(4000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    showtime DATETIME NOT NULL DEFAULT GETDATE(),
    durationoftime TIME NOT NULL
);

CREATE TABLE Room (
    id INT IDENTITY(6000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    capacity INT NOT NULL DEFAULT 0,--sức chứa
    Status INT NOT NULL DEFAULT 0,
    idmovie INT,
    FOREIGN KEY (idmovie) REFERENCES Movie(id)
);

CREATE TABLE Seat (
    id INT IDENTITY(7000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    idroom INT NOT NULL,
    Status INT NOT NULL DEFAULT 0,
    FOREIGN KEY (idroom) REFERENCES Room(id)
);

CREATE TABLE ProductCategory (
    id INT IDENTITY(200,10) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL
);

CREATE TABLE Product (
    id INT IDENTITY(1000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    idcategory INT NOT NULL,
    FOREIGN KEY (idcategory) REFERENCES ProductCategory(id)
);

CREATE TABLE Bill (
    id INT IDENTITY(1,1) PRIMARY KEY,
    dateorder DATE NOT NULL DEFAULT GETDATE(),
    status INT NOT NULL DEFAULT 0,
    iduserpayer INT NOT NULL,
    idproduct INT,
    idseat INT NOT NULL,
    FOREIGN KEY (iduserpayer) REFERENCES UsersInfo(id),
    FOREIGN KEY (idseat) REFERENCES Seat(id),
    FOREIGN KEY (idproduct) REFERENCES Product(id)
);

CREATE TABLE BillInfo (
    id INT PRIMARY KEY,
    countProduct INT DEFAULT 0,
    totalamount FLOAT DEFAULT 0,
    status INT NOT NULL DEFAULT 0,
    FOREIGN KEY (id) REFERENCES Bill(id),
);

INSERT INTO Users (rank, username, password, email, phone) VALUES 
('Manager', 'manager3', 'password789', 'manager3@example.com', '1234567896'),
('Client', 'client3', 'password789', 'client3@example.com', '1234567897'),
('Staff', 'staff3', 'password789', 'staff3@example.com', '1234567898'),
('Client', 'client4', 'password012', 'client4@example.com', '1234567899'),
('Staff', 'staff4', 'password012', 'staff4@example.com', '1234567800');

INSERT INTO UsersInfo (id, firstname, lastname, age) VALUES
(2000, 'David', 'Miller', 45),
(2001, 'Ella', 'Taylor', 32),
(2002, 'Frank', 'Harris', 29),
(2003, 'Grace', 'Clark', 26),
(2004, 'Hannah', 'Lewis', 24);

INSERT INTO Manager (id, namecinema) VALUES 
(2000, 'Cinema C');

INSERT INTO Client (id, accumulate, customertype) VALUES
(2001, 200, 'Thường'),
(2003, 300, 'Thành Viên');

INSERT INTO Staff (id, salary, kpi) VALUES
(2002, 28000, 88),
(2004, 26000, 85);

INSERT INTO Movie (name, price, showtime, durationoftime) VALUES
('Movie D', 15.0, '2024-07-04 21:00:00', '02:20:00'),
('Movie E', 7.0, '2024-07-05 17:00:00', '01:50:00'),
('Movie F', 9.0, '2024-07-06 16:00:00', '02:05:00');

INSERT INTO Room (name, capacity, status, idmovie) VALUES
('Room 4', 130, 0, 4000),
('Room 5', 140, 1, 4001),
('Room 6', 160, 1, 4002);

INSERT INTO Seat (name, idroom, status) VALUES
('Seat D1', 6000, 1),
('Seat D2', 6001, 1),
('Seat E1', 6002, 0);

INSERT INTO ProductCategory (name) VALUES
('Meals');

INSERT INTO Product (name, price, idcategory) VALUES
('Hot Dog', 6.0, 200),
('Burger', 8.0, 200),
('Fries', 3.5, 200);

INSERT INTO Bill (dateorder, status, iduserpayer, idproduct, idseat) VALUES
('2024-06-30', 1, 2001, 1000, 7000),
('2024-06-20', 1, 2003, 1001, 7001),
('2024-06-10', 1, 2000, 1002, 7002);

INSERT INTO BillInfo (id, countProduct, totalamount, status) VALUES
(3, 1, 15.0, 1),
(1, 2, 14.0, 1),
(2, 3, 27.0, 1);


--lấy ra hóa đơn và thông tin người đặt của bộ phim:Movie D
SELECT 
    Bill.id AS BillID,
    Bill.dateorder AS OrderDate,
    Bill.status AS BillStatus,
    UsersInfo.firstname AS FirstName,
    UsersInfo.lastname AS LastName,
    UsersInfo.age AS Age,
    Movie.name AS MovieName
FROM 
    Bill
JOIN 
    UsersInfo ON Bill.iduserpayer = UsersInfo.id
JOIN 
    Users ON UsersInfo.id = Users.id
JOIN 
    Seat ON Bill.idseat = Seat.id
JOIN 
    Room ON Seat.idroom = Room.id
JOIN 
    Movie ON Room.idmovie = Movie.id
WHERE 
    Movie.name = 'Movie D';

--lấy ra những sản phẩm, phim, phòng xem, ghế ngồi đã được đặt vào ngày: 2024-06-10

SELECT 
    Bill.id AS BillID,
    Bill.dateorder AS OrderDate,
    Product.name AS ProductName,
    Movie.name AS MovieName,
    Room.name AS RoomName,
    Seat.name AS SeatName,
    UsersInfo.firstname AS FirstName,
    UsersInfo.lastname AS LastName
FROM 
    Bill
LEFT JOIN 
    Product ON Bill.idproduct = Product.id
JOIN 
    Seat ON Bill.idseat = Seat.id
JOIN 
    Room ON Seat.idroom = Room.id
JOIN 
    Movie ON Room.idmovie = Movie.id
JOIN 
    UsersInfo ON Bill.iduserpayer = UsersInfo.id
WHERE 
    Bill.dateorder = '2024-06-10';
