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
				  ,(2, 'Flora Magalh�es')
				  ,(2, 'Sergio Braga')
GO

INSERT INTO instituicao(nomeFantasia, CNPJ, endereco, horarioAbertura, horarioFechamento)
VALUES					 ('DreamBooks', '20.956.021/9457-00', 'R.Colina, 235, Crapicu�ba -SP', '08:00', '19:00'  )
				        ,('Viagem em Palavras', '14.215.975/2150-77', 'Av.Inoc�ncio Ser�fico,1630, Carapicu�ba - SP', '07:00', '18:40')
						,('Serasa Livros', '98.630.254/0734-44', 'Av.Cerqueira C�sar, 1530, Oscar Freire - SP', '08:00', '19:30')
						,('Andromeda Livros', '78.301.6485/3201-45', 'R.Anderson Duarte, 30, Faria Lima - SP', '10:00', '20:00')
GO

INSERT INTO livro(idAutor, idInstituicao, titulo, autor, categoria, dataPublicacao, sinopse)
VALUES           (2, 3, 'Tudo aquilo que eu n�o disse', 'Andressa Matias', 'Romance', '12/03/2020', 'Um cl�ssico de vertente liter�ria, que descreve um amor intenso entre um casal separados pela guerra, e pelo preconceito de um pai autorit�rio.')
				,(4, 2, 'Conhecendo o Universo', 'Sergio Braga', 'Fic��o Cient�fica', '05/09/2020', 'A vis�o de um lugar desconhecido pela maioria que  n�o se atenta as maravilhas ao seu redor, uma vis�o atrav�s do c�u. ')
				,(1, 1, 'Vis�o do  Para�so', 'Mario Fernandes', 'Drama', '10/04/2020', 'Ap�s perder a vida olhar sua fam�lia atrav�s de um mundo onde n�o se � vista, lhe d�i mais seu cora��o...')
				,(3, 4, 'Noite Sombria', 'Flora Magalh�es', 'Terror', '27/01/2021', 'Enquanto a noite cai, um calafrio sobe pela espinha de Emily, a que a faz pensar no que pode estar havendo de errado, j� que nada est� como a minutos atr�s.')
GO

INSERT INTO genero(idLivro, tipo)
VALUES			    (4, 'Terror')
				   ,(1, 'Romance')
				   ,(2, 'Fic��o Cient�fica')
				   ,(3, 'Drama')
GO

DROP TABLE genero;
DROP DATABASE CZBooks;
				