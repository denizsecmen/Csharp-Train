using System.ComponentModel.DataAnnotations;
namespace Train_000.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
