CREATE TABLE Product(
	Id INT PRIMARY KEY,
	Name TEXT
);

INSERT INTO Product
VALUES
	(1, 'Немолоко'),
	(2, 'Креветки'),
	(3, 'Сервелат'),
	(4, 'Рафаэлло');

CREATE TABLE Category (
	Id INT PRIMARY KEY,
	Name TEXT
);

INSERT INTO Category
VALUES
	(1, 'Молочный'),
	(2, 'Морепродукт'),
	(3, 'Конфеты'),
	(4, 'Подарок');

CREATE TABLE ProductCategory (
	ProductId INT FOREIGN KEY REFERENCES Product(Id),
	CategoryId INT FOREIGN KEY REFERENCES Category(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategory
VALUES
	(4, 4),
	(4, 3),
	(2, 2),
	(1, 1);

SELECT Product."Name", Category."Name"
FROM Product 
LEFT JOIN ProductCategory
	ON Product.Id = ProductCategory.ProductId
LEFT JOIN Category
	ON ProductCategory.CategoryId = Category.Id;