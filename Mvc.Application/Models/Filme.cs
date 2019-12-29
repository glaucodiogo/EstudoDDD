using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Application.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Required(ErrorMessage="O campo título é obrigatório")] 
        [StringLength(60,MinimumLength =3,ErrorMessage ="O título precisa ter entre 3 e 60 caracteres")]
        public string Titulo { get; set; }
        [DataType(DataType.DateTime,ErrorMessage ="Data em formato incorreto")]
        [Required(ErrorMessage ="O campo Data de lançamento é obrigatório")]
        [Display(Name ="Data de Lançamento")]
        public DateTime DataLancamento { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$",ErrorMessage ="Genero em formato errado")]
        public string Genero { get; set; }

        [Range(1,1000,ErrorMessage ="Valor de 1 a 1000")]
        [Required(ErrorMessage ="Preencha o campo valor")]
        [RegularExpression(@"^[0-5]*$",ErrorMessage ="Somente números  ")]
        public decimal Valor { get; set; }

    }
}
