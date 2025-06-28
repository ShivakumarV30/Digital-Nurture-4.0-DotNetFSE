create schema strpro;
use strpro;

CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY, 
	DepartmentName VARCHAR(100) 
);
CREATE TABLE Employees ( 
    EmployeeID INT PRIMARY KEY AUTO_INCREMENT, 
    FirstName VARCHAR(50), 
    LastName VARCHAR(50), 
    DepartmentID INT, 
    Salary DECIMAL(10,2), 
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

INSERT INTO Departments (DepartmentID, DepartmentName) VALUES 
(1, 'HR'), 
(2, 'Finance'), 
(3, 'IT'), 
(4, 'Marketing'); 
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, 
JoinDate) VALUES 
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'), 
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'), 
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'), 
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');

select * from Departments;
select * from Employees;


DELIMITER //

CREATE PROCEDURE sp_GetEmployeesByDepartment(IN dept_id INT)
BEGIN
    SELECT 
        Employees.EmployeeID,
        Employees.FirstName,
        Employees.LastName,
        Departments.DepartmentName,
        Employees.Salary,
        Employees.JoinDate
    FROM Employees
    JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
    WHERE Employees.DepartmentID = dept_id;
END //

DELIMITER ;
CALL sp_GetEmployeesByDepartment(3);




DELIMITER //

CREATE PROCEDURE sp_InsertEmployee(
    IN fname VARCHAR(50),
    IN lname VARCHAR(50),
    IN dept INT,
    IN sal DECIMAL(10,2),
    IN join_date DATE
)
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (fname, lname, dept, sal, join_date);
END //

DELIMITER ;
CALL sp_InsertEmployee('Sarah', 'Williams', 2, 6200.00, '2023-08-10');
SELECT * FROM Employees;