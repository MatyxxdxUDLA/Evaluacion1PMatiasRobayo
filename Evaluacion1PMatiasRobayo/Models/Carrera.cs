using System.ComponentModel.DataAnnotations;

namespace Evaluacion1PMatiasRobayo.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo NombreCarrera es requerido.")]
        public string nombre_carrera { get; set; }
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El campo Campus solo puede contener letras y espacios.")]
        public string campus { get; set; }
        [Range(1, 10, ErrorMessage = "El número de semestres debe estar entre 1 y 10.")]
        public int numero_semestres { get; set; }

    }
}
