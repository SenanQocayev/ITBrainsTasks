CREATE DATABASE Market
USE Market

CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50),
    Price DECIMAL(10, 2),
    Brand NVARCHAR(50)
)

INSERT INTO Products (Name, Price, Brand)
VALUES 
    ('Laptop', 1200, 'Dell'),
    ('Smartphone', 80, 'Samsung'),
    ('Headphones', 10, 'Sony'),
    ('Keyboard', 5, 'Logitech'),
    ('Monitor', 3, 'LG'),
    ('Camera', 50, 'Canon'),
    ('Tablet', 4, 'Apple'),
    ('Printer', 20, 'HP'),
    ('Speaker', 15, 'Bose'),
    ('Mouse', 3, 'Microsoft')


	SELECT * FROM Products WHERE Price > 10

	SELECT * FROM Products WHERE Price < (SELECT AVG(Price) FROM Products)

	SELECT CONCAT(Name, ' - ', Brand) AS ProductInfo FROM Products WHERE LEN(Brand) > 5