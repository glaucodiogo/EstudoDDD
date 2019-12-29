using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Nome { get; set; }
        public string Aniversario { get; set; }
        public string Cpf { get; set; }
    }
}
