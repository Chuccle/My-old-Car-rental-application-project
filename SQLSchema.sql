CREATE TABLE PackageDuration (
 PackageDurationID int Identity (1,1)  Primary Key, 
 DurationDays int 

 /*much more scalable + maintainable for more options */
 
);


CREATE TABLE PackageType (
 PackageTypeID int Identity (1,1)  Primary Key, 
 Type varchar(20) 
 
 /*much more scalable + maintainable for more options */

);




CREATE TABLE CustomerInfo (
 CustomerID int Identity (1,1) Primary Key, 
 FirstName varchar(50),
 LastName varchar(50),
 Nationality varchar(50),
 'Age may be Obsolete since it can be determined from DOB'
 Age int,
 DOB varchar(8),
 LicenseHeldYears int,
 PackageDurationID int FOREIGN KEY REFERENCES PackageDuration(PackageDurationID),
 PackageTypeID int FOREIGN KEY REFERENCES PackageType(PackageTypeID),
 TotalFee varchar(10),
);

