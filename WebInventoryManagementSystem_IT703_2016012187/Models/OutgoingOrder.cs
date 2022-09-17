using Microsoft.EntityFrameworkCore;

namespace WebInventoryManagementSystem_IT703_2016012187.Models
{
    public class OutgoingOrder
    {
        public int OutgoingOrderId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderedOn { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public int? ClientId { get; set; }
        public Client? Client { get; set; }
        public int InventoryId { get; set; }
        public Inventory? Inventory { get; set; }
    }
}
