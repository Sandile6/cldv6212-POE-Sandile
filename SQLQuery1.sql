﻿CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Email NVARCHAR(256) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(256) NOT NULL,
    DateCreated DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Customers (
    RowKey NVARCHAR(50) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(256) NOT NULL,
    Address NVARCHAR(200) NOT NULL,
    DateCreated DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Images (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(256) NOT NULL,
    ImageData VARBINARY(MAX) NOT NULL,
    DateUploaded DATETIME NOT NULL DEFAULT GETDATE()
);