-- Crear la base de datos
CREATE DATABASE EventsManagement;
GO

-- Usar la base de datos recién creada
USE EventsManagement;
GO

-- Crear la tabla User
CREATE TABLE Userr (
    Userr_ID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Passwordd NVARCHAR(50) NOT NULL,
	Creation_Date DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Crear la tabla Login
CREATE TABLE Login (
    Login_ID INT IDENTITY(1,1) PRIMARY KEY,
    Userr_ID INT NOT NULL,
    Creation_Date DATETIME NOT NULL DEFAULT GETDATE()
    FOREIGN KEY (Userr_ID) REFERENCES Userr(Userr_ID)
);
GO

-- Crear la tabla Event
CREATE TABLE Eventt (
    Event_ID INT IDENTITY(1,1) PRIMARY KEY,
    Userr_ID INT NOT NULL,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Event_Date DATETIME NOT NULL,
    Creation_Date DATETIME NOT NULL DEFAULT GETDATE()
    FOREIGN KEY (Userr_ID) REFERENCES Userr(Userr_ID)
);
GO

-- Crear la tabla Genre
CREATE TABLE Genre (
    Genre_ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
	Creation_Date DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Crear la tabla Band
CREATE TABLE Band (
    Band_ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Genre_ID INT NOT NULL,
    Creation_Date DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (Genre_ID) REFERENCES Genre(Genre_ID)
);
GO

-- Crear la tabla Presentation
CREATE TABLE Presentation (
    Presentation_ID INT IDENTITY(1,1) PRIMARY KEY,
    Event_ID INT NOT NULL,
    Band_ID INT NOT NULL,
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NOT NULL,
	Creation_Date DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (Event_ID) REFERENCES Eventt(Event_ID),
    FOREIGN KEY (Band_ID) REFERENCES Band(Band_ID)
);
GO

INSERT INTO Genre (Name) VALUES ('Country'),('Folk'),('Clasic Rock'),('Pop'),('R&B'),('Electronic')

INSERT INTO Userr (Username, Passwordd) VALUES ('Joslui17','User1'),('Andlv23','User2')