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
    /// Instância a classe instituiçãoRepository
    /// herda a interface
    /// </summary>
    public class InstituicaoRepository : IInstituicaoRepository
    {

        //Faz instância da context para ter conexão com o Banco de dados
        CZBooksContext ctx = new CZBooksContext();


        /// <summary>
        /// Faz a atualização de uma instituição
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="instituicaoAtualizada">nomenclatura para a atualização</param>
        public void Atualizar(int id, Instituicao instituicaoAtualizada)
        {
            //Faz a procura pelo identificador
            Instituicao instituicaoBuscada = ctx.Instituicaos.Find(id);

            if(instituicaoAtualizada.NomeFantasia != null) 
            {
                instituicaoBuscada.NomeFantasia = instituicaoAtualizada.NomeFantasia;
            }

            if(instituicaoAtualizada.HorarioFechamento !=null)  
            {
                instituicaoBuscada.HorarioFechamento = instituicaoAtualizada.HorarioFechamento;
            }

            if(instituicaoAtualizada.HorarioAbertura != null) 
            {
                instituicaoBuscada.HorarioAbertura = instituicaoAtualizada.HorarioAbertura;
            }

            if(instituicaoAtualizada.Endereco != null) 
            {
                instituicaoBuscada.Endereco = instituicaoAtualizada.Endereco;
            }

            if(instituicaoAtualizada.Cnpj != null) 
            {
                instituicaoBuscada.Cnpj = instituicaoAtualizada.Cnpj;
            }

            //Faz a execução do método de armazena na nomenclatura
            ctx.Instituicaos.Update(instituicaoAtualizada);

            //Salva as alterações
            ctx.SaveChanges();
        }

        /// <summary>
        /// Faz a busca pelo identificador
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>A instituiçaõ correspondente do identificador</returns>
        public Instituicao BuscarPorId(int id)
        {
            //Faz a execução do método e busca pelo identificador
            return ctx.Instituicaos.FirstOrDefault(i => i.IdInstituicao == id);
        }

        /// <summary>
        /// Faz o cadastro de uma instituição
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="novaInstituicao">nomenclatura para o cadastro</param>
        public void Cadastrar( Instituicao novaInstituicao)
        {
            //Executa o método de cadastro
            ctx.Instituicaos.Add(novaInstituicao);

            //Salva as alterações
            ctx.SaveChanges();
        }

        /// <summary>
        /// Faz a exclusão de uma instituição
        /// </summary>
        /// <param name="id">identificador</param>
        public void Deletar(int id)
        {
            //Executa o método
            ctx.Instituicaos.Remove(BuscarPorId(id));

            //Salva as alterações
            ctx.SaveChanges();
        }

        /// <summary>
        /// Faz a listagem das instituições
        /// </summary>
        /// <returns>Uma lista com todas as instituições</returns>
        public List<Instituicao> ListarTodos()
        {
            //Faz a listagem
            return ctx.Instituicaos.ToList();
        }
    }
}
