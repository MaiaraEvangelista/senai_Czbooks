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
    public class LivroController : ControllerBase 
    {
        //Instância a interface para receber os métodos
        private ILivroRepository _livroRepository { get; set; }

        //Faz a instância do repository para ter referência aos métodos
        public LivroController() {
            _livroRepository = new LivroRepository();
        }

        /// <summary>
        /// Método de listagem
        /// </summary>
        /// <returns>Retorna a lista dos livros</returns>
        [HttpGet]
        public IActionResult Get() 
        {
            //faz o retorno de uam lista
            return Ok(_livroRepository.ListarTodos());
        }

        /// <summary>
        /// Faz a busca pelo id
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>Faz a busca pelo identificador</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id) 
        {
            return Ok(_livroRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Método de listagem
        /// </summary>
        /// <param name="novoLivro">nomenclatura de cadastro</param>
        /// <returns>Objeto cadastrado</returns>
        [HttpPost]
        public IActionResult Cadastrar(Livro novoLivro) 
        {
            //Faz a chamada para o método
            _livroRepository.Cadastrar(novoLivro);
            //retorna um status code
            return StatusCode(201);
        }

        /// <summary>
        /// Faz a atualização
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="livroAtualizado">nomenclatura para atualização</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Livro livroAtualizado) 
        {
            //faz a chamada para o método
            _livroRepository.Atualizar(id, livroAtualizado);
            //retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Faz a exclusão 
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns>Faz o retorno da confirmação de exclusão</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            //Faz a chamada para o método
            _livroRepository.Deletar(id);
            //retorna um ststus code
            return StatusCode(204);
        }
    }
}
