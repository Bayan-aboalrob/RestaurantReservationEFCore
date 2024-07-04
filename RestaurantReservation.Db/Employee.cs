using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantReservation.Db
{
    public class Employee
    {
        [Key]
        public int EmployeeId {  get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        // I was confused whether to define it as an enum or as a string to ensure the felixiblity if any changes made to the positions in the resturant
        [Required]
        public string Position {  get; set; }
        public Restaurant Restaurant { get; set; } // I included this navigation property to represent the 1:* relationship btwn resturant and employee classes

       public List<Order> Orders { get; set; }

        public Employee()
        {
            Orders= new List<Order>();
        }

    }
}
