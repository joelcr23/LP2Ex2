SET FOREIGN_KEY_CHECKS = 0;
DROP TABLE IF EXISTS ROLE_HISTORY;
DROP TABLE IF EXISTS EMPLOYEE;
DROP TABLE IF EXISTS ROLE;
DROP TABLE IF EXISTS DEPARTMENT;
DROP TABLE IF EXISTS STUDIO;
DROP TABLE IF EXISTS BRAND;
DROP TABLE IF EXISTS LOCATION;
DROP TABLE IF EXISTS COUNTRY;
DROP TABLE IF EXISTS REGION;
DROP TABLE IF EXISTS ACTIVITY;
DROP TABLE IF EXISTS GAME;
DROP TABLE IF EXISTS CONTENT_CLASS_SYSTEM;
DROP TABLE IF EXISTS GAME_MODE;
DROP TABLE IF EXISTS GENRE;
DROP TABLE IF EXISTS PLATFORM;
DROP TABLE IF EXISTS MONEY;
DROP TABLE IF EXISTS PARTICIPANT;
DROP TABLE IF EXISTS TIME;
DROP TABLE IF EXISTS RESOURCE;
DROP TABLE IF EXISTS WORK_UNIT;
DROP TABLE IF EXISTS TYPE_WORK_UNIT;
DROP TABLE IF EXISTS PHASE_PROJECT;
DROP TABLE IF EXISTS PHASE;
DROP TABLE IF EXISTS PROJECT;
SET FOREIGN_KEY_CHECKS = 1;
DROP PROCEDURE IF EXISTS INSERT_PARTICIPANT;
DROP PROCEDURE IF EXISTS INSERT_MONEY;
DROP PROCEDURE IF EXISTS INSERT_TYPE_WORK_UNIT;
DROP PROCEDURE IF EXISTS INSERT_WORK_UNIT;
DROP PROCEDURE IF EXISTS INSERT_TIME;
DROP PROCEDURE IF EXISTS INSERT_PHASE;
DROP PROCEDURE IF EXISTS INSERT_PROJECT;
DROP PROCEDURE IF EXISTS INSERT_PHASE_PROJECT;
DROP PROCEDURE IF EXISTS INSERT_GAME;
DROP PROCEDURE IF EXISTS LIST_PROJECTS;
DROP PROCEDURE IF EXISTS INSERT_GAME;
DROP PROCEDURE IF EXISTS QUERY_ALL_PROJECTS;
DROP PROCEDURE IF EXISTS UPDATE_PROJECT;
DROP PROCEDURE IF EXISTS QUERY_PROJECT_BY_ID;
DROP PROCEDURE IF EXISTS INSERT_PROJECT;
DROP PROCEDURE IF EXISTS INSERT_PHASE_PROJECT;
DROP PROCEDURE IF EXISTS QUERY_PHASE_PROJECTS_BY_ID_PROJECT;
DROP PROCEDURE IF EXISTS ADD_TIME_RESOURCE_TO_TASK;
DROP PROCEDURE IF EXISTS ADD_MONEY_RESOURCE_TO_TASK;
DROP PROCEDURE IF EXISTS ADD_PARTICIPANT_RESOURCE_TO_TASK;
DROP PROCEDURE IF EXISTS REMOVE_PARTICIPANT_RESOURCE_FROM_TASK;
DROP PROCEDURE IF EXISTS QUERY_ACTIVITIES_BY_ID_PHASE_PROJECT;
DROP PROCEDURE IF EXISTS QUERY_TASKS_BY_ID_ACTIVITY;
DROP PROCEDURE IF EXISTS QUERY_TIME_RESOURCE_BY_ID_TASK;
DROP PROCEDURE IF EXISTS QUERY_MONEY_RESOURCE_BY_ID_TASK;
DROP PROCEDURE IF EXISTS QUERY_PARTICIPANT_RESOURCE_BY_ID_TASK;
DROP PROCEDURE IF EXISTS REMOVE_RESOURCES_FROM_TASK;
DROP PROCEDURE IF EXISTS QUERY_EMPLOYEES_BY_DEPARTMENT_ID;
DROP PROCEDURE IF EXISTS QUERY_DEPARTMENTS;
DROP PROCEDURE IF EXISTS QUERY_ROLE_HISTORY_BY_EMPLOYEE;

CREATE TABLE REGION (
 	ID_REGION INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	NAME VARCHAR(50) NULL
);

INSERT INTO REGION (name) VALUES('AFRICA');
INSERT INTO REGION (name) VALUES('ASIA');
INSERT INTO REGION (name) VALUES('CARIBBEAN');
INSERT INTO REGION (name) VALUES('CENTRAL AMERICA');
INSERT INTO REGION (name) VALUES('EUROPE');
INSERT INTO REGION (name) VALUES('NORTH AMERICA');
INSERT INTO REGION (name) VALUES('OCEANIA');
INSERT INTO REGION (name) VALUES('SOUTH AMERICA');

CREATE TABLE COUNTRY (
	ID_COUNTRY INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	FID_REGION INT NOT NULL,  
	NAME VARCHAR(50) NULL
);

INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (5, 'ABKHAZIA');
INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (2, 'AFGHANISTAN');
INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (5, 'ALBANIA');
INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (8, 'ARGENTINA');
INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (7, 'AUSTRALIA');
INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (8, 'BRAZIL');
INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (6, 'CANADA');
INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (8, 'CHILE');
INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (5, 'FRANCE');
INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (8, 'PERU');
INSERT INTO COUNTRY (FID_REGION, NAME) VALUES (6, 'UNITED STATES OF AMERICA');

CREATE TABLE LOCATION (
	ID_LOCATION INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	FID_COUNTRY INT NOT NULL,
	ADDRESS VARCHAR(100) NULL,  
	CITY VARCHAR(50) NULL,
	POSTAL_CODE VARCHAR(8) NULL,
	PROVINCE VARCHAR(50) NULL
);

INSERT INTO LOCATION (FID_COUNTRY, CITY, PROVINCE, POSTAL_CODE, ADDRESS) 
VALUES (10, 'LIMA', 'LIMA', '15088', 'Av. Universitaria 1801');

CREATE TABLE BRAND (
	ID_BRAND INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	FID_LOCATION INT NOT NULL,  
	NAME VARCHAR(50) NULL
);

INSERT INTO BRAND (FID_LOCATION, NAME) VALUES (1, 'EA SPORTS');

CREATE TABLE STUDIO (
	ID_STUDIO INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	FID_BRAND INT NOT NULL,	
	NAME VARCHAR(50) NULL
);

INSERT INTO STUDIO (FID_BRAND, NAME) VALUES (1, 'EA SPORTS PERU');

CREATE TABLE DEPARTMENT (
	ID_DEPARTMENT INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	FID_HEAD_DEPARTMENT INT NULL,
    FID_STUDIO INT NOT NULL,
	NAME VARCHAR(50) NULL,
    FOREIGN KEY (FID_HEAD_DEPARTMENT) REFERENCES DEPARTMENT(ID_DEPARTMENT)
);

INSERT INTO DEPARTMENT (FID_STUDIO, NAME) VALUES (1, 'RR.HH.');
INSERT INTO DEPARTMENT (FID_STUDIO, NAME) VALUES (1, 'DEVELOPMENT');
INSERT INTO DEPARTMENT (FID_STUDIO, NAME, FID_HEAD_DEPARTMENT) VALUES (1, 'PROGRAMMING', 2);
INSERT INTO DEPARTMENT (FID_STUDIO, NAME, FID_HEAD_DEPARTMENT) VALUES (1, 'ART', 2);

CREATE TABLE ROLE (
	ID_ROLE INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	NAME VARCHAR(50) NULL,
	MIN_SALARY DECIMAL(10,2) NULL,
	MAX_SALARY DECIMAL(10,2) NULL
);

INSERT INTO ROLE (NAME, MIN_SALARY, MAX_SALARY) VALUES ('MANAGER', 10000, 20000);
INSERT INTO ROLE (NAME, MIN_SALARY, MAX_SALARY) VALUES ('ASSISTANT', 2000, 6000);
INSERT INTO ROLE (NAME, MIN_SALARY, MAX_SALARY) VALUES ('ARTIST SENNIOR', 4000, 10000);
INSERT INTO ROLE (NAME, MIN_SALARY, MAX_SALARY) VALUES ('ARTIST JUNIOR', 2000, 4000);
INSERT INTO ROLE (NAME, MIN_SALARY, MAX_SALARY) VALUES ('PROGRAMMER SENNIOR', 4000, 20000);
INSERT INTO ROLE (NAME, MIN_SALARY, MAX_SALARY) VALUES ('PROGRAMMER JUNIOR', 2000, 4000);

CREATE TABLE EMPLOYEE (
	ID_EMPLOYEE INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    FID_HEAD_EMPLOYEE INT NULL,
	FID_DEPARTMENT INT NOT NULL,
	FID_ROLE INT NOT NULL,
	NAME VARCHAR(50) NULL,
	LAST_NAME VARCHAR(50) NULL,
	SECOND_LAST_NAME VARCHAR(50) NULL,
	DNI VARCHAR(8) NULL,
	EMAIL VARCHAR(50) NULL,
	BIRTHDAY DATE NULL,
	HIRE_DATE DATE NULL,
	SALARY DECIMAL(10,2) NULL,
	FOREIGN KEY (FID_DEPARTMENT) REFERENCES DEPARTMENT(ID_DEPARTMENT),
    FOREIGN KEY (FID_ROLE) REFERENCES ROLE(ID_ROLE),
    FOREIGN KEY (FID_HEAD_EMPLOYEE) REFERENCES EMPLOYEE(ID_EMPLOYEE)
);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY) 
VALUES(1, 'ZOILA','BACA','MUNGUIA','19281182','zoila.baca@ea.com', 1, '1979-6-03', '2018-6-04', 10000.00);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY,FID_HEAD_EMPLOYEE) 
VALUES(1, 'CINDY','ENTES','BLANCO','8074446A','cindy.entes@ea.com', 2, '1990-6-03', '2018-6-04', 3550.00,1);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY) 
VALUES(2, 'ESTEBAN','QUITO','PERFECTO','29871234','esteban.quito@ea.com', 1, '1980-6-03', '2018-6-03', 15000);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY,FID_HEAD_EMPLOYEE) 
VALUES(2, 'ARMANDO','PUERTAS','ROSADO','12098011','armando.puertas@ea.com', 5, '1986-6-03', '2018-7-03', 10000,3);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY,FID_HEAD_EMPLOYEE) 
VALUES(2, 'ELTON','TITO','SABROSO','12761991','elton.tito@ea.com', 3, '1985-6-03', '2018-8-03', 8000,3);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY,FID_HEAD_EMPLOYEE) 
VALUES(2, 'HECTOR','TUGA','DIAZ','48720928','hector.tuga@ea.com', 6, '1994-6-03', '2018-9-03', 3000,3);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY,FID_HEAD_EMPLOYEE) 
VALUES(2, 'SUSANA','ORIA','VIOLETA','12870002','susana.oria@ea.com', 4, '1996-6-03', '2018-10-03', 3000,3);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY,FID_HEAD_EMPLOYEE) 
VALUES(2, 'DANIELA','VILLANUEVA','BENDEZU','29871120','dvillanuevab@ea.com', 6, '1988-1-01', '2018-8-03', 2900,4);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY) 
VALUES(1, 'MARIA','QUISPE','AGUILAR','2280213','m.quispea@ea.com', 2, '1965-1-01', '2018-3-03', 10000.00);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY) 
VALUES(3, 'JORGE','ESPINOZA','MOQUILLAZA','11980921','jespinozam@ea.com', 5, '1955-11-15', '2018-3-15', 15700.00);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY,FID_HEAD_EMPLOYEE) 
VALUES(3, 'HUGO','ALCANTARA','SANCHEZ','1721109','halcantara@ea.com', 6, '1988-10-19', '2018-5-28', 3700,10);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY,FID_HEAD_EMPLOYEE) 
VALUES(3, 'LOURDES','MONTALVO','VALDIVIA','76577009','lmontalvo@ea.com', 6, '1991-01-18', '2018-4-9', 1100,11);

INSERT INTO EMPLOYEE(FID_DEPARTMENT, NAME, LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, FID_ROLE, BIRTHDAY, HIRE_DATE, SALARY) 
VALUES(4, 'MANUEL','CACERES','HERNANDEZ','43299867','mcaceres@ea.com', 5, '1990-09-09', '2018-5-4', 16670.00);

DELIMITER $
DROP PROCEDURE IF EXISTS LIST_DEPARTMENTS$
CREATE PROCEDURE LIST_DEPARTMENTS()
BEGIN
	SELECT ID_DEPARTMENT, FID_HEAD_DEPARTMENT, FID_STUDIO, NAME FROM DEPARTMENT WHERE FID_HEAD_DEPARTMENT is null;
END$
DROP PROCEDURE IF EXISTS LIST_DEPARTMENTS_DEPENDENT$
CREATE PROCEDURE LIST_DEPARTMENTS_DEPENDENT(
	IN _ID_DEPARTMENT INT
)
BEGIN
	SELECT ID_DEPARTMENT, FID_HEAD_DEPARTMENT, FID_STUDIO, NAME FROM DEPARTMENT WHERE FID_HEAD_DEPARTMENT = _ID_DEPARTMENT;
END$
DROP PROCEDURE IF EXISTS LIST_EMPLOYEES_INDEPENDENT$
CREATE PROCEDURE LIST_EMPLOYEES_INDEPENDENT(
	IN _ID_DEPARTMENT INT
)
BEGIN
	SELECT ID_EMPLOYEE, DEPARTMENT.ID_DEPARTMENT, DEPARTMENT.NAME AS DEPARTMENT_NAME, ROLE.NAME AS ROLE_NAME, EMPLOYEE.NAME, 
    LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, BIRTHDAY, EMAIL, SALARY, FID_HEAD_EMPLOYEE FROM EMPLOYEE INNER JOIN ROLE ON ROLE.ID_ROLE = EMPLOYEE.FID_ROLE INNER JOIN DEPARTMENT ON DEPARTMENT.ID_DEPARTMENT = EMPLOYEE.FID_DEPARTMENT WHERE FID_HEAD_EMPLOYEE is null AND EMPLOYEE.FID_DEPARTMENT = _ID_DEPARTMENT;
END$
DROP PROCEDURE IF EXISTS LIST_EMPLOYEES_DEPENDENT$
CREATE PROCEDURE LIST_EMPLOYEES_DEPENDENT(
	IN _ID_EMPLOYEE INT
)
BEGIN
	SELECT ID_EMPLOYEE, DEPARTMENT.ID_DEPARTMENT, DEPARTMENT.NAME AS DEPARTMENT_NAME, ROLE.NAME AS ROLE_NAME, EMPLOYEE.NAME, 
    LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, BIRTHDAY, EMAIL, SALARY, FID_HEAD_EMPLOYEE FROM EMPLOYEE INNER JOIN ROLE ON ROLE.ID_ROLE = EMPLOYEE.FID_ROLE INNER JOIN DEPARTMENT ON DEPARTMENT.ID_DEPARTMENT = EMPLOYEE.FID_DEPARTMENT WHERE FID_HEAD_EMPLOYEE = _ID_EMPLOYEE;
END$
DROP PROCEDURE IF EXISTS LIST_EMPLOYEE_BY_ID$
CREATE PROCEDURE LIST_EMPLOYEE_BY_ID(
	IN _ID_EMPLOYEE INT
)
BEGIN
	SELECT ID_EMPLOYEE, DEPARTMENT.ID_DEPARTMENT, DEPARTMENT.NAME AS DEPARTMENT_NAME, ROLE.NAME AS ROLE_NAME, EMPLOYEE.NAME, 
    LAST_NAME, SECOND_LAST_NAME, DNI, EMAIL, BIRTHDAY, EMAIL, SALARY, FID_HEAD_EMPLOYEE FROM EMPLOYEE INNER JOIN ROLE ON ROLE.ID_ROLE = EMPLOYEE.FID_ROLE INNER JOIN DEPARTMENT ON DEPARTMENT.ID_DEPARTMENT = EMPLOYEE.FID_DEPARTMENT WHERE ID_EMPLOYEE = _ID_EMPLOYEE;
END$