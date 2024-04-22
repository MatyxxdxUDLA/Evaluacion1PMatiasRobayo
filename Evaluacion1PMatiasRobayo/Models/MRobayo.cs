using System.ComponentModel.DataAnnotations;

namespace Evaluacion1PMatiasRobayo.Models
{
    public class MRobayo
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo CampoString debe estar entre 3 y 50 caracteres.")]
        public required string Nombre { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo CampoString debe estar entre 3 y 50 caracteres.")]
        public required string Apellido { get; set; }
        public float Promedio { get; set;}

        [Range(typeof(bool), "true", "true", ErrorMessage = "El campo CampoBool debe ser true.")]
        public Boolean Estudia { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        public Carrera Carrera { get; set; }
    }
}
