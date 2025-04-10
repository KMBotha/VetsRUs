USE master;
GO

-- Create the VetDb database only if it does not already exist

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'VetDb') 
BEGIN
	CREATE DATABASE VetDb;
END
GO

-- Switch to the VetDb database

USE VetDb; 
GO

-- Create Cats table
CREATE TABLE Cats(
	CatID INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50) NOT NULL, 
	Breed VARCHAR(50) NOT NULL,
	OwnerName VARCHAR(50) NOT NULL,
	OwnerNumber VARCHAR(100) NOT NULL,
	Age INT NOT NULL,
	Weight INT NOT NULL,
	Conditions VARCHAR(100) NOT NULL,
); 
GO

-- Create Dogs table

CREATE TABLE Dogs(
	DogID INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50) NOT NULL, 
	Breed VARCHAR(50) NOT NULL,
	OwnerName VARCHAR(50) NOT NULL,
	OwnerNumber VARCHAR(100) NOT NULL,
	Age INT NOT NULL,
	Weight INT NOT NULL,
	Conditions VARCHAR(100) NOT NULL,
); 
GO

--Insert data into Cats table

INSERT INTO Cats(Name ,Breed, OwnerName, OwnerNumber, Age, Weight, Conditions)
Values
('Fluffy', 'Domestic Shorthair', 'John', '0821234567',2,6,'Healthy'),
('Snowball', 'Ragdoll', 'Emily', '0721234567',5,10,'Diabetes'),
('Hercules', 'Russian Blue', 'Aldron', '0824567893',1,5,'Malnourished');
GO

-- Insert data into Dogs table

INSERT INTO Dogs(Name ,Breed, OwnerName, OwnerNumber, Age, Weight, Conditions)
Values
('Jasper', 'Husky', 'Liam', '0821284567',2,10,'Healthy'),
('Bruno', 'Boerbull', 'Luke', '0735849612',10,9,'Healthy - Elderly'),
('Billy', 'Jack Russel', 'Alex', '0824569693',5,6,'Healthy');
GO



