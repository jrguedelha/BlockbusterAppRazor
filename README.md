# BlockbusterAppRazor

Script para criação do Banco do Dados e tabelas:

CREATE DATABASE Blockbuster
GO

USE Blockbuster
GO

CREATE TABLE Movies (
Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Title VARCHAR (50) NOT NULL,
ReleaseDate DATE,
IsActive BIT,
Genre VARCHAR (50)
)
GO

CREATE TABLE Genres (
Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Title VARCHAR (50) NOT NULL,
ReleaseDate DATE,
IsActive BIT,
)
GO




![alt text](https://github.com/jrguedelhaBlockbusterAppRazor/BlockbusterAppRazor/Screens/Main.jpg?raw=true)