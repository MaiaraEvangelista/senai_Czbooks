using senai_CZBooks_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Interfaces
{
    interface ITipoUsuario
    {
        /// <summary>
        /// Faz a listagem de todos os tipos de usuários
        /// </summary>
        /// <returns>Uma lista de usuários</returns>
        List<TiposUsuario> ListarTodos();


        /// <summary>
        /// Faz a busca de um tipo de usuário pelo id
        /// </summary>
        /// <returns></returns>
        TiposUsuario BuscarPorId();


        /// <summary>
        /// Faz o cadastramento de umtipo de usuário
        /// </summary>
        /// <param name="id">Identificador do tipo de usuário</param>
        /// <param name="tipoUsuarioCadastrado">Nomenclatura para o cadastro</param>
        void Cadastrar(int id, TiposUsuario tipoUsuarioCadastrado);


        /// <summary>
        /// Faz a exclusão de um tipo de usuário
        /// </summary>
        /// <param name="id">Identificador</param>
        void Deletar(int id);
    }
}
