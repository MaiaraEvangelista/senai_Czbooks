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
        /// <summary>
        /// Faz a atualização do autor
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="autorAtualizado">nomenclatura para atualização</param>
        public void Atualizar(Autor autorAtualizado)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Faz a busca do autor prlo identificador
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns></returns>
        public Autor BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Faz o cadastro de um novo autor
        /// </summary>
        /// <param name="novoAutor">nomenclatura para o cadastro de autor</param>
        public void Cadastrar(Autor novoAutor)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Faz a exclusão de um autor
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Faz a listagem dos autores
        /// </summary>
        /// <returns>uma lista com todos os autores</returns>
        public List<Autor> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
