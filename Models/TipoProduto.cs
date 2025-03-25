using System;
using System.ComponentModel.DataAnnotations;

namespace SmartCity.Models
{
    public class TipoProduto
    {
        public int IdTipo { get; set; }

        [Required(ErrorMessage = "Descrição obrigatória!")]
        [StringLength(50,
            MinimumLength = 3,
            ErrorMessage = "A descrição deve ter, no mínimo, 3 e, no máximo, 50 caracteres")]
        public String DescricaoTipo { get; set; }
        public bool Comercializado { get; set; }
    }
}