using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.CodeFirst.Repositories;
using Senai.Senatur.WebApi.CodeFirst.Interfaces;
using Senai.Senatur.WebApi.CodeFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuariosRepository;

        public UsuariosController()
        {
            // FALTA FAZER AQUI
        }
    }
}
