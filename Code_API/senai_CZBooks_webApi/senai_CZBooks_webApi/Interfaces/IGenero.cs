using senai_CZBooks_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Interfaces
{
    interface IGenero
    {

        /// <summary>
        /// Faz a listagem de todos os gêneros
        /// </summary>
        /// <returns>Um alista com os gêneros</returns>
        List<Genero> ListarTodos();


        /// <summary>
        /// Faz a busca dos gêneros pelo identificador
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns>O gênero com o id correspondente</returns>
        Genero BuscarPorId(int id);


        /// <summary>
        /// Faz o cadastro de gêneros
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <param name="novoGenero">O gênero cadastrado</param>
        void Cadastar(int id, Genero novoGenero);


        /// <summary>
        /// Faz a atualização dos gêneros
        /// </summary>
        /// <param name="generoAtualizado">O gênero que foi atuzalizado</param>
        /// <param name="id">Identificador</param>
        void Atualizar(Genero generoAtualizado, int id);


        /// <summary>
        /// Faz a exclusão de um gênero
        /// </summary>
        /// <param name="id">Identificador</param>
        void Deletar(int id);
    }
}
