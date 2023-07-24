using System.ComponentModel.DataAnnotations;

namespace Abby_Razor.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Display")]
        [Range(1, 10 ,ErrorMessage = "Enter Between Range")]


        public int DisplayOrder { get; set; }

    }
}
