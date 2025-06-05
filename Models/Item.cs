using System.ComponentModel.DataAnnotations;

namespace YourProjectName.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<SubItem> SubItems { get; set; } = new List<SubItem>();
    }

    public class SubItem
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
