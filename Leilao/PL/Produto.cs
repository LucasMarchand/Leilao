using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leilao.PL
{
    public class Produto
    {
        [Key]
        public int ID_Produto { get; set; }

        [Required]
        public int FK_Lote { get; set; }
        public Lote Lote { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string DescricaoCurta { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(1000)")]
        public string DescricaoLonga { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Categoria { get; set; }
        public byte[] Foto { get; set; }
    }
}