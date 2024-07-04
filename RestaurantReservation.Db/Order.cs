using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RestaurantReservation.Db
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }//FK

        public Employee Employee { get; set; } // navigation propert for 1:* with employee table

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        public Reservation Reservation { get; set; }

        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }



    }
}
