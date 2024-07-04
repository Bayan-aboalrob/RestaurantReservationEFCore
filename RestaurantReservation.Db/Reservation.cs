using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RestaurantReservation.Db
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }// Fk

        public Restaurant Restaurant { get; set; } // navigation property for the 1:* with the resturant

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public int PartySize { get; set; }

        public List<Order> Orders { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }//FK

        public Customer Customer { get; set; } // Navigation property for 1:* with the customer table

        [ForeignKey("Table")]
        public int TableId { get; set; }// FK
        public Table Table { get; set; } // Naviagation property for the 1:* with the Table class



        public Reservation()
        {
            Orders = new List<Order>();
        }
    }
}
