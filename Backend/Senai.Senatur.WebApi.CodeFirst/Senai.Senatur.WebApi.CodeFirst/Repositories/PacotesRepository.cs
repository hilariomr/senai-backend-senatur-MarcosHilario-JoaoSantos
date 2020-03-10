using Senai.Senatur.WebApi.CodeFirst.Domains;
using Senai.Senatur.WebApi.CodeFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.CodeFirst.Repositories
{
    public class PacotesRepository : IPacotesRepository
    {
        SenaturContext ctx = new SenaturContext();

        public void Atualizar(int id, Pacotes pacotes)
        {
            throw new NotImplementedException();
        }

        public Pacotes BuscarPorId(int id)
        {
            return ctx.Pacotes.FirstOrDefault(e => e.IdPacote == id);
        }

        public void Cadastrar(Pacotes novoPacote)
        {
            ctx.Pacotes.Add(novoPacote);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Pacotes pacoteApagado = new Pacotes();
            pacoteApagado = BuscarPorId(id);
            ctx.Pacotes.Remove(pacoteApagado);
            ctx.SaveChanges();
        }

        public List<Pacotes> Listar()
        {
            return ctx.Pacotes.ToList();
        }
    }
}
