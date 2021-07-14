using senai_CZBooks_webApi.Domains;
using senai_CZBooks_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Faz a atualização do email
        /// </summary>
        /// <param name="email">Conta atualizada</param>
        /// <param name="usuarioAtualizado">nomenclatura de atualização</param>
        public void AtualizarEmail(string email, Usuario usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a atualização de senha
        /// </summary>
        /// <param name="senha">Conexão atualizada</param>
        /// <param name="usuarioAtualizado">nomenclatura para a atualização</param>
        public void AtualizarSenha(string senha, Usuario usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz um cadastro de usuário
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="novoUsuario">nomenclatura para atualização</param>
        public void Cadastrar(int id, Usuario novoUsuario)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a exclusão de um usuário
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz o login
        /// </summary>
        /// <param name="email">via de conexão</param>
        /// <param name="senha">via de acesso</param>
        /// <returns>o usuário logado</returns>
        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
