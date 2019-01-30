using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        IEnumerable<Endereco> ObterEnderecoPorMorador(Pessoa morador);
    }
}
