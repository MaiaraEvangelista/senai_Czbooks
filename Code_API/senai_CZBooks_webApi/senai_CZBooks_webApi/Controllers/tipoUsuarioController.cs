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
    //Define que a resposta vai ser em json
    [Produces("application/json")]

    public class tipoUsuarioController : ControllerBase 
    {
        //Instância a interface para receber os métodos
        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }

        //Faz a instância do repository para ter referência aos métodos
        public tipoUsuarioController() {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        /// <summary>
        /// Faz a lisatgem
        /// </summary>
        /// <returns>Uma lista com os objetos e todas as suas informações </returns>
        [HttpGet]
        public IActionResult Get() 
        {
            //faz a chamada para o método, e retorna uma lista
            return Ok(_tipoUsuarioRepository.ListarTodos());
        }

        /// <summary>
        /// Faz a busca pelo identificador
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>Objeto buscado pelo id correspondente</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id) {
            //faz a chamada para o método, e retorna um  status code
            return Ok(_tipoUsuarioRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Método de cadastro
        /// </summary>
        /// <param name="tipoUsuarioCadastrado">nomenclatura de cadastro</param>
        /// <returns>Objeto cadastrado</returns>
        [HttpPost]
        public IActionResult Cadastrar(TiposUsuario tipoUsuarioCadastrado) 
        {
            //Faz a chamada para o método de cadastro
            _tipoUsuarioRepository.Cadastrar(tipoUsuarioCadastrado);
            //Retorna um status code
            return StatusCode(201);
        }

        /// <summary>
        /// Faz a atualizção
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="tipoUsuarioAtualizado">nomenclatura de atualização</param>
        /// <returns>Um status code e o objeto atualizado</returns>
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, TiposUsuario tipoUsuarioAtualizado) 
        {
            //Faz a chamada para o método
            _tipoUsuarioRepository.Atualizar(id, tipoUsuarioAtualizado);
            //retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Faz a exclusão 
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>Obejto excluído com o status code</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            //Faz a chamada para o método
            _tipoUsuarioRepository.Deletar(id);
            //retorna um status code
            return StatusCode(204);
        }
    }
}
