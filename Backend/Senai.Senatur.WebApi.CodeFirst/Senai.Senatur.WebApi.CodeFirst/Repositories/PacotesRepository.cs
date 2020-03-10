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

        public void Cadastrar(Pacotes novoPacote)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pacotes> Listar()
        {
            return ctx.Pacotes.ToList();
        }
    }
}
