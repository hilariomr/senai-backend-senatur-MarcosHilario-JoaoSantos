using Microsoft.AspNetCore.Mvc;
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
    }
}
