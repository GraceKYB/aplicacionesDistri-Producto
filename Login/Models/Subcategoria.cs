using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Subcategoria
    {
        [Key]
        public int SubcId { get; set; }

        [Required(ErrorMessage = "El nombre de la subcategoría es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre de la subcategoría no puede exceder los 100 caracteres")]
        public string SubcNombre { get; set; }
    }
}
