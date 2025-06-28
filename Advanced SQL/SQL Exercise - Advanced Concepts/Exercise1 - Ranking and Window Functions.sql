create schema onlineretail;
use onlineretail;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
    );
    
INSERT INTO Products VALUES (1, 'Headphones', 'Electronics', 42000);
INSERT INTO Products VALUES (2, 'Monitor', 'Electronics', 69000);
INSERT INTO Products VALUES (3, 'Tablet', 'Electronics', 58000);
INSERT INTO Products VALUES (4, 'Smartwatch', 'Electronics', 25000);
INSERT INTO Products VALUES (5, 'T-Shirt', 'Fashion', 1200);
INSERT INTO Products VALUES (6, 'Sneakers', 'Fashion', 3000);
INSERT INTO Products VALUES (7, 'Hoodie', 'Fashion', 2700);

select * from products;

SELECT *
FROM (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum,
           RANK()       OVER (PARTITION BY Category ORDER BY Price DESC) AS PriceRank,
           DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRank
    FROM Products
) RankedProducts
WHERE RowNum <= 3 OR PriceRank <= 3 OR DenseRank <= 3;
