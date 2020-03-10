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
            Pacotes pacoteAtualizado = new Pacotes();
            pacoteAtualizado = BuscarPorId(id);

            pacoteAtualizado.Ativo = true;
            
            if (pacotes.DataIda != null)
            {
                pacoteAtualizado.DataIda = pacotes.DataIda;
            }

            if (pacotes.DataVolta != null)
            {
                pacoteAtualizado.DataVolta = pacotes.DataVolta;
            }

            if (pacotes.Descricao != null)
            {
                pacoteAtualizado.Descricao = pacotes.Descricao;
            }

            if (pacotes.NomeCidade != null)
            {
                pacoteAtualizado.NomeCidade = pacotes.NomeCidade;
            }

            if (pacotes.NomePacote != null)
            {
                pacoteAtualizado.NomePacote = pacotes.NomePacote;
            }

            if (pacotes.Valor != null)
            {
                pacoteAtualizado.Valor = pacotes.Valor;
            }

            ctx.Pacotes.Update(pacoteAtualizado);
            ctx.SaveChanges();
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
