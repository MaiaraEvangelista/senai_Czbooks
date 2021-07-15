using senai_CZBooks_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Interfaces
{
    interface IInstituicaoRepository
    {

        /// <summary>
        /// Faz a listagem das instituições
        /// </summary>
        /// <returns>Retorna uma lista com as instituições</returns>
        List<Instituicao> ListarTodos();

        /// <summary>
        /// Faz a busca de uma instituição pelo id
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns>A instituição com o id correspondente</returns>
        Instituicao BuscarPorId(int id);


        /// <summary>
        /// Faz o cadastro de uma instituição
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <param name="novaInstituicao">Nova instituição cadastrada</param>
        void Cadastrar( Instituicao novaInstituicao);


        /// <summary>
        /// Faz a atuzalização de uma instituição
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <param name="instituicaoAtualizada">Instituição atualizada</param>
        void Atualizar(int id, Instituicao instituicaoAtualizada);


        /// <summary>
        /// Faz a exclusão de uma instituição
        /// </summary>
        /// <param name="id">Identificador</param>
        void Deletar(int id);
    }
}
