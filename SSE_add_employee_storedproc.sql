-- Store procedure that will be called from the code to insert new employee records

USE SSquaredEnterprises;  
GO  
CREATE PROCEDURE spAddNewEmployee  
    @EmployeeID int, 
    @LastName nvarchar(50),   
    @FirstName nvarchar(50),
	@RoleId int,
	@ManagerId int
AS   

	IF NOT EXISTS (SELECT 1 FROM employee Where emp_id = @EmployeeID)
		BEGIN
			-- Create entry for new employee
			INSERT INTO employee(
				emp_id, 
				first_name, 
				last_name
			)
			VALUES (
				@EmployeeID,
				@FirstName,
				@LastName
			);
			
			
			-- Create entry for employee role
			INSERT INTO employee_role(
				employee_id,
				role_id
			)
			VALUES (
				@EmployeeID,
				@RoleId
			);
			
			IF(@ManagerId IS NOT NULL)
			BEGIN
				-- Create entry for employee manager relationship
				INSERT INTO employee_relationship(
					manager_id,
					employee_id
				)
				VALUES	(
					@ManagerId,
					@EmployeeID
				);
			END
		END
	
GO  