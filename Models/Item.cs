using System.ComponentModel.DataAnnotations;

namespace YourProjectName.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
