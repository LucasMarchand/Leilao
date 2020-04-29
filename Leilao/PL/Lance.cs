using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Leilao.PL
{
    public class Lance
    {
        [Key]
        public int ID_Lance { get; set; }

        [Required]
        public int FK_Leilao { get; set; }
        public virtual Leilao Leilao { get; set; }

        [Required]
        public int FK_Usuario { get; set; }
        public virtual Usuario Usuario { get; set; }

        [Required]
        public double Valor { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Data { get; set; }
        [Column(TypeName = "char(1)")]
        public char FlagVencedor { get; set; }
    }
}