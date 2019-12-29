using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidade
{
    public class Usuario
    {
        public  Nullable<int> Id { get; set; }
        public  string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Status { get; set; }
        public ICollection<Tarefa> Tarefas { get; set; }

    }
}
