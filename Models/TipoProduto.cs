using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SmartCity.Models
{

    [Table("TIPOPRODUTO")]
    public class TipoProduto
    {

        [Key]
        [Column("IDTIPO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipo { get; set; }

        [Required(ErrorMessage = "Descrição obrigatória!")]
        [StringLength(50,
            MinimumLength = 3,
            ErrorMessage = "A descrição deve ter, no mínimo, 3 e, no máximo, 50 caracteres")]
        [Display(Name ="Descrição:")]
        [Column("DESCRICAOTIPO")]
        public String DescricaoTipo { get; set; }

        [Column("COMERCIALIZADO")]
        public bool Comercializado { get; set; }
    }
}