using System;
using System.Collections.Generic;

namespace Dominio.Entidade
{
    public class Categoria
    {
        //Propriedades
        public int Id_Categoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public IList<Produto> Produtos { get; set; }
    }
}
