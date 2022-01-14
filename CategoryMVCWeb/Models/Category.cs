using System.ComponentModel.DataAnnotations;

namespace CategoryMVCWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Description { get; set; } = string.Empty;

    }
}
