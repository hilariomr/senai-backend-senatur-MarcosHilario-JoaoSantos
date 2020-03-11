using Senai.Senatur.WebApi.CodeFirst.Domains;
using Senai.Senatur.WebApi.CodeFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.CodeFirst.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {

        SenaturContext ctx = new SenaturContext();


        

        public void Atualizar(TipoUsuario addtipoUsuario)
        {
            ctx.TipoUsuario.Update(addtipoUsuario);
            ctx.SaveChanges();
        }

        public TipoUsuario BuscarPorId(int id)
        {
            return ctx.TipoUsuario.FirstOrDefault(e => e.IdTipoUsuario == id);
        }

        public void Cadastrar(TipoUsuario novoTipoUsuario)
        {
            ctx.TipoUsuario.Add(novoTipoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            var deleteItem = ctx.TipoUsuario.FirstOrDefault(e => e.IdTipoUsuario == id);
            ctx.TipoUsuario.Remove(deleteItem);
            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuario.ToList();
        }
    }
}
