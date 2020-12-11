USE master
GO
CREATE DATABASE PlayItAgainSports
GO
USE PlayItAgainSports
GO
CREATE TABLE dbo.Person(
    PersonID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    UserName NVARCHAR(50) NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    EmailAddress NVARCHAR(100) NOT NULL,
);
GO
CREATE TABLE dbo.Employee(
    EmployeeID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    PersonID INT NOT NULL,
    Position NVARCHAR(50) NOT NULL,
    Salary INT NOT NULL,
    HireDate DATETIME NOT NULL,
    TerminationDate DATETIME NULL
);
GO
ALTER TABLE dbo.Employee
ADD CONSTRAINT PersonID FOREIGN KEY (PersonID)
REFERENCES PlayItAgainSports.dbo.Person (PersonID)

GO
CREATE TABLE dbo.Rewards(
    RewardsID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    PersonID INT NOT NULL,
    RewardsPoints INT NOT NULL
);
GO
ALTER TABLE dbo.Rewards
ADD CONSTRAINT PersonID FOREIGN KEY (PersonID)
REFERENCES PlayItAgainSports.dbo.Person (PersonID)
GO
CREATE TABLE dbo.Item(
    SKU INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    ItemCount INT NOT NULL,
    Price FLOAT NOT NULL,
    ItemName NVARCHAR(50) NOT NULL
);
GO
CREATE TABLE dbo.Transactions(
    TransactionID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    SKU INT NOT NULL,
    EmployeeID INT NOT NULL,
    RewardsID INT NULL
);
ALTER TABLE dbo.Transactions
ADD CONSTRAINT SKU FOREIGN KEY (SKU)
REFERENCES PlayItAgainSports.dbo.Item (SKU)
GO
ALTER TABLE dbo.Transactions
ADD CONSTRAINT EmployeeID FOREIGN KEY (EmployeeID)
REFERENCES PlayItAgainSports.dbo.Employee (EmployeeID)
GO
ALTER TABLE dbo.Transactions
ADD CONSTRAINT RewardsID FOREIGN KEY (RewardsID)
REFERENCES PlayItAgainSports.dbo.Rewards (RewardsID)
GO