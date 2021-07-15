--dml
USE CZBooks;
GO

INSERT INTO tiposUsuario(tipo)
VALUES         ('Administrador')
			  ,('Autor')
			  ,('Cliente')
GO

INSERT INTO usuario(idTipoUsuario, email, senha)
VALUES			    (3, 'MariaAlmeida@gmail.com', 'maria123')
				   ,(3, 'Alberto@email.com', 'alberto123')
				   ,(2, 'AndressaM@email.com', 'andressa123')
				   ,(1, 'ClaudioSilva@email.com', 'claudio123')
GO

INSERT INTO autor(idUsuario, nomeAutor)
VALUES			   (2, 'Mario Fernandes')
				  ,(2, 'Andressa Matias')
				  ,(2, 'Flora Magalhães')
				  ,(2, 'Sergio Braga')
GO

INSERT INTO instituicao(nomeFantasia, CNPJ, endereco, horarioAbertura, horarioFechamento)
VALUES					 ('DreamBooks', '20.956.021/9457-00', 'R.Colina, 235, Crapicuíba -SP', '08:00', '19:00'  )
				        ,('Viagem em Palavras', '14.215.975/2150-77', 'Av.Inocêncio Seráfico,1630, Carapicuíba - SP', '07:00', '18:40')
						,('Serasa Livros', '98.630.254/0734-44', 'Av.Cerqueira César, 1530, Oscar Freire - SP', '08:00', '19:30')
						,('Andromeda Livros', '78.301.6485/3201-45', 'R.Anderson Duarte, 30, Faria Lima - SP', '10:00', '20:00')
GO

INSERT INTO livro(idAutor, idInstituicao, titulo, autor, categoria, dataPublicacao, sinopse)
VALUES           (2, 3, 'Tudo aquilo que eu não disse', 'Andressa Matias', 'Romance', '12/03/2020', 'Um clássico de vertente literária, que descreve um amor intenso entre um casal separados pela guerra, e pelo preconceito de um pai autoritário.')
				,(4, 2, 'Conhecendo o Universo', 'Sergio Braga', 'Ficção Científica', '05/09/2020', 'A visão de um lugar desconhecido pela maioria que  não se atenta as maravilhas ao seu redor, uma visão através do céu. ')
				,(1, 1, 'Visão do  Paraíso', 'Mario Fernandes', 'Drama', '10/04/2020', 'Após perder a vida olhar sua família através de um mundo onde não se é vista, lhe dói mais seu coração...')
				,(3, 4, 'Noite Sombria', 'Flora Magalhães', 'Terror', '27/01/2021', 'Enquanto a noite cai, um calafrio sobe pela espinha de Emily, a que a faz pensar no que pode estar havendo de errado, já que nada está como a minutos atrás.')
GO

INSERT INTO genero(idLivro, tipo)
VALUES			    (4, 'Terror')
				   ,(1, 'Romance')
				   ,(2, 'Ficção Científica')
				   ,(3, 'Drama')
GO

DROP TABLE genero;
DROP DATABASE CZBooks;
				