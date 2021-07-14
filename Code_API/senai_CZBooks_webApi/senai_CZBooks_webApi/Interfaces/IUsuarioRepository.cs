using senai_CZBooks_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Faz o cadastro de um novo usuário
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <param name="novoUsuario">Usuário cadastrado</param>
        void Cadastrar(int id, Usuario novoUsuario);


        /// <summary>
        /// Faz a exclusão de um usuário
        /// </summary>
        /// <param name="id">Identificador</param>
        void Deletar(int id);

        /// <summary>
        /// Faz a atualização do email
        /// </summary>
        /// <param name="email">parâmetro a ser atualizado</param>
        /// <param name="usuarioAtualizado">nomenclatura da atualização</param>
        void AtualizarEmail(string email, Usuario usuarioAtualizado);

        /// <summary>
        /// Faz a atualização da senha
        /// </summary>
        /// <param name="senha">Parâmetro a ser atualizado</param>
        /// <param name="usuarioAtualizado">nomenclatura da atualização</param>
        void AtualizarSenha(string senha, Usuario usuarioAtualizado);

        /// <summary>
        /// Faz o login
        /// </summary>
        /// <param name="email">parâmetro para reconhecimento da conta</param>
        /// <param name="senha">parâmetro para conexão com a conta</param>
        /// <returns>Usuário logado</returns>
        Usuario Login(string email, string senha);
    }
}
