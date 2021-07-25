CREATE TABLE CustomerInfo (
 CustomerID int Identity (1,1) Primary Key, 
 FirstName varchar(50),
 LastName varchar(50),
 Nationality varchar(50),
 Age int,
 DOB varchar(8),
 LicenseHeldYears int,
);

CREATE TABLE Packageinfo (
 PackageID varchar(20), 
 TotalFee  varchar(10),
 CustomerID int,
 PRIMARY KEY (PackageID),
 Foreign Key (CustomerID) References CustomerInfo(CustomerID)
);

