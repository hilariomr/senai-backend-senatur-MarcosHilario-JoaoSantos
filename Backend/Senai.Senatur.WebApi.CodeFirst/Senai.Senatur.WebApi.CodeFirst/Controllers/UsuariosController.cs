using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.CodeFirst.Repositories;
using Senai.Senatur.WebApi.CodeFirst.Interfaces;
using Senai.Senatur.WebApi.CodeFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Senai.Senatur.WebApi.CodeFirst.Controllers
{
    /// <summary>
    /// Controller responsável pelos endpoints referentes aos Usuarios
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class UsuariosController : ControllerBase
    {
        private IUsuariosRepository _usuariosRepository;

        public UsuariosController()
        {
            _usuariosRepository = new UsuariosRepository();
        }

        /// <summary>
        /// Lista todos os Usuários
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuariosRepository.ListarComTipoUsuario());
        }

        /// <summary>
        /// Busca um Usuário através do seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_usuariosRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra um novo Usuário
        /// </summary>
        /// <param name="novoUsuario"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Usuarios novoUsuario)
        {
            _usuariosRepository.Cadastrar(novoUsuario);
            return StatusCode(200);
        }

        /// <summary>
        /// Deleta um Usuário
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuariosRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Atualizar um Usuário existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="usuarios"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Usuarios usuarios)
        {
            _usuariosRepository.Atualizar(id, usuarios);
            return StatusCode(200);
        }




    }
}
