--I will be using the origial database I first created 211115SQL-KarenM
--How to create new database
--CREATE DATABASE CoffeeShop
--DROP
--DROP DATABASE CoffeeShop
DROP TABLE Store;
DROP TABLE Coffee;
DROP TABLE [Order];
DROP TABLE Customer;


-----Tables
CREATE TABLE Store
(
    StoreID INT PRIMARY KEY,
    StoreLocation VARCHAR(20) NOT NULL
);

CREATE TABLE Inventory
(
	InvnetoryID INT PRIMARY KEY,
	StoreID INT FOREIGN KEY REFERENCES Store(StoreID),
	Quantity INT, 
	CoffeeID INT FOREIGN KEY REFERENCES Coffee(ProductID) 
);

CREATE TABLE Coffee
(
    ProductID INT PRIMARY KEY,
    Size VARCHAR (100),
    Price MONEY NOT NULL,

);

CREATE TABLE [Order]
(
    OrderID INT PRIMARY KEY,
	CustomerId INT FOREIGN KEY REFERENCES Customers(CustomerID),
    Quantity INT NOT NULL,
    PRICE MONEY NOT NULL

);

CREATE TABLE Customers
(
    CustomerId INT NOT NULL IDENTITY, --PK
    FirstName NVARCHAR(40) NOT NULL,
    LastName NVARCHAR(20) NOT NULL,
	Email NVARCHAR(20) NOT NULL,
    Phone NVARCHAR(24),
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId])
);
--trying to implement it to my customer i like the idead of autoincrement id
--when new cusotmer is created
--create table student 
--(
--id integer primary key autoincrement, 
--student_name NVARCHAR 50 not null, 
--dept varchar2(10), 
--major_subject varchar2(10), 
--student_id varchar2(50), 
--email varchar2(50) not null, 
--pwdhash binary(64) not null);

INSERT Coffee
	(ProductID, Size, Price)
VALUES
	(1, 'Small', 2),
	(2, 'Medium', 3),
	(3, 'Large', 5);

INSERT [Order]
	(OrderID, Quantity, Price)
VALUES
	(1, 3, 6),
	(2,  1,	3),
	(3, 2, 15);
	
INSERT Customers
(CustomerId, FirstName, LastName, Email, Phone)
VALUES
(01, 'Bat', 'Man', 'bats@gmail.com', '123-456-7890'),
(02, 'Spider', 'Man', 'spidy@gmail.com', '111-456-7890'),
(03, 'Wonder', 'Woman', 'wonder@gmail.com', '222-456-7890');

INSERT Store
(storeID, storeLocation )
VALUES
(01, 'Gotham'),
(02, 'New York'),
(03, 'Wonderland');

SELECT * FROM Store;
SELECT * FROM Coffee;
SELECT * FROM [Order];
SELECT * FROM Customers;

--This fixed my IDENTITY_INSERT OFF error
SET IDENTITY_INSERT Customers ON;