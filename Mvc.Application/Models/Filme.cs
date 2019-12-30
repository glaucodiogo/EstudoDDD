﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Application.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="O campo título é obrigatório")] 
        [StringLength(60,MinimumLength =3,ErrorMessage ="O título precisa ter entre 3 e 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.Date,ErrorMessage ="Data em formato incorreto")]
        [Required(ErrorMessage ="O campo Data de lançamento é obrigatório")]
        [Display(Name ="Data de Lançamento")]
        public DateTime DataLancamento { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$",ErrorMessage ="Genero em formato errado")]
        [StringLength(30,ErrorMessage ="Máximo de 30 caracteres"), Required(ErrorMessage ="O campo gênero é obrigatório")]
        public string Genero { get; set; }

        [Range(1,1000,ErrorMessage ="Valor de 1 a 1000")]
        [Required(ErrorMessage ="Preencha o campo valor")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage ="Preencha o campo avaliação.")]
        [Display(Name ="Avaliação")]
        [RegularExpression(@"^[0-5]*$",ErrorMessage ="Somente números")]
        public int Avaliacao { get; set; }

    }
}
