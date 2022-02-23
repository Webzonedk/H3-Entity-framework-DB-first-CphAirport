--Create new Database
USE master;
CREATE DATABASE CphAirport;

--Create tables
USE CphAirport;


CREATE TABLE AirPlane
(
id INT NOT NULL PRIMARY KEY,
flightType VARCHAR (50),
seats INT
);

CREATE TABLE AirLine
(
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
"name" VARCHAR (250) 
);

CREATE TABLE AirPort
(
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
iataCode VARCHAR (3) NOT NULL,
city VARCHAR (250) NOT NULL,
country VARCHAR (250) NOT NULL
)

CREATE TABLE FlightRoute
(
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
departureID INT NOT NULL,
destinationID INT NOT NULL
FOREIGN KEY (departureID) REFERENCES AirPort(id),
FOREIGN KEY (destinationID) REFERENCES AirPort(id)
)

CREATE TABLE FlightPlan
(
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
departtureTime DATETIME NOT NULL,
arrivalTime DATETIME NOT NULL,
operatorID INT NOT NULL,
ownerID INT NOT NULL,
routeID INT NOT NULL,
airPlane INT NOT NULL
FOREIGN KEY (operatorID) REFERENCES AirLine(id),
FOREIGN KEY (ownerID) REFERENCES AirLine(id),
FOREIGN KEY (routeID) REFERENCES FlightRoute(id),
FOREIGN KEY (airPlane) REFERENCES AirPlane(id),
);


--Insert data into tables
INSERT INTO AirPlane(id,flightType,seats)
VALUES(1,'Boing 747',255),(2,'Airbus A319',150),(3,'Boing 737',168),(4,'Airbus 320',180),(5,'Airbus A330-300',396);

INSERT INTO AirLine("name")
VALUES('Air France'), ('British Airways'),('Scandinavian AirShuttle(SAS'),('Finnair');

INSERT INTO AirPort(iataCode,city, country)
VALUES('AAR','Aarhus','Denmark'),('BCN','Barcelona','Spain'),('BSL','Basel','Switzerland'),('SXF','Berlin, Schoenefeld','Germany'),('CPH','Copenhagen','Denmark');

INSERT INTO FlightRoute(departureID, destinationID)
VALUES
((SELECT id FROM AirPort WHERE iataCode='AAR'),(SELECT id FROM AirPort WHERE iataCode='CPH')),
((SELECT id FROM AirPort WHERE iataCode='BCN'),(SELECT id FROM AirPort WHERE iataCode='SXF')),
((SELECT id FROM AirPort WHERE iataCode='BSL'),(SELECT id FROM AirPort WHERE iataCode='BCN')),
((SELECT id FROM AirPort WHERE iataCode='SXF'),(SELECT id FROM AirPort WHERE iataCode='CPH')),
((SELECT id FROM AirPort WHERE iataCode='CPH'),(SELECT id FROM AirPort WHERE iataCode='AAR')),
((SELECT id FROM AirPort WHERE iataCode='CPH'),(SELECT id FROM AirPort WHERE iataCode='SXF')),
((SELECT id FROM AirPort WHERE iataCode='CPH'),(SELECT id FROM AirPort WHERE iataCode='BCN'));

INSERT INTO FlightPlan(departtureTime, arrivalTime, operatorID, ownerID, routeID,airPlane)
VALUES ('02-27-22 12:32','02-27-22 14:32',1,1,1,1),('02-27-22 12:35','02-27-22 17:39',2,3,2,2),
('02-27-22 13:19','02-27-22 19:15',3,4,3,4),('02-27-22 12:35','02-27-22 17:39',4,4,4,5);