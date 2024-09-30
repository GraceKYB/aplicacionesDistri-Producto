using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Categoria
    {
        [Key]
        public int CatId { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre de la categoría no puede exceder los 100 caracteres")]
        public string CatNombre { get; set; }
    }

}
