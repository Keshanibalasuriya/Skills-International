-- Create Database
CREATE DATABASE Student;
GO

-- Use the Database
USE Student;
GO

-- Create Logins Table
CREATE TABLE Logins (
    loginId INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(50) NOT NULL
);
GO

-- Create Registration Table
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

-- Insert sample data into Logins
INSERT INTO Logins (username, password)
VALUES 
('admin', '12345'),
('student1', 'pass1'),
('student2', 'pass2');
GO

-- Insert sample data into Registration
INSERT INTO Registration 
(regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo)
VALUES
(1, 'Nimal', 'Perera', '2000-05-15', 'Male', 'Colombo', 'nimal@gmail.com', 771234567, 112345678, 'Sunil Perera', '991234567V', 123456789),
(2, 'Kavindi', 'Silva', '2001-08-22', 'Female', 'Galle', 'kavindi@gmail.com', 772345678, 113456789, 'Chandana Silva', '200134567V', 987654321),
(3, 'Saman', 'Fernando', '1999-12-10', 'Male', 'Kandy', 'saman@gmail.com', 773456789, 114567890, 'Ranjith Fernando', '982345678V', 456123789),
(4, 'Tharindu', 'Wijesinghe', '2002-03-11', 'Male', 'Matara', 'tharindu@gmail.com', 774567890, 115678901, 'Anura Wijesinghe', '200245678V', 321654987),
(5, 'Dilini', 'Rajapaksha', '2000-11-02', 'Female', 'Kurunegala', 'dilini@gmail.com', 775678901, 116789012, 'Kusum Rajapaksha', '200045678V', 741852963),
(6, 'Kasun', 'Bandara', '1998-07-28', 'Male', 'Negombo', 'kasun@gmail.com', 776789012, 117890123, 'Mahinda Bandara', '983456789V', 852963741),
(7, 'Rashmi', 'Jayasinghe', '2001-02-17', 'Female', 'Anuradhapura', 'rashmi@gmail.com', 777890123, 118901234, 'Sumith Jayasinghe', '200134568V', 963741852),
(8, 'Isuru', 'Dissanayake', '1999-09-05', 'Male', 'Rathnapura', 'isuru@gmail.com', 778901234, 119012345, 'Pradeep Dissanayake', '993456789V', 159753486),
(9, 'Thilini', 'Ranasinghe', '2002-06-14', 'Female', 'Jaffna', 'thilini@gmail.com', 779012345, 119123456, 'Nimal Ranasinghe', '200245679V', 357951486),
(10, 'Pasindu', 'Ekanayake', '2000-09-30', 'Male', 'Badulla', 'pasindu@gmail.com', 770123456, 110234567, 'Chamara Ekanayake', '200045679V', 258456789);
GO

-- Verify data
SELECT * FROM Logins;
SELECT * FROM Registration;
GO
