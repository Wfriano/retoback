namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
