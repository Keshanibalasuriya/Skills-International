-- 1️⃣Create Database
CREATE DATABASE Student;
GO

-- 2️⃣ Use the Database
USE Student;
GO

-- 3️⃣ Create Logins Table
CREATE TABLE Logins (
    loginId INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(50) NOT NULL
);
GO

-- 4️⃣ Create Registration Table
CREATE TABLE Registration (
    regNo INT PRIMARY KEY,
    firstName VARCHAR(50) NOT NULL,
    lastName VARCHAR(50) NOT NULL,
    dateOfBirth DATE,
    gender VARCHAR(10),
    address VARCHAR(100),
    email VARCHAR(100),
    mobilePhone BIGINT,
    homePhone BIGINT,
    parentName VARCHAR(100),
    nic VARCHAR(20),
    contactNo BIGINT
);
GO

-- 5️⃣ Insert sample data into Logins
INSERT INTO Logins (username, password)
VALUES 
('admin', '12345'),
('student1', 'pass1'),
('student2', 'pass2');
GO

-- 6️⃣ Insert sample data into Registration
INSERT INTO Registration 
(regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo)
VALUES
(1, 'Nimal', 'Perera', '2000-05-15', 'Male', 'Colombo', 'nimal@gmail.com', 771234567, 112345678, 'Sunil Perera', '991234567V', 123456789),
(2, 'Kavindi', 'Silva', '2001-08-22', 'Female', 'Galle', 'kavindi@gmail.com', 772345678, 113456789, 'Chandana Silva', '200134567V', 987654321),
(3, 'Saman', 'Fernando', '1999-12-10', 'Male', 'Kandy', 'saman@gmail.com', 773456789, 114567890, 'Ranjith Fernando', '982345678V', 456123789);
GO

-- 7️⃣ Verify
SELECT * FROM Logins;
SELECT * FROM Registration;
