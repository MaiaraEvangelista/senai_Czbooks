using senai_CZBooks_webApi.Contexts;
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
        //Faz instância da context para ter conexão com o Banco de dados
        CZBooksContext ctx = new CZBooksContext();


        public void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado) 
        {
            TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuarios.Find(id);

            if(tipoUsuarioAtualizado.Tipo != null ) 
            {
                tipoUsuarioBuscado.Tipo = tipoUsuarioAtualizado.Tipo;
            }
        }

        /// <summary>
        /// Faz a busca pelo id
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>retorna o tipo de usuário</returns>
        public TiposUsuario BuscarPorId(int id)
        {
            //Faz a busca pelo identificador
            return ctx.TiposUsuarios.FirstOrDefault(t => t.IdTipoUsuario == id);
        }

        /// <summary>
        /// Faz o cadastro de um tipo de usuário
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="tipoUsuarioCadastrado">nomenclatura para o usuário cadasrtrado</param>
        public void Cadastrar(TiposUsuario tipoUsuarioCadastrado)
        {
            //Executa o método de cadastro, atribui a nomenclatura de cadastro
            ctx.TiposUsuarios.Add(tipoUsuarioCadastrado);

            //Salva as alterações
            ctx.SaveChanges();
        }

        /// <summary>
        /// Faz a exclusão do tipo de usuário
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            //Faz a execução de exclusão
            ctx.TiposUsuarios.Remove(BuscarPorId(id));

            //Salva as alterações
            ctx.SaveChanges();
        }

        /// <summary>
        /// faz a listagem dos tipos de usuários
        /// </summary>
        /// <returns>Retorna uma lista de tipos de usuários</returns>
        public List<TiposUsuario> ListarTodos()
        {
            //Faz o retorno de uma lista com suas informações
            return ctx.TiposUsuarios.ToList();
        }
    }
}
