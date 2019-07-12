CREATE TABLE EmployeeDetails(
EmployeeID varchar(5) primary key,
EmployeeName varchar(20),
EmployeeAddress varchar (30),
EmployeeSalary float(10)
);

CREATE TABLE CompanyDetails(
CompanyID varchar(5) primary key,
EmployeeID varchar(5) references EmployeeDetails,
CompanyName varchar(20),
CompanyAddress varchar(30),
CompanyType varchar(20)
);

CREATE TABLE ProductDetails(
EmployeeID varchar(5)  references EmployeeDetails,
CompanyID varchar(5)  references CompanyDetails,
EmployeeName varchar(20),
ProductID varchar(5) primary key,
Product_Description varchar (30)
);
CREATE TABLE CustomerDetails(
EmployeeID varchar(5)  references EmployeeDetails,
CompanyID varchar(5)  references CompanyDetails,
ProductID varchar(5) references ProductDetails,
CustomerName varchar(20),
CustomerAddress varchar (30)
);

