using senai_CZBooks_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Interfaces
{
    interface IAutor
    {
        /// <summary>
        /// Faz a listagem de todos os autores
        /// </summary>
        /// <returns>Um aista completa</returns>
        List<Autor> ListarTodos();


        /// <summary>
        /// Faz a busca de um autor prlo identificador
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>O autor encontrado pelo id passado</returns>
        Autor BuscarPorId(int id);


        /// <summary>
        /// Faz o cadastro de um novo autor
        /// </summary>
        /// <param name="novoAutor">O autor cadastrado</param>
        void Cadastrar(Autor novoAutor);



        /// <summary>
        /// Faz a atualização do autor
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="autorAtualizado">Autor que será atualizado</param>
        void Atualizar(int id, Autor autorAtualizado);


        /// <summary>
        /// Faz a exclusão de um autor
        /// </summary>
        /// <param name="id">identificador do usuário deletado</param>
        void Deletar(int id);
    }
}
