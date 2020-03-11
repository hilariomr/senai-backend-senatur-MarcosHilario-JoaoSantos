using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Senai.Senatur.WebApi.CodeFirst.Domains;
using Senai.Senatur.WebApi.CodeFirst.Interfaces;
using Senai.Senatur.WebApi.CodeFirst.Repositories;
using Senai.Senatur.WebApi.CodeFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.CodeFirst.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase
    { 
        private IUsuariosRepository _usuariosRepository { get; set; }

        public LoginController ()
        {
            _usuariosRepository = new UsuariosRepository();
        }

        [HttpPost] 
        public IActionResult Post(LoginViewModel login)
        {
            Usuarios usuarioBuscado = _usuariosRepository.BuscarPorEmailSenha(login.Email, login.Senha);

            if(usuarioBuscado == null)
            {
                return NotFound("Email ou senha inválidos");
            }

            var claims = new[]
           {
                new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString())
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("senatur-chave-autenticacao"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "Senatur.WebApi",
                audience: "Senatur.WebApi",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
                );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }

    }
}
