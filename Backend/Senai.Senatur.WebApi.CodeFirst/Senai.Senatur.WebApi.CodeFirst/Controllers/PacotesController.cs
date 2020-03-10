using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.CodeFirst.Domains;
using Senai.Senatur.WebApi.CodeFirst.Interfaces;
using Senai.Senatur.WebApi.CodeFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PacotesController : ControllerBase
    {
        private IPacotesRepository _pacotesRepository;

        public  PacotesController()
        {
            _pacotesRepository = new PacotesRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pacotesRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_pacotesRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Pacotes novoPacote)
        {
            _pacotesRepository.Cadastrar(novoPacote);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pacotesRepository.Deletar(id);
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Pacotes pacotes)
        {
            _pacotesRepository.Atualizar(id, pacotes);
            return StatusCode(200);
        }




    }
}
