using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Leilao.PL
{
    public class Lote
    {
        [Key]
        public int ID_Lote { get; set; }
        [Required]
        public int FK_Leilao { get; set; }
        public Leilao Leilao { get; set; }

        public double? ValorMinimo { get; set; }
        public double? ValorMaximo { get; set; }
    
        public ICollection<Produto> Produtos { get; set; }

    }
}