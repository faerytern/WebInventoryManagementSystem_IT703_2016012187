﻿namespace WebInventoryManagementSystem_IT703_2016012187.Models
{
    public class IncomingOrder
    {
        public int IncomingOrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderedOn { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
    }
}