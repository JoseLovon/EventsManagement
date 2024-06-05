
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
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Creation_Date DATETIME NOT NULL DEFAULT GETDATE()
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

INSERT INTO Userr (Username, Passwordd) VALUES 
('Joslui17','User1'),('Andlv23','User2')

INSERT INTO Position (Name) VALUES 
('Goalkeeper'),('Right Fullback'),
('Left Fullback'),('Center back'),
('Center Midfield'),('Left Midfield/Wing'),
('Right Midfield/Wing'),('Forward')

INSERT INTO Player (Position_ID, Name) VALUES
(8	,'Cristiano Ronaldo'),
(8	,'Luka Modric'),
(5	,'Lionel Messi'),
(6	,'Xabi Alonso'),
(1	,'Carlos Navas'),
(6	,'Kyle Walker'),
(6	,'Alexis Mac Allister'),
(3	,'Frenkie de Jong'),
(4	,'David Alaba'),
(3	,'Neymar Jr.'),
(5	,'Robert Lewandowski')

INSERT INTO Club (Name, Description) VALUES
('Real Madrid FC',	'Spain Club'),
('Bayern Munich',	'German Club'),
('Chelsea',	'English Club'),
('Juventus',	'Italian Club'),
('Arsenal',	'English Club'),
('Manchester City',	'English Club'),
('Liverpool',	'English Club'),
('Betis',	'Spain Club')


