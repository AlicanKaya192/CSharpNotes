--create database DbExamStudent
--use DbExamStudent

--create table Student
--(
--ID int IDENTITY(1,1) PRIMARY KEY,
--NAME varchar(20),
--SURNAMAE varchar(20),
--PHOTO varchar(100)
--)

--create table Lectures
--(
--LectureID int IDENTITY(1,1) PRIMARY KEY,
--LectureName varchar(50)
--)

--create table Notes
--(
--NoteID int IDENTITY(1,1) PRIMARY KEY,
--StudentID int,
--Lecture int,
--Exam1 smallint,
--Exam2 smallint,
--Exam3 smallint,
--Average decimal(5,2),
--Status bit
--)

--create table CLUB
--(
--CLUBID tinyint IDENTITY(1,1) PRIMARY KEY,
--CLUBNAME varchar(50)
--)

--CREATE PROCEDURE NoteList
--AS
--SELECT NoteID, NAME + ' ' + SURNAME AS 'Student', LectureName, EXAM1, EXAM2, EXAM3, Average, Status FROM Notes
--INNER JOIN Student ON Notes.StudentID=Student.ID
--INNER JOIN Lectures ON Notes.Lecture=Lectures.LectureID

--EXEC NoteList