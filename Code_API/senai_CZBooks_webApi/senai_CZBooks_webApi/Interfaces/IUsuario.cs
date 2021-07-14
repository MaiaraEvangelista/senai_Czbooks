using senai_CZBooks_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Interfaces
{
    interface IUsuario
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
    }
}
