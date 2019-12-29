using System;

namespace Dominio.Entidade
{
    public class Produto
    {
        public int Id_Produto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public int Categoria { get; set; }

        //métodos
        public bool PodeVender()
        {
            return Quantidade > 0;
        }

        public void Vendeu()
        {
            if (PodeVender())
                Quantidade--;
        }

        public void Comprou(int qtde)
        {
            Quantidade += qtde;
        }
    }
}
