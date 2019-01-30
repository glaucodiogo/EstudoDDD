using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public interface IPessoaRepository :IRepository<Pessoa>
    {
        IEnumerable<Pessoa> ObterMoradoresPorEndereco(Endereco endereco);
    }
}
