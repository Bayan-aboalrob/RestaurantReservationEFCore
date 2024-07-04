﻿using System.ComponentModel.DataAnnotations;
namespace RestaurantReservation.Db
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; }

        [Required,EmailAddress]

        public string Email { get; set; }

        [Required,Phone]
        public string PhoneNumber { get; set; }

        public List<Reservation> Reservations { get; set; }

        public Customer()
        {
            Reservations = new List<Reservation>();

        }

    }
}
