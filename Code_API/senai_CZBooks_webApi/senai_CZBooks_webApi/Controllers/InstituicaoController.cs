using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_CZBooks_webApi.Domains;
using senai_CZBooks_webApi.Interfaces;
using senai_CZBooks_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_webApi.Controllers {
    //Define que a resposta vai ser em json
    [Produces("application/json")]
    //Definiçaõ da rota do controlador
    [Route("api/[controller]")]
    //Define que é um controlador
    [ApiController]

    public class InstituicaoController : ControllerBase 
    {
        //Instância a 'instituição interface' para receber os métodos
        private IInstituicaoRepository _instituicaoRepository { get; set; }
        

        //Instância o repository para ter referência dos métodos
        public InstituicaoController() {
            _instituicaoRepository = new InstituicaoRepository();
        }
    
        /// <summary>
        /// Faz a listagem 
        /// </summary>
        /// <returns>Retorna com a lista e as informações</returns>
        [HttpGet]
        //Faz o métodop de busca
        public IActionResult Get() 
        {
            //Faz o retorno da lista com as informações
            return Ok(_instituicaoRepository.ListarTodos());
        }

        /// <summary>
        /// Faz a busca pelo identificador
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>A instituição buscada com suas informações</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            //da um retorno da resposta encontrada
            return Ok(_instituicaoRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Faz o cadastro
        /// </summary>
        /// <param name="novaInstituicao">nomenclatura para  o cadastro da instituição</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Instituicao novaInstituicao) 
        {
            //Faz a chamada do método de cadastro
            _instituicaoRepository.Cadastrar(novaInstituicao);
            //retorna um status code
            return StatusCode(201);
        }

        /// <summary>
        /// Faz o método de atualização
        /// </summary>
        /// <param name="instituicaoAtualizada">nomenclatura para atualização</param>
        /// <param name="id">identificador</param>
        /// <returns>Faz o retorno de uma atualização</returns>
        [HttpPut("{id}")]
        public IActionResult Atualizar(Instituicao instituicaoAtualizada, int id)
        {
            //Faz a chamada para o método de atualização
            _instituicaoRepository.Atualizar(id, instituicaoAtualizada);
            //retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Faz a exclusão
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>Objeto excluído</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            //Faz a chamada do método de deletar
            _instituicaoRepository.Deletar(id);
            //Faz o retorno de confirmação (status code)
            return StatusCode(204);
        }
    }
}
