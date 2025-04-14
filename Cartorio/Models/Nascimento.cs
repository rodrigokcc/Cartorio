using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cartorio.Models
{
    public class Nascimento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A data do registro é obrigatória.")]
        [Column(TypeName = "date")]
        public DateTime DataDoRegistro { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [Column(TypeName = "date")]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "O nome do registrado é obrigatório.")]
        [MaxLength(150, ErrorMessage = "O nome do registrado deve ter no máximo 150 caracteres.")]
        public required string NomeDoRegistrado { get; set; }

        [MaxLength(150, ErrorMessage = "O nome do pai deve ter no máximo 150 caracteres.")]
        public string? NomeDoPai { get; set; }

        [MaxLength(150, ErrorMessage = "O nome da mãe deve ter no máximo 150 caracteres.")]
        public string? NomeDaMae { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDoPai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDaMae { get; set; }

        [MaxLength(11, ErrorMessage = "O CPF do pai é inválido.")]
        public string? CpfDoPai { get; set; }

        [MaxLength(11, ErrorMessage = "O CPF da mãe é inválido.")]
        public string? CpfDaMae { get; set; }
    }
}
