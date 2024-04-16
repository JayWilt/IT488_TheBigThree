
CREATE DATABASE TheBigThreeSupport;

USE TheBigThreeSupport;
CREATE TABLE Service_Ticket (
Ticket_Number int NOT NULL IDENTITY,
Ticket_Date DATE,
Customer_First_Name VARCHAR(25),
Customer_Last_Name VARCHAR(35),
Customer_Email VARCHAR(45),
Customer_Phone CHAR(9),
Service_Tech_ID VARCHAR(20),
Ticket_Status VARCHAR(20),
Ticket_Description VARCHAR(500)
);

USE TheBigThreeSupport;
CREATE TABLE Service_Tech(
Service_Tech_ID VARCHAR(10),
Service_Tech_First_Name VARCHAR(25),
Service_Tech_Last_Name VARCHAR(35),
Service_Tech_Department VARCHAR(20)
);