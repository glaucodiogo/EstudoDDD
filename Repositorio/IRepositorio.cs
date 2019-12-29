using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public interface IRepository<T>
    {
        T Salvar(T value);
        void Apagar(T value);
        T Obter(long identidade);
        IEnumerable<T> ObterTodos();        
    }
}
