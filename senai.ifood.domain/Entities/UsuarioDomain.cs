using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 

namespace senai.ifood.domain.Entities {

public class UsuarioDomain:BaseDomain {
[Required]
[StringLength(100)]
        public string Email {get; set; }

[Required]
[StringLength(12, MinimumLength = 4)]
[DataType(DataType.Password)]
        public string Senha {get; set; }

public ICollection < UsuarioPermissaoDomain > UsuariosPermissoes {get; set; }

}
}