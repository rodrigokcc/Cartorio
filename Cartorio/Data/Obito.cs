using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cartorio.Data
{
    public class Obito
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataDoRegistro { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataDoObito { get; set; }

        [Required]
        [MaxLength(150)]
        public string NomeDoFalecido { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataDeNascimento { get; set; }

        [MaxLength(150)]
        public string NomeDoPai { get; set; }

        [MaxLength(150)]
        public string NomeDaMae { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDoPai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDeNascimentoDaMae { get; set; }
    }
}
