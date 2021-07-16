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
    /// Instância a classe autor repository
    /// herda a interface
    /// </summary>
    public class AutorRepository : IAutorRepository
    {

        //Faz instância da context para ter conexão com o Banco de dados
        CZBooksContext ctx = new CZBooksContext();

        /// <summary>
        /// Faz a atualização do autor
        /// </summary>
        /// <param name="autorAtualizado">nomenclatura para atualização</param>
        public void Atualizar(Autor autorAtualizado)
        {
            //Faz a atualização de autores
            ctx.Autors.Update(autorAtualizado);

            //Salva as alterações
            ctx.SaveChanges();
        }


        /// <summary>
        /// Faz a busca do autor prlo identificador
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns></returns>
        public Autor BuscarPorId(int id)
        {
            //Faz o retorno da busca pelo identificador
            return ctx.Autors.FirstOrDefault(a => a.IdAutor == id);
        }


        /// <summary>
        /// Faz o cadastro de um novo autor
        /// </summary>
        /// <param name="novoAutor">nomenclatura para o cadastro de autor</param>
        public void Cadastrar(Autor novoAutor)
        {
            //Faz a execução do método de cadastro
            ctx.Autors.Add(novoAutor);

            //Salva as alterações
            ctx.SaveChanges();
        }


        /// <summary>
        /// Faz a exclusão de um autor
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            //Faz a execução do método de exclusão
            ctx.Autors.Remove(BuscarPorId(id));

            //Salva as alterações
            ctx.SaveChanges();
        }


        /// <summary>
        /// Faz a listagem dos autores
        /// </summary>
        /// <returns>uma lista com todos os autores</returns>
        public List<Autor> ListarTodos()
        {
            //Faz a listagem 
            return ctx.Autors.ToList();
        }
    }
}
