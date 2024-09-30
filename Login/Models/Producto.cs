using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Login.Models;

namespace Login.Models
{
    public class Producto
    {
        [Key]
        public int ProId { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre del producto no puede exceder los 100 caracteres")]
        public string ProNombre { get; set; }

        [StringLength(500, ErrorMessage = "La descripción del producto no puede exceder los 500 caracteres")]
        public string ProDescripcion { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio")]
        [Range(0.01, 10000.00, ErrorMessage = "El precio debe estar entre 0.01 y 10000.00")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProPrecio { get; set; }

        [Required(ErrorMessage = "El stock del producto es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        public int ProStock { get; set; }

        public byte[] ProImagen { get; set; }

        [Required(ErrorMessage = "La categoría del producto es obligatoria")]
        [ForeignKey("Categoria")]
        public int CatId { get; set; }
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "La subcategoría del producto es obligatoria")]
        [ForeignKey("Subcategoria")]
        public int SubcId { get; set; }
        public Subcategoria Subcategoria { get; set; }
    }
}
