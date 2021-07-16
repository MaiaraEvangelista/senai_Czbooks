using senai_CZBooks_webApi.Contexts;
using senai_CZBooks_webApi.Domains;
using senai_CZBooks_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Repositories
{
    /// <summary>
    /// Instância a classe livroRepository
    /// herda a interface
    /// </summary>
    public class LivroRepository : ILivroRepository
    {

        //Faz instância da context para ter conexão com o Banco de dados
        CZBooksContext ctx = new CZBooksContext();


        /// <summary>
        /// Faz a atualização de um livro
        /// </summary>
        /// <param name="id">identificador do livro</param>
        /// <param name="livroAtualizado">nomenclatura para a atualização</param>
        public void Atualizar(int id, Livro livroAtualizado)
        {
            //Instância o livro buscado e procura pelo id
            Livro livroBuscado = ctx.Livros.Find(id);

            if(livroAtualizado.Autor != null) 
            {
                livroBuscado.Autor = livroAtualizado.Autor;
            }

            if(livroAtualizado.Categoria != null) 
            {
                livroBuscado.Categoria = livroAtualizado.Categoria;
            }

            if(livroAtualizado.DataPublicacao != null) 
            {
                livroBuscado.DataPublicacao = livroAtualizado.DataPublicacao;
            }

            if(livroAtualizado.Titulo != null) 
            {
                livroBuscado.Titulo = livroAtualizado.Titulo;
            }

            if(livroAtualizado.Sinopse != null) 
            {
                livroBuscado.Sinopse = livroAtualizado.Sinopse;
            }
        }

        /// <summary>
        /// Faz a busca pelo id
        /// </summary>
        /// <param name="id">identificador </param>
        /// <returns>O livro encontrado através do id</returns>
        public Livro BuscarPorId(int id)
        {
            //Faz a busca pelo id e devolve a resposta
            return ctx.Livros.FirstOrDefault(l => l.IdLivro == id);    
        }

        /// <summary>
        /// Faz o cadastro de um livro
        /// </summary>
        /// <param name="novoLivro">nomenclatura do cadastro</param>
        public void Cadastrar(Livro novoLivro)
        {
            //Faz o cadastro de um novo livro
            ctx.Livros.Add(novoLivro);

            //Salva as alterações
            ctx.SaveChanges();
        }

        /// <summary>
        /// Faz a exclusão de um livro
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            //Faz a execução do método de exclusão
            ctx.Livros.Remove(BuscarPorId(id));

            //Salva as alterações
            ctx.SaveChanges();
        }

        /// <summary>
        /// Faz a listagem dos livros
        /// </summary>
        /// <returns>Uma lista com as informações do livro</returns>
        public List<Livro> ListarTodos()
        {
            //Faz o retorno da lista
            return ctx.Livros.ToList();
        }
    }
}
