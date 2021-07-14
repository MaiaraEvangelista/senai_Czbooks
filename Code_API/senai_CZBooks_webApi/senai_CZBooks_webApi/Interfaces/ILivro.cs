using senai_CZBooks_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Interfaces
{
    //Inicia os métodos da interface Livro
    interface ILivro
    {

        /// <summary>
        /// Faz a listagem de todos os livros
        /// </summary>
        /// <returns>Uma lista</returns>
        List<Livro> ListarTodos();


        /// <summary>
        /// Faz a busca de todos os livros por id
        /// </summary>
        /// <returns>O indice procurado</returns>
        Livro BuscarPorId();

        /// <summary>
        /// Faz o cadastro de um novo livro
        /// </summary>
        /// <param name="novoLivro">O livro que foi cadastrado</param>
        void Cadastrar(Livro novoLivro);

        /// <summary>
        /// Faz a atualização dos livros
        /// </summary>
        /// <param name="id">identificador do livro</param>
        /// <param name="livroAtualizado">O livro que foi atualizado</param>
        void Atualizar(int id, Livro livroAtualizado);


        /// <summary>
        /// Faz a exclusão de um livro
        /// </summary>
        /// <param name="id">identificador</param>
        void Deletar(int id);
    }
}
