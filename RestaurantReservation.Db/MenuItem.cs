using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantReservation.Db
{
    public class MenuItem
    {
        [Key]
        public int ItemId { get; set; }//PK

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; } //FK 

        public Restaurant Restaurant { get; set; } //Navigation property (for the 1:*) relation wiht the resturant

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public List<OrderItem> OrderItems { get; set; } // I include this Navigatoin property from the order item table for (1:*) relationship with orderitem class


        public MenuItem()
        {
            OrderItems = new List<OrderItem>();
        }



    }
}
