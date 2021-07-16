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
    //passa a rota
    [Route("api/[controller]")]
    //define que é um controlador
    [ApiController]
    public class AutorController : ControllerBase 
    {
        //InstÂncia a interface para receber os métodos
        private IAutorRepository _autorRepository { get; set; }

        //Faz a instância do repository para ter referência aos métodos
        public AutorController() 
        {
            _autorRepository = new AutorRepository();
        }

        /// <summary>
        /// Faz a listagem 
        /// </summary>
        /// <returns>Uma lista com as informações</returns>
        [HttpGet]
        public IActionResult Get() 
        {
            //retorna umja listagem
            return Ok(_autorRepository.ListarTodos());
        }

        /// <summary>
        /// Faz a busca pelo identificador
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>O elemento encontrado através do identificador</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            //Faz o retorno do elemento encontrado
            return Ok(_autorRepository.BuscarPorId(id));
        }

        /// <summary>
        /// faz o cadastro de um autor
        /// </summary>
        /// <param name="novoAutor">nomenclatura do novo cadastro</param>
        /// <returns>Retorna um novo cadastro</returns>
        [HttpPost]
        public IActionResult Post(Autor novoAutor) 
        {
            //faz a chamnada do método de cadastro
            _autorRepository.Cadastrar(novoAutor);
            //Retrona um status code
            return StatusCode(201);
        }
    
        /// <summary>
        /// Faz a atualização 
        /// </summary>
        /// <param name="autorAtualizado">nomenclatura da atualização</param>
        /// <returns>O objeto atualizado</returns>
        [HttpPut]
        public IActionResult Atualizar(Autor autorAtualizado) 
        {
            //Faz a chamada para o método de atualização
            _autorRepository.Atualizar(autorAtualizado);
            //retorna um status code de confirmação
            return StatusCode(204);
        }

        /// <summary>
        /// Faz a exclusão de um método
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>O status code mostrando que o objeto foi deletado</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            //Faz a chamada para o método de deletar
            _autorRepository.Deletar(id);
            //Retorna um status code 
            return StatusCode(204);
        }
    
    }
}
