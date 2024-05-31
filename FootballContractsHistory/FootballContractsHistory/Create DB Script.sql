
CREATE DATABASE FootballContractsHistory;
GO


USE FootballContractsHistory;
GO


CREATE TABLE Userr (
    Userr_ID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Passwordd NVARCHAR(50) NOT NULL,
    Creation_Date DATETIME NOT NULL DEFAULT GETDATE()
);
GO


CREATE TABLE Login (
    Login_ID INT IDENTITY(1,1) PRIMARY KEY,
    Userr_ID INT NOT NULL,
    Login_Date DATETIME NOT NULL DEFAULT GETDATE()
    FOREIGN KEY (Userr_ID) REFERENCES Userr(Userr_ID)
);
GO

CREATE TABLE Club (
    Club_ID INT IDENTITY(1,1) PRIMARY KEY,
    Userr_ID INT NOT NULL,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Creation_Date DATETIME NOT NULL DEFAULT GETDATE()
    FOREIGN KEY (Userr_ID) REFERENCES Userr(Userr_ID)
);
GO

CREATE TABLE Position (
    Position_ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
	Creation_Date DATETIME NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE Player (
    Player_ID INT IDENTITY(1,1) PRIMARY KEY,
	Position_ID INT NOT NULL,
    Name NVARCHAR(100) NOT NULL,
    Creation_Date DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (Position_ID) REFERENCES Position(Position_ID)
);
GO

CREATE TABLE Contract (
    Contract_ID INT IDENTITY(1,1) PRIMARY KEY,
    Club_ID INT NOT NULL,
    Player_ID INT NOT NULL,
    Start_Date DATE NOT NULL,
    End_Date DATE NOT NULL,
	Creation_Date DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (Club_ID) REFERENCES Club(Club_ID),
    FOREIGN KEY (Player_ID) REFERENCES Player(Player_ID)
);
GO

INSERT INTO Position (Name) VALUES 
('Goalkeeper'),('Right Fullback'),('Left Fullback'),
('Center back'),('Center Midfield'),('Left Midfield/Wing'),
('Right Midfield/Wing'),('Forward')

INSERT INTO Userr (Username, Passwordd) VALUES ('Joslui17','User1'),('Andlv23','User2')