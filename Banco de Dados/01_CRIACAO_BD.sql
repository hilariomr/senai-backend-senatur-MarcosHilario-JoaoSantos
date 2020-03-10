 CREATE DATABASE Senatur_Tarde;

 USE Senatur_Tarde;

 CREATE TABLE Pacotes (
	IdPacote		INT PRIMARY KEY IDENTITY,
	NomePacote		VARCHAR(200),
	Descricao		VARCHAR(2000),
	DataIda			DATE,
	DataVolta		DATE,
	Valor			MONEY,
	Ativo			BIT NOT NULL,
	NomeCidade		VARCHAR(200)
);

CREATE TABLE TipoUsuario (
	IdTipoUsuario		INT PRIMARY KEY IDENTITY,
	Titulo				VARCHAR(200) NOT NULL UNIQUE				
);

CREATE TABLE Usuarios (
	IdUsuario		INT PRIMARY KEY IDENTITY,
	Email			VARCHAR(200) NOT NULL UNIQUE,
	Senha			VARCHAR(100) NOT NULL,
	IdTipoUsuario	INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario)
);




