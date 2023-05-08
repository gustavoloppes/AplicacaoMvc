using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class Resposta
    {
        [Required(ErrorMessage ="O campo Nome deve ser preenchido.")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="O campo Email deve ser preenchido.")]
        [EmailAddress(ErrorMessage ="O campo Email nao corresponde a um email valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="O campo Resposta deve ser preenchido.")]
        public bool? Sim { get; set; }

    }
}