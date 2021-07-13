--ddl
CREATE DATABASE CZBooks;
GO

USE CZBooks;
GO

CREATE TABLE tiposUsuario 
(
	idTipoUsuario	INT PRIMARY KEY IDENTITY
	,tipo			VARCHAR(200) NOT NULL
);
GO

CREATE TABLE usuario
(
	idUsuario INT PRIMARY KEY IDENTITY
	,idTipoUsuario	INT FOREIGN KEY REFERENCES tiposUsuario(idTipoUsuario)
	,email VARCHAR (200) UNIQUE NOT NULL
	,senha VARCHAR(200) NOT NULL
);
GO

CREATE TABLE autor
(
	idAutor INT PRIMARY KEY IDENTITY 
	,idUsuario INT FOREIGN KEY REFERENCES usuario(idUsuario)
	,nomeAutor VARCHAR(200) NOT NULL
);
GO

CREATE TABLE instituicao
(
	idInstituicao INT PRIMARY KEY IDENTITY
	,nomeFantasia VARCHAR(200) NOT NULL
	,CNPJ VARCHAR(100) NOT NULL
	,endereco VARCHAR (300) NOT NULL
	,horarioAbertura TIME
	,horarioFechamento TIME
);
GO

CREATE TABLE livro
(
	idLivro INT PRIMARY KEY IDENTITY
	,idAutor INT FOREIGN KEY REFERENCES autor(idAutor)
	,idInstituicao INT FOREIGN KEY REFERENCES instituicao(idInstituicao)
	,titulo VARCHAR (200) NOT NULL
	,autor VARCHAR(200) NOT NULL
	,categoria VARCHAR (200) NOT NULL
	,dataPublicacao date 
	,sinopse VARCHAR (500) NOT NULL
);
GO

CREATE TABLE genero
(
	idGenero INT PRIMARY KEY IDENTITY
	,idLivro INT FOREIGN KEY REFERENCES livro(idLivro)
	,tipo VARCHAR (200) NOT NULL
);
GO