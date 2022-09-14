namespace WebInventoryManagementSystem_IT703_2016012187.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        
    }
    public class Category
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int QuantityOnHand { get; set; }
        public int MinimumToStock { get; set; }
        public int ReOrderAmount { get; set; }
        public decimal Price { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderMadeOn { get; set; }
        public DateTime? RecievedOn { get; set; }
        // TODO
        // THE REST :(
    }
}
