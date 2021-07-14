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
        /// <summary>
        /// Faz a atualização de um livro
        /// </summary>
        /// <param name="id">identificador do livro</param>
        /// <param name="livroAtualizado">nomenclatura para a atualização</param>
        public void Atualizar(int id, Livro livroAtualizado)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a busca pelo id
        /// </summary>
        /// <param name="id">identificador </param>
        /// <returns>O livro encontrado através do id</returns>
        public Livro BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz o cadastro de um livro
        /// </summary>
        /// <param name="novoLivro">nomenclatura do cadastro</param>
        public void Cadastrar(Livro novoLivro)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a exclusão de um livro
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a listagem dos livros
        /// </summary>
        /// <returns>Uma lista com as informações do livro</returns>
        public List<Livro> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
