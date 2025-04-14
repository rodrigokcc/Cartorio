using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cartorio.Data
{
    public class Obito
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A data do registro é obrigatória.")]
        [Column(TypeName = "date")]
        public DateTime DataDoRegistro { get; set; }

        [Required(ErrorMessage = "A data do óbito é obrigatória.")]
        [Column(TypeName = "date")]
        public DateTime DataDoObito { get; set; }

        [Required(ErrorMessage = "O nome do falecido é obrigatório.")]
        [MaxLength(150, ErrorMessage = "O nome do falecido deve ter no máximo 150 caracteres.")]
        public string NomeDoFalecido { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [Column(TypeName = "date")]
        public DateTime DataDeNascimento { get; set; }

        [MaxLength(150, ErrorMessage = "O nome do pai deve ter no máximo 150 caracteres.")]
        public string? NomeDoPai { get; set; }

        [MaxLength(150, ErrorMessage = "O nome da mãe deve ter no máximo 150 caracteres.")]
        public string? NomeDaMae { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDoPai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDaMae { get; set; }
    }
}
