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
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase 
    {
        //Instância a interface para receber os métodos
        private IGeneroRepository _generoRepository { get; set; }

        //Faz a instância do repository para ter referência aos métodos
        public GeneroController() {
            _generoRepository = new GeneroRepository();
        }

        /// <summary>
        /// Faz a listagem dos gêneros
        /// </summary>
        /// <returns>Devolve a lista com as informações</returns>
        [HttpGet]
        public IActionResult Get() 
        {
            //retorna a lista
            return Ok(_generoRepository.ListarTodos());
        }

        /// <summary>
        /// Faz a busca através de um id
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>O objeto procurado com suas informações</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id) 
        {
            //Traz o retorno da busca
            return Ok(_generoRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Faz o cadastro de um novo gênero
        /// </summary>
        /// <param name="novoGenero">nomenclatura de cadastro</param>
        /// <returns>Objeto cadastrado</returns>
        [HttpPost]
        public IActionResult Cadastrar(Genero novoGenero) 
        {
            //Faz a chamada para o método de cadastro
            _generoRepository.Cadastar(novoGenero);
            //Faz o retoro de um status code
            return StatusCode(201);
        }

        /// <summary>
        /// Faz a atualização
        /// </summary>
        /// <param name="generoAtualizado">nomenclatura de atualização</param>
        /// <param name="id">identificador</param>
        /// <returns>Objeto atualizado</returns>
        [HttpPut("{id}")]
        public IActionResult Atualizar(Genero generoAtualizado, int id) 
        {
            //Faz a chamada para o método
            _generoRepository.Atualizar(generoAtualizado, id);
            //retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Faz a exclusão
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>Mensagem informando o objeto excluído</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            //Faz a chamada para o método
            _generoRepository.Deletar(id);
            //retorna um status code
            return StatusCode(204);
        }
    }
}
