using senai_CZBooks_webApi.Domains;
using senai_CZBooks_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Repositories
{
    /// <summary>
    /// Instância a classe generoRepository
    /// herda a interface
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// Faz a atualização de um gênero
        /// </summary>
        /// <param name="generoAtualizado">nomenclatura para atualização</param>
        /// <param name="id">identificador</param>
        public void Atualizar(Genero generoAtualizado, int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Faz a busca de um gênero pelo id
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>O gênero procurado</returns>
        public Genero BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz o cadastro de um gênero 
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="novoGenero">nomenclatura do cadastro </param>
        public void Cadastar(int id, Genero novoGenero)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Faz a exclusão de um gênero
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Faz a listagem de um gênero
        /// </summary>
        /// <returns>A lista com os gêneros</returns>
        public List<Genero> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
