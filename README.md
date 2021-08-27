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
IsActive BIT
)
GO



Telas da Aplicação:
![alt text](https://github.com/jrguedelha/BlockbusterAppRazor/blob/master/BlockbusterAppRazor/Screens/AddMovie.jpg?raw=true)

![alt text](https://github.com/jrguedelha/BlockbusterAppRazor/blob/master/BlockbusterAppRazor/Screens/Movies.jpg)

![alt text](https://github.com/jrguedelha/BlockbusterAppRazor/blob/master/BlockbusterAppRazor/Screens/AddMovie.jpg)

![alt text](https://github.com/jrguedelha/BlockbusterAppRazor/blob/master/BlockbusterAppRazor/Screens/EditMovie.jpg)

![alt text](https://github.com/jrguedelha/BlockbusterAppRazor/blob/master/BlockbusterAppRazor/Screens/Excluir.jpg)