using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Leilao.PL
{
    public class Leilao
    {
        [Key]
        public int ID_Leilao { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Titulo { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string Descricao { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public EnumNatureza Natureza { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public EnumForma Forma { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Inicio { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Termino { get; set; }
        [Required]
        public int FK_Responsavel { get; set; }
        public Usuario Usuario { get; set; }
        public Lote Lote { get; set; }
        public virtual ICollection<Lance> Lances { get; set; }
    }
}
