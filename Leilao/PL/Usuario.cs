﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leilao.PL
{
    public class Usuario
    {
        [Key]
        public int ID_Usuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(11)")]
        [MinLength(11)]
        public string CPF { get; set; }
        [Column(TypeName = "varchar(14)")]
        [MinLength(14)]
        public string CNPJ { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }
        public virtual ICollection<Lance> Lances { get; set; }
        public virtual ICollection<Leilao> Leiloes { get; set; }
    }
}