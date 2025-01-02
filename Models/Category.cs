using System.ComponentModel.DataAnnotations;
namespace Train_000.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
		[Required(ErrorMessage = "Category Name is required")]
		[StringLength(100, ErrorMessage = "Category Name cannot be longer than 100 characters.")]
		public required string Name { get; set; }
		[Range(1,100, ErrorMessage = "Display Order must be a positive number.")]
		public int DisplayOrder { get; set; }
    }
}
