using senai_CZBooks_webApi.Domains;
using senai_CZBooks_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Repositories
{
    /// <summary>
    /// Instância a classe tipoUsuarioRepository
    /// herda a interface
    /// </summary>
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
     /// <summary>
     /// Faz a busca pelo id
     /// </summary>
     /// <param name="id">identificador</param>
     /// <returns>retorna o tipo de usuário</returns>
        public TiposUsuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz o cadastro de um tipo de usuário
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="tipoUsuarioCadastrado">nomenclatura para o usuário cadasrtrado</param>
        public void Cadastrar(int id, TiposUsuario tipoUsuarioCadastrado)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a exclusão do tipo de usuário
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// faz a listagem dos tipos de usuários
        /// </summary>
        /// <returns>Retorna uma lista de tipos de usuários</returns>
        public List<TiposUsuario> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
