namespace WebInventoryManagementSystem_IT703_2016012187.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
