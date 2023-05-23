namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }
    }
}