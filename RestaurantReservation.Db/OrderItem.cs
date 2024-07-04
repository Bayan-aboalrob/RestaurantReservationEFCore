using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RestaurantReservation.Db
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; } //PK

        [ForeignKey("MenuItem")]
        public int ItemId { get; set; } //FK (from MenuItem)

        [Required]
        public int Quantity { get; set; }

        public MenuItem MenuItem { get; set; } // a Navigation property form the MenuItem to indicate the relationship

        [ForeignKey("Order")]
        public int OrderId { get; set; }// FK

        public Order Order { get; set; } // Navigatoin property for the 1:* with the orderitem class
    }
}
