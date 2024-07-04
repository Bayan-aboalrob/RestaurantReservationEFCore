using System.ComponentModel.DataAnnotations;
namespace RestaurantReservation.Db
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }

        [Required]
        public int Capacity { get; set; }

        public List<Reservation> Reservations { get; set; }

        public int RestaurantId { get; set; } // FK

        public Restaurant Restaurant { get; set; } //Navigation property for the 1:* with the resturant table

        public Table() 
        {
            Reservations = new List<Reservation>();
        }
    }
}
