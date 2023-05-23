namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Suppliers
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
