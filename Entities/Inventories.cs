namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Inventories
    {
        [Key]
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}
