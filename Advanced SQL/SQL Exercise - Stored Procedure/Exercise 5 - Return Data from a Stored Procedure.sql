use strpro;
DELIMITER //

CREATE PROCEDURE sp_CountEmployeesByDepartment(
    IN dept_id INT
)
BEGIN
    SELECT 
        COUNT(*) AS TotalEmployees
    FROM 
        Employees
    WHERE 
        DepartmentID = dept_id;
END //

DELIMITER ;
CALL sp_CountEmployeesByDepartment(2);