using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cartorio.Data
{
    public class Casamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataDoRegistro { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataDoCasamento { get; set; }

        // Dados do Cônjuge 1
        [Required]
        [MaxLength(150)]
        public string NomeConjuge1 { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataDeNascimentoConjuge1 { get; set; }

        [MaxLength(11)]
        public string CpfConjuge1 { get; set; }

        [MaxLength(150)]
        public string NomeDoPaiConjuge1 { get; set; }

        [MaxLength(150)]
        public string NomeDaMaeConjuge1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDoPaiConjuge1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDaMaeConjuge1 { get; set; }

        [MaxLength(11)]
        public string CpfDoPaiConjuge1 { get; set; }

        [MaxLength(11)]
        public string CpfDaMaeConjuge1 { get; set; }

        // Dados do Cônjuge 2
        [Required]
        [MaxLength(150)]
        public string NomeConjuge2 { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataDeNascimentoConjuge2 { get; set; }

        [MaxLength(11)]
        public string CpfConjuge2 { get; set; }

        [MaxLength(150)]
        public string NomeDoPaiConjuge2 { get; set; }

        [MaxLength(150)]
        public string NomeDaMaeConjuge2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDoPaiConjuge2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDaMaeConjuge2 { get; set; }

        [MaxLength(11)]
        public string CpfDoPaiConjuge2 { get; set; }

        [MaxLength(11)]
        public string CpfDaMaeConjuge2 { get; set; }
    }
}
