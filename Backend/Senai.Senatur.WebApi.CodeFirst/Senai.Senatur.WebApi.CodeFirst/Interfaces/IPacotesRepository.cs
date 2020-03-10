using Senai.Senatur.WebApi.CodeFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.CodeFirst.Interfaces
{
    interface IPacotesRepository
    {
        List<Pacotes> Listar();

        Pacotes BuscarPorId(int id);

        void Cadastrar(Pacotes novoPacote);

        void Deletar(int id);

        void Atualizar(int id, Pacotes pacotes);
    }
}
