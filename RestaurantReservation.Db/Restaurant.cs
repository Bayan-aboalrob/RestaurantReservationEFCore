using System.ComponentModel.DataAnnotations;
namespace RestaurantReservation.Db
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }

        [Required]
        public string Name { get; set; }

        public Address Address;

        [Required]
        public string PhoneNumber;

        [Required]
        public string OpeningHours;

        public List<Employee> Employees;

        public List<MenuItem> MenuItems;
        
        public List<Reservation> Reservations;

        public List<Table> Tables;

        public Restaurant()
        {
            Employees = new List<Employee>();
            MenuItems = new List<MenuItem>();
            Reservations = new List<Reservation>();
            Tables = new List<Table>();
        }

    }
}
