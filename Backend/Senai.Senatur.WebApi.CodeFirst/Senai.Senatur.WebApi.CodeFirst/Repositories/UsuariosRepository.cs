﻿using Microsoft.EntityFrameworkCore;
using Senai.Senatur.WebApi.CodeFirst.Domains;
using Senai.Senatur.WebApi.CodeFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.CodeFirst.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        SenaturContext ctx = new SenaturContext();

        public void Atualizar(int id, Usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public Usuarios BuscarPorEmailSenha(string email, string senha)
        {
            Usuarios usuarios = ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            return usuarios;
        }

        public Usuarios BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.IdUsuario == id);
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuarios usuarioApagado = new Usuarios();
            usuarioApagado = BuscarPorId(id);
            ctx.Usuarios.Remove(usuarioApagado);
            ctx.SaveChanges();
        }

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public List<Usuarios> ListarComTipoUsuario()
        {
            return ctx.Usuarios.Include(e => e.IdTipoUsuarioNavigation).ToList();
        }

    }
}
