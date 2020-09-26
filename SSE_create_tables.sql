CREATE TABLE dbo.role (
    id int PRIMARY KEY IDENTITY(1,1),
    role_name VARCHAR(50)
);

CREATE TABLE dbo.employee (
    emp_id int PRIMARY KEY IDENTITY (1,1),
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
);

CREATE TABLE dbo.employee_relationship (
     manager_id int NOT NULL,
     employee_id int NOT NULL,
	 PRIMARY KEY (manager_id, employee_id),
     FOREIGN KEY (employee_id) REFERENCES dbo.employee (emp_id)
);

CREATE TABLE dbo.employee_role (
    employee_id int NOT NULL,
    role_id int NOT NULL,
    PRIMARY KEY (employee_id, role_id),
    FOREIGN KEY (employee_id) REFERENCES dbo.employee (emp_id),
    FOREIGN KEY (role_id) REFERENCES dbo.role (id)
)