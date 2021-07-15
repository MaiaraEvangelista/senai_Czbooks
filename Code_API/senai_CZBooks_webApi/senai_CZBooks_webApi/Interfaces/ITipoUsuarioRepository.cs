using senai_CZBooks_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Interfaces
{
    interface ITipoUsuarioRepository
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
        TiposUsuario BuscarPorId(int id);


        /// <summary>
        /// Faz o cadastramento de umtipo de usuário
        /// </summary>
        /// <param name="id">Identificador do tipo de usuário</param>
        /// <param name="tipoUsuarioCadastrado">Nomenclatura para o cadastro</param>
        void Cadastrar( TiposUsuario tipoUsuarioCadastrado);


        /// <summary>
        /// Faz a exclusão de um tipo de usuário
        /// </summary>
        /// <param name="id">Identificador</param>
        void Deletar(int id);


        /// <summary>
        /// Faz a atualização 
        /// </summary>
        /// <param name="id">identificador </param>
        /// <param name="tipoUsuarioAtualizado">O tipo usuário que foi atualizado</param>
        void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado);
    }
}
