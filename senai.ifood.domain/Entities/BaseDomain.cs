using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 

namespace senai.ifood.domain.Entities {
    //classe pai, para não ser estanciada
    public abstract class BaseDomain {
        //colocar os itens que são comuns nas tabelas
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; }
    }
}