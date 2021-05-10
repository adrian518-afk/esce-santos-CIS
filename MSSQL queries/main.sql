USE CitizenDB;
--CREATE TABLES
CREATE TABLE RefTblCitizen(
id int PRIMARY KEY IDENTITY(1,1),
first_name varchar(100),
last_name varchar(100),
province varchar(100),
birthdate date,
age int,
email varchar(100),
citizen_is_deleted int
);

DROP TABLE RefTblCitizen;