using senai_CZBooks_webApi.Domains;
using senai_CZBooks_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Repositories
{
    /// <summary>
    /// Instância a classe instituiçãoRepository
    /// herda a interface
    /// </summary>
    public class InstituicaoRepository : IInstituicaoRepository
    {

        /// <summary>
        /// Faz a atualização de uma instituição
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="instituicaoAtualizada">nomenclatura para a atualização</param>
        public void Atualizar(int id, Instituicao instituicaoAtualizada)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a busca pelo identificador
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>A instituiçaõ correspondente do identificador</returns>
        public Instituicao BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz o cadastro de uma instituição
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="novaInstituicao">nomenclatura para o cadastro</param>
        public void Cadastrar(int id, Instituicao novaInstituicao)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a exclusão de uma instituição
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a listagem das instituições
        /// </summary>
        /// <returns>Uma lista com todas as instituições</returns>
        public List<Instituicao> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
