using System.ComponentModel.DataAnnotations.Schema;

namespace CrudCsharpv2.Models
{
    [Table("UsuarioTeste")]
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public DateTime Idade{ get; set; }
    }

}
