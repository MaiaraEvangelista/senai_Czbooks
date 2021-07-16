using senai_CZBooks_webApi.Contexts;
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
        //Faz a instância do context que possui conexão com o banco de dados
        CZBooksContext ctx = new CZBooksContext();

        /// <summary>
        /// Faz a atualização do email
        /// </summary>
        /// <param name="email">Conta atualizada</param>
        /// <param name="usuarioAtualizado">nomenclatura de atualização</param>
        public void AtualizarEmail(string email, Usuario usuarioAtualizado)
        {
            //Faz a busca pelo identificador do usuário
            Usuario usuarioBuscado = ctx.Usuarios.Find(email);

            //Faz a verificação para ver se é diferente de nulo
            if(usuarioAtualizado.Email != null) 
            {
                //Atribui os valores procurado, e indica onde será armazenado
                usuarioBuscado.Email = usuarioAtualizado.Email;
            }

            //Faz a atualização do que foi buscado
            ctx.Usuarios.Update(usuarioBuscado);
            //Salva as alterações
            ctx.SaveChanges();
        }

        /// <summary>
        /// Faz a atualização de senha
        /// </summary>
        /// <param name="senha">Conexão atualizada</param>
        /// <param name="usuarioAtualizado">nomenclatura para a atualização</param>
        public void AtualizarSenha(string senha, Usuario usuarioAtualizado)
        {
            //Faz a busca pelo identificador do usuário
            Usuario usuarioBuscado = ctx.Usuarios.Find(senha);

            //Faz a verificaçaõ para ver s eé diferente de nulo
            if(usuarioAtualizado.Senha != null) 
            {
                //Atribui os valores, e indica onde será armazenado
                usuarioBuscado.Senha = usuarioAtualizado.Senha;
            }
            //Faz a atualização 
            ctx.Usuarios.Update(usuarioBuscado);

            //Salva as alterações
            ctx.SaveChanges();
        }


        /// <summary>
        /// Faz um cadastro de usuário
        /// </summary>
        /// <param name="novoUsuario">nomenclatura para atualização</param>
        public void Cadastrar( Usuario novoUsuario)
        {
            //Executa o método de cadastro
            ctx.Usuarios.Add(novoUsuario);

            //Salva as alterações feitas
            ctx.SaveChanges();
        }

        /// <summary>
        /// Faz a exclusão de um usuário
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            //Faz a execução do método
            ctx.Usuarios.Remove(BuscarPorId(id));

            //Salva as alterações
            ctx.SaveChanges();
        }

        /// <summary>
        /// Faz o login
        /// </summary>
        /// <param name="email">via de conexão</param>
        /// <param name="senha">via de acesso</param>
        /// <returns>o usuário logado</returns>
        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        /// <summary>
        /// Faz a busca pelo identficador
        /// </summary>
        /// <param name="id">identificador</param>
        public Usuario BuscarPorId(int id) 
        {
            //Faz a busca pelo identificador
            return ctx.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }
    }
}
