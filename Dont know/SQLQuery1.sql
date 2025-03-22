--INSERT INTO UserInfo (id, , firstname, lastname, password, phone, age, gender) VALUES
--('siri@gmail.com', 'siri', 'Bao', 'Thai', 'password123', 0866666666, 20, 'Nam');

CREATE TABLE Users (
    id INT IDENTITY(2000,1) PRIMARY KEY,
	rank NVARCHAR(30) NOT NULL DEFAULT 'Client',
    username NVARCHAR(100) NOT NULL,
    password NVARCHAR(100) NOT NULL DEFAULT '0',
	email NVARCHAR(100) NOT NULL,
    phone NVARCHAR(11) NOT NULL,
);

CREATE TABLE UsersInfo (
    id int PRIMARY KEY,
    firstname NVARCHAR(100) NOT NULL,
    lastname NVARCHAR(100) NOT NULL,
    age INT NOT NULL default 0,
    FOREIGN KEY (id) REFERENCES Users(id),
);

CREATE TABLE Managers (
    id INT PRIMARY KEY,
    namecinema NVARCHAR(100) NOT NULL default N'Chưa đặt tên',
    FOREIGN KEY (id) REFERENCES Users(id)
);
DELete Managers
CREATE TABLE Clients (
    id INT PRIMARY KEY,
    accumulate  int NOT NULL DEFAULT 0,
	customertype NVARCHAR(100) NOT NULL Default 'Thường',--Thường, Thành Viên
    FOREIGN KEY (id) REFERENCES Users(id),
);



CREATE TABLE Staffs (
    id INT PRIMARY KEY,
    salary FLOAT NOT NULL default 0,
	kpi float NOT NULL default 0,
    FOREIGN KEY (id) REFERENCES Users(id),
);






--CREATE TABLE AccountCategory (
--    id int PRIMARY KEY,
--    category VARCHAR(100) NOT NULL,
--    flowCinema VARCHAR(100) NOT NULL,
--    FOREIGN KEY (id) REFERENCES Account(id)
--);

CREATE TABLE Movie (
    id INT IDENTITY(4000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    showtime DATETIME NOT NULL DEFAULT GETDATE(),
    idcinema INT NOT NULL,
    durationoftime TIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (idcinema) REFERENCES Manager(id)
);

CREATE TABLE ProductCategory (
    id INT IDENTITY(200,10) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    idcinema INT NOT NULL,
    FOREIGN KEY (idcinema) REFERENCES Manager(id)
);

CREATE TABLE Product (
    id INT IDENTITY(1000,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    idcategory INT NOT NULL,
    FOREIGN KEY (idcategory) REFERENCES ProductCategory(id)
);

CREATE TABLE Seat (
    id VARCHAR(2) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    idmovie INT NOT NULL,
    Status INT NOT NULL DEFAULT 0,
    FOREIGN KEY (idmovie) REFERENCES Movie(id)
);

CREATE TABLE Bill (
    id INT IDENTITY(1,1) PRIMARY KEY,
    dateorder DATE NOT NULL DEFAULT GETDATE(),
    status INT NOT NULL DEFAULT 0,
    iduserpayer INT NOT NULL,
    FOREIGN KEY (iduserpayer) REFERENCES UserInfo(id)
);


 
-- Inserting specified data into the Account table without specifying id
INSERT INTO Account (rank, username, password)
VALUES 
    ('Manager', 'john_doe', 'password123'),
    ('Manager', 'jane_smith', 'securepassword'),
    ('Client', 'john_doe', 'password123'),
    ('Client', 'jane_smith', 'securepassword'),
    ('Client', 'bob_jones', 'bobspassword'),
    ('Staff', 'john_doe', 'password123'),
    ('Staff', 'jane_smith', 'securepassword'),
    ('Staff', 'bob_jones', 'bobspaffssword'),
    ('Client', 'john_doe', 'password123'),
    ('Client', 'jane_smith', 'securepassword'),
    ('Client', 'bob_jfdfones', 'bobspasdcdsword'),
    ('Client', 'bob_jodfdnes', 'bobspasccsword');
	select * from Account
INSERT INTO Manager (id, namecinema, Address)
VALUES
    (2032, 'Cinema A', 'Address A'),
    (2033, 'Cinema B', 'Address B');

INSERT INTO Staff (id,idmanager, salary)
VALUES
    (2037, 2032, 2000),
	(2039, 2032, 2100),
    (2038, 2033, 1800);

INSERT INTO Client (id, accumulate, idcinema)
VALUES
    ('C5678901', 50, 2032),
    ('C5678941', 10, 2033);

INSERT INTO AccountCategory (id, Category, FlowCinema)
VALUES
    ('M1234567', 'Manager', 'Flow for Manager A'),
    ('M2345678', 'Manager', 'Flow for Manager B'),
    ('S3456789', 'Staff', 'Flow for Staff A'),
    ('S4567890', 'Staff', 'Flow for Staff B'),
    ('C5678901', 'Client', 'Flow for Client A');

INSERT INTO UserInfo (id, FirstName, LastName, Email, PhoneNumber, YearOlds)
VALUES
    ('M1234567', 'John', 'Doe', 'john.doe@example.com', '123456789', 30),
    ('M2345678', 'Jane', 'Smith', 'jane.smith@example.com', '987654321', 28),
    ('S3456789', 'David', 'Johnson', 'david.johnson@example.com', '456789012', 25),
    ('S4567890', 'Emily', 'Williams', 'emily.williams@example.com', '654321098', 27),
    ('C5678901', 'Michael', 'Brown', 'michael.brown@example.com', '321098765', 35);

INSERT INTO Bill (id, DateOrder, Status, idUserPayer)
VALUES
    ('Bill001', GETDATE(), 1, 'M1234567'),
    ('Bill002', GETDATE(), 0, 'M2345678'),
    ('Bill003', GETDATE(), 1, 'M1234567'),
    ('Bill004', GETDATE(), 0, 'M2345678'),
    ('Bill005', GETDATE(), 1, 'M1234567');

INSERT INTO Movie (id, name,idCinema, price, Showtime, DurationOfTime)
VALUES
    ('Movie001', 'Movie A','M1234567', 10.5, GETDATE(), '02:00:00'),
    ('Movie002', 'Movie B','M1234567', 12.0, GETDATE(), '02:30:00'),
    ('Movie003', 'Movie C','M2345678', 9.0, GETDATE(), '01:45:00'),
    ('Movie004', 'Movie D','M2345678', 11.5, GETDATE(), '02:15:00'),
    ('Movie005', 'Movie E','M2345678', 8.5, GETDATE(), '01:30:00');

INSERT INTO Seat (id, name, idMovie, Status)
VALUES
    ('Seat001', 'A01', 'Movie001', 0),
    ('Seat002', 'A02', 'Movie001', 1),
    ('Seat003', 'B01', 'Movie002', 0),
    ('Seat004', 'B02', 'Movie002', 0),
    ('Seat005', 'C01', 'Movie003', 1);

INSERT INTO ProductCategory (id,idCinema, name)
VALUES
    ('Categ001','M1234567', 'Popcorn'),
    ('Categ002','M2345678', 'Drinks'),
    ('Categ003','M2345678', 'Snacks'),
    ('Categ004','M1234567', 'Tickets'),
    ('Categ005','M2345678', 'Merchandise');

INSERT INTO Product (id, name, price, idCategory)
VALUES
    ('Produ001', 'Popcorn Large', 5.5, 'Categ001'),
    ('Produ002', 'Soda', 3.0, 'Categ002'),
    ('Produ003', 'Chocolate Bar', 2.5, 'Categ003'),
    ('Produ004', 'Adult Ticket', 10.0, 'Categ004'),
    ('Produ005', 'T-Shirt', 15.0, 'Categ005');
    
ALTER TABLE Staff
ADD CONSTRAINT FK_idManager
FOREIGN KEY (idManager)
REFERENCES Manager(id);

--lấy ra thông tin về các hóa đơn của khách hàng mà được quản lý bởi Manager có ID là 'M1234567'
SELECT Bill.id, Bill.DateOrder, Bill.Status, UserInfo.FirstName, UserInfo.LastName
FROM Bill
JOIN UserInfo ON Bill.idUserPayer = UserInfo.id
JOIN Client ON UserInfo.id = Client.id
WHERE Client.idCinema = 'M1234567';

--lấy ra danh sách các phim của Manager có ID là 'M1234567
SELECT Movie.id, Movie.name, Movie.price, Movie.Showtime, Movie.DurationOfTime
FROM Movie
JOIN Manager ON Movie.idCinema = Manager.id
WHERE Manager.id = 'M1234567';
--lấy ra các hóa đơn mua vé xem phim có tên là 'Movie C' (
SELECT Bill.id, Bill.DateOrder, Bill.Status, UserInfo.FirstName, UserInfo.LastName
FROM Bill
JOIN UserInfo ON Bill.idUserPayer = UserInfo.id
JOIN Movie ON Bill.idUserPayer = UserInfo.id
WHERE Movie.name = 'Movie C';
--lấy ra các hóa đơn chưa được thanh toán
SELECT id, DateOrder, Status, idUserPayer
FROM Bill
WHERE Status <> 1;


