using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EncontroDeMulheres.Models
{
    public class Cliente
    {   [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string SobreNome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Foto { get; set; }
    }
}
