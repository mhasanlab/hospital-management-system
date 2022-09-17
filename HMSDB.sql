/*
    => Project Title: Hospital Management System
    => Database Name: HMSDB
    => Scaffold-DbContext "Server=.;Database=HMSDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
*/

USE master
GO

--Drop Existing Database If Exists

DROP DATABASE IF EXISTS HMSDB
GO

CREATE DATABASE HMSDB
ON
(
    NAME= 'HMSDB_DATA',
    FILENAME='E:\FINAL PROJECT\SQL_DATABASE\HMSDB_DATA.mdf',
    SIZE=50MB,
    MAXSIZE=100MB,
    FILEGROWTH = 10%
)
LOG ON
(
    NAME= 'HMSDB_LOG',
    FILENAME='E:\FINAL PROJECT\SQL_DATABASE\HMSDB_LOG.ldf',
    SIZE=25MB,
    MAXSIZE=50MB,
    FILEGROWTH = 1MB
)
GO

-- Use Database

USE HMSDB
GO

-- Section 01

-- Table (Hospital)

CREATE TABLE Hospital
(
    hospital_id INT PRIMARY KEY NOT NULL,
    hospital_name NVARCHAR(150) NOT NULL,
    hospital_type NVARCHAR(50) NOT NULL,
    area NVARCHAR(25) NOT NULL,
    road NVARCHAR(25) NOT NULL,
    country NVARCHAR(25) NOT NULL
)
GO

-- Table (Hospital_Contact)

CREATE TABLE Hospital_Contact
(
    contact_id INT PRIMARY KEY NOT NULL,
    contact_type NVARCHAR(25) NOT NULL,
    hospital_id INT REFERENCES Hospital(hospital_id),
    phone NVARCHAR(15) NOT NULL,
    email NVARCHAR(50) NOT NULL
)
GO

-- Table(Room)

CREATE TABLE Room
(
    room_id INT PRIMARY KEY NOT NULL,
    room_type NVARCHAR(25) NOT NULL,
    room_charge DECIMAL NOT NULL,
    room_location NVARCHAR(20) NOT NULL,
    [availability] BIT
)
GO


-- Section 02

-- Table (Doctor)

CREATE TABLE Doctor
(
    doctor_id INT PRIMARY KEY IDENTITY NOT NULL,
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50) NOT NULL,
    specialist NVARCHAR(25) NOT NULL -- we pass specialist api list here
)
GO
-- Table (Patient)

CREATE TABLE Patient
(
    patient_id INT PRIMARY KEY IDENTITY NOT NULL,
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50) NOT NULL,
    gender NVARCHAR (10) NOT NULL, -- Pass List
    [address] NVARCHAR(100) NOT NULL,
    city NVARCHAR(25) NOT NULL, -- Need To creare an external api name city
    dob DATE NOT NULL,
    phone NVARCHAR(15) NOT NULL,
    email NVARCHAR(50) NOT NULL
)
GO

-- Table(Appointment)

CREATE TABLE Appointment
(
    appointment_id INT PRIMARY KEY IDENTITY NOT NULL,
    patient_id INT REFERENCES Patient(patient_id),
    [type] NVARCHAR(25) NOT NULL,
    appointment_date DATE NOT NULL,
    appointment_time TIME NOT NULL,
    appointment_des NVARCHAR(50) NULL,
    doctor_id INT REFERENCES Doctor(doctor_id)
)
GO

-- Table(PatientAddmission)

CREATE TABLE Addmission
(
    admission_id INT PRIMARY KEY IDENTITY NOT NULL,
    patient_id INT REFERENCES Patient(patient_id),
    admission_date DATE NOT NULL,
    room_id INT REFERENCES Room(room_id),
)
GO

-- Section 03

-- Table (Medicine)

CREATE TABLE Medicine
(
    medicine_id INT PRIMARY KEY IDENTITY NOT NULL,
    medicine_name NVARCHAR(150) NOT NULL,
    medicine_type NVARCHAR(25) NOT NULL,
    medicine_des NVARCHAR(150) NULL,
    medicine_price DECIMAL NOT NULL
)
GO

-- Table (Supplier) 
CREATE TABLE Supplier
(
    supplier_id INT PRIMARY KEY IDENTITY NOT NULL,
    supplier_name NVARCHAR(100) NOT NULL,
    phone NVARCHAR(15) NOT NULL,
    email NVARCHAR(50) NOT NULL,
    [address] NVARCHAR(100) NOT NULL,
)
GO

--  Table (Medicine_Report)

CREATE TABLE Medicine_Report
(
    med_report_id INT PRIMARY KEY IDENTITY NOT NULL,
    medicine_id INT REFERENCES Medicine(medicine_id),
    supplier_id INT REFERENCES Supplier(supplier_id),
    quantity FLOAT NOT NULL,
    production_date DATE NOT NULL,
    expir_date DATE NOT NULL,
    [availability] BIT
)
GO

-- Table (Prescribed_Med)

CREATE TABLE Prescribed_Med
(
    presc_med_id INT PRIMARY KEY NOT NULL,
    patient_id INT REFERENCES Patient(patient_id),
    medicine_id INT REFERENCES Medicine(medicine_id),
)
GO

-- Section 04

-- table (Medical_Test)

CREATE TABLE Medical_Test 
(
    medical_test_code INT PRIMARY KEY NOT NULL,
    test_name NVARCHAR(75) NOT NULL,
    test_price DECIMAL NOT NULL
)
GO

-- table (Lab)

CREATE TABLE Lab
(
    lab_no INT PRIMARY KEY,
    medical_test_code INT REFERENCES Medical_Test(medical_test_code),
    test_date DATE NOT NULL,
    patient_id INT REFERENCES Patient(patient_id),
    height DECIMAL,
    [weight] DECIMAL,
    blood_pressure DECIMAL,
    blood_group NVARCHAR(10) NOT NULL
)
GO

-- Table (Patient_Report)

CREATE TABLE Patient_Report
(
    reort_id INT PRIMARY KEY IDENTITY NOT NULL,
    patient_id INT REFERENCES Patient(patient_id),
    medical_test_code INT REFERENCES Medical_Test(medical_test_code),
    diagnose NVARCHAR(MAX) NOT NULL,
    doctor_id INT REFERENCES Doctor(doctor_id)
)
GO

--Section 05

-- Table (Departments)

CREATE TABLE Departments
(
	department_id INT IDENTITY PRIMARY KEY,
	dep_Name NVARCHAR(30) NOT NULL,
	dep_maneger NVARCHAR(30) NOT NULL,
)
GO

CREATE TABLE Employee
(
	employee_id INT PRIMARY KEY IDENTITY NOT NULL,
	personal_id INT NOT NULL,
	department_id INT REFERENCES Departments(department_id),
	first_name NVARCHAR(50) NOT NULL,
	last_name NVARCHAR(50) NOT NULL,
	country NVARCHAR(50) NOT NULL,
	dob DATE NOT NULL,
	gender NVARCHAR(50) NOT NULL,
	[address] NVARCHAR(150) NOT NULL,
	phone NVARCHAR(15) NOT NULL,
    email NVARCHAR(50) NOT NULL
)
GO

-- Tabe (Payroll) [Need more work for this table]

CREATE TABLE Payroll
(
    payroll_id INT PRIMARY KEY IDENTITY NOT NULL,
	employee_id INT REFERENCES Employee(employee_id),
	basic_salary DECIMAL NOT NULL,
	bonus_salary DECIMAL NOT NULL,
	compenstation DECIMAL NOT NULL,
	account_no INT NOT NULL,
	net_salary DECIMAL NOT NULL -- Calculated Field
)
GO

-- The Final Table (Bill) [All Field of the table are calculated]

CREATE TABLE Bill
(
    bill_id INT PRIMARY KEY IDENTITY NOT NULL,
    patient_id INT REFERENCES Patient(patient_id),
    doc_charge DECIMAL,
    med_charge DECIMAL,
    room_charge DECIMAL,
    operation_charge DECIMAL,
    nursing_charge DECIMAL,
    lab_charge DECIMAL,
    advance DECIMAL NULL
)
GO