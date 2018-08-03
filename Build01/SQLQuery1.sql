--Script to create DB,Table and sample Insert data   
USE MASTER;   
-- 1) Check for the Database Exists .If the database is exist then drop and create new DB   
IF EXISTS (SELECT [name] FROM sys.databases WHERE [name] = 'mvcProjectDB' )   
BEGIN   
ALTER DATABASE mvcProjectDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE   
DROP DATABASE mvcProjectDB ;   
END     
   
CREATE DATABASE mvcProjectDB   
GO   
   
USE mvcProjectDB  