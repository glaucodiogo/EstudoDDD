using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidade
{
    public class Tarefa
    {
         private Nullable<long> Id { get; set; }
         private string Nome { get; set; }
         private Nullable<DateTime> DataDaEntrega { get; set; }
         private string Descricao { get; set; }         
         private Nullable<long> IdUsuario { get; set; }
         private Usuario Usuario { get; set; }
    }
}
