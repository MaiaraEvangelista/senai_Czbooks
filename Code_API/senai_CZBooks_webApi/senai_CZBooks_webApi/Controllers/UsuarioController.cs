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

    public class UsuarioController : ControllerBase 
    {
        //Instância a interface para receber os métodos
        private IUsuarioRepository _usuarioRepository { get; set; }

        //Faz a instância do repository para ter referência aos métodos
        public UsuarioController() {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Faz o cadastro 
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <param name="novoUsuario">nomenclatura de cadastro</param>
        /// <returns>Um objeto cadastrado</returns>
        [HttpPost]
        public IActionResult Cadastrar( Usuario novoUsuario) 
        {
            //Faz a chamada para o método
            _usuarioRepository.Cadastrar( novoUsuario);
            //retorna um status code
            return StatusCode(201);
        }

        /// <summary>
        /// Faz atualização do email
        /// </summary>
        /// <param name="email">conexão de conta</param>
        /// <param name="usuarioAtualizado">nomenclatura de atualização</param>
        /// <returns>Objeto atualizado</returns>
        [HttpPut("{Email}")]
        public IActionResult AtualizarEmail(string email,  Usuario usuarioAtualizado) 
        {
            //Faz a chamada para o método
            _usuarioRepository.AtualizarEmail(email, usuarioAtualizado);
            //retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Faz atualização da senha
        /// </summary>
        /// <param name="senha">chave de conexão</param>
        /// <param name="usuarioAtualizado">noemnclatura de atualização</param>
        /// <returns>Senha atualizada</returns>
        [HttpPut("{senha}")]
        public IActionResult AtualizarSenha(string senha, Usuario usuarioAtualizado) 
        {
            //Faz a chamada para o método
            _usuarioRepository.AtualizarSenha(senha, usuarioAtualizado);
            //retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Faz a exclusão
        /// </summary>
        /// <param name="id">identificador</param>
        /// <returns>Objeto deletado</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            //Faz a chamada para o método
            _usuarioRepository.Deletar(id);
            //retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Faz a busca pelo identificador
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns>A busca pelo identificador</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id) {
            return Ok(_usuarioRepository.BuscarPorId(id));
        }
    }
}
