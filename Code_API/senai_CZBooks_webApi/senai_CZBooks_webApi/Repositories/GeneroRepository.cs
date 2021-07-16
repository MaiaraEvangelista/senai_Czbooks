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
    /// Instância a classe generoRepository
    /// herda a interface
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {

        //Faz instância da context para ter conexão com o Banco de dados
        CZBooksContext ctx = new CZBooksContext();


        /// <summary>
        /// Faz a atualização de um gênero
        /// </summary>
        /// <param name="generoAtualizado">nomenclatura para atualização</param>
        /// <param name="id">identificador</param>
        public void Atualizar(Genero generoAtualizado, int id)
        {
            //Faz a a instância do gênero procurado para achar o id
            Genero generoProcurado = ctx.Generos.Find(id);

            //Verifica se é nulo/diferente de nulo
            if(generoAtualizado.Tipo !=null) 
            {
                //Atribui os valores, e define um local de armazenamento
                generoProcurado.Tipo = generoAtualizado.Tipo;
            }
            //Faz a atualização
            ctx.Generos.Update(generoProcurado);

            //Salva as alterações
            ctx.SaveChanges();
        }


        /// <summary>
        /// Faz a busca de um gênero pelo id
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>O gênero procurado</returns>
        public Genero BuscarPorId(int id)
        {
            //Faz a busca através do identificador, e retorna uma resposta
            return ctx.Generos.FirstOrDefault(g => g.IdGenero == id);
        }

        /// <summary>
        /// Faz o cadastro de um gênero 
        /// </summary>
        /// <param name="novoGenero">nomenclatura do cadastro </param>
        public void Cadastrar( Genero novoGenero)
        {
            //Executa o método de cadastro, e adiciona o novo gênero
            ctx.Generos.Add(novoGenero);

            //Salva as alterações
            ctx.SaveChanges();
        }


        /// <summary>
        /// Faz a exclusão de um gênero
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            //Executa o método de exclusão
            ctx.Generos.Remove(BuscarPorId(id));

            //Salva as alterações
            ctx.SaveChanges();
        }


        /// <summary>
        /// Faz a listagem de um gênero
        /// </summary>
        /// <returns>A lista com os gêneros</returns>
        public List<Genero> ListarTodos()
        {
            //Faz o retorno da lista de gêneros
            return ctx.Generos.ToList();
        }
    }
}
