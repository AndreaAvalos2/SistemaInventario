using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")] // quiere decir que el campo es requerido
        [MaxLength(60,ErrorMessage = "El campo nombre no es mas de 60 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Descripcion es Requerido")] // quiere decir que el campo es requerido
        [MaxLength(100, ErrorMessage = "El campo Descripcion no es mas de 100 caracteres")]
        public string Descripcion { get; set; }
        
        [Required(ErrorMessage ="El campo Estado es requerido")]
        public bool Estado { get; set; }
    }
}
