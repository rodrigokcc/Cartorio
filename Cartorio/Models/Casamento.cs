using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cartorio.Models
{
    public class Casamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A data do registro é obrigatória.")]
        [Column(TypeName = "date")]
        public DateTime DataDoRegistro { get; set; }

        [Required(ErrorMessage = "A data do casamento é obrigatória.")]
        [Column(TypeName = "date")]
        public DateTime DataDoCasamento { get; set; }

        // Dados do Cônjuge 1
        [Required(ErrorMessage = "O nome do cônjuge é obrigatório.")]
        [MaxLength(150, ErrorMessage = "O nome do cônjuge deve ter no máximo 150 caracteres.")]
        public required string NomeConjuge1 { get; set; }

        [Required(ErrorMessage = "A data de nascimento do cônjuge é obrigatória.")]
        [Column(TypeName = "date")]
        public DateTime DataDeNascimentoConjuge1 { get; set; }

        [Required(ErrorMessage = "O CPF do cônjuge é obrigatório.")]
        [MaxLength(11, ErrorMessage = "O CPF do cônjuge é inválido.")]
        public required string CpfConjuge1 { get; set; }

        [MaxLength(150, ErrorMessage = "O nome do pai do cônjuge deve ter no máximo 150 caracteres.")]
        public string? NomeDoPaiConjuge1 { get; set; }

        [MaxLength(150, ErrorMessage = "O nome da mãe do cônjuge deve ter no máximo 150 caracteres.")]
        public string? NomeDaMaeConjuge1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDoPaiConjuge1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDaMaeConjuge1 { get; set; }

        [MaxLength(11, ErrorMessage = "O CPF do pai do cônjuge é inválido.")]
        public string? CpfDoPaiConjuge1 { get; set; }

        [MaxLength(11, ErrorMessage = "O CPF da mãe do cônjuge é inválido.")]
        public string? CpfDaMaeConjuge1 { get; set; }

        // Dados do Cônjuge 2
        [Required(ErrorMessage = "O nome do cônjuge é obrigatório.")]
        [MaxLength(150, ErrorMessage = "O nome do cônjuge deve ter no máximo 150 caracteres.")]
        public required string NomeConjuge2 { get; set; }

        [Required(ErrorMessage = "A data de nascimento do cônjuge é obrigatória.")]
        [Column(TypeName = "date")]
        public DateTime DataDeNascimentoConjuge2 { get; set; }

        [Required(ErrorMessage = "O CPF do cônjuge é obrigatório.")]
        [MaxLength(11, ErrorMessage = "O CPF do cônjuge é inválido.")]
        public required string CpfConjuge2 { get; set; }

        [MaxLength(150, ErrorMessage = "O nome do pai do cônjuge deve ter no máximo 150 caracteres.")]
        public string? NomeDoPaiConjuge2 { get; set; }

        [MaxLength(150, ErrorMessage = "O nome da mãe do cônjuge deve ter no máximo 150 caracteres.")]
        public string? NomeDaMaeConjuge2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDoPaiConjuge2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDaMaeConjuge2 { get; set; }

        [MaxLength(11, ErrorMessage = "O CPF do pai do cônjuge é inválido.")]
        public string? CpfDoPaiConjuge2 { get; set; }

        [MaxLength(11, ErrorMessage = "O CPF da mãe do cônjuge é inválido.")]
        public string? CpfDaMaeConjuge2 { get; set; }
    }
}
