using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db
{
    public class RestaurantReservationDbContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             "Data Source=DESKTOP-HOSEMG4;Initial Catalog=RestaurantReservationCore;Integrated Security=True;TrustServerCertificate=True;"
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.HasData(
                    new Restaurant
                    {
                        RestaurantId = 1,
                        Name = "Good Eats",
                        PhoneNumber = "111-222-3333",
                        OpeningHours = "9 AM - 9 PM",
                        Address = "123 Main St, Anytown, Anystate, 12345"
                    },
                    new Restaurant
                    {
                        RestaurantId = 2,
                        Name = "Tasty Treats",
                        PhoneNumber = "222-333-4444",
                        OpeningHours = "10 AM - 10 PM",
                        Address = "456 Elm St, Othertown, Otherstate, 23456"
                    },
                    new Restaurant
                    {
                        RestaurantId = 3,
                        Name = "Yummy Bites",
                        PhoneNumber = "333-444-5555",
                        OpeningHours = "8 AM - 8 PM",
                        Address = "789 Oak St, Anothertown, Anotherstate, 34567"
                    },
                    new Restaurant
                    {
                        RestaurantId = 4,
                        Name = "Delicious Dishes",
                        PhoneNumber = "444-555-6666",
                        OpeningHours = "7 AM - 7 PM",
                        Address = "101 Pine St, Anycity, Anystate, 45678"
                    },
                    new Restaurant
                    {
                        RestaurantId = 5,
                        Name = "Savory Snacks",
                        PhoneNumber = "555-666-7777",
                        OpeningHours = "6 AM - 6 PM",
                        Address = "202 Maple St, Othercity, Otherstate, 56789"
                    }
                );
            });

            modelBuilder.Entity<MenuItem>()
                .Property(m => m.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Customer)
                .WithMany(c => c.Reservations)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Restaurant)
                .WithMany(res => res.Reservations)
                .HasForeignKey(r => r.RestaurantId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Table)
                .WithMany(t => t.Reservations)
                .HasForeignKey(r => r.TableId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Employee)
                .WithMany(e => e.Orders)
                .HasForeignKey(o => o.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Reservation)
                .WithMany(r => r.Orders)
                .HasForeignKey(o => o.ReservationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.MenuItem)
                .WithMany(mi => mi.OrderItems)
                .HasForeignKey(oi => oi.ItemId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890" },
                new Customer { CustomerId = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", PhoneNumber = "2345678901" },
                new Customer { CustomerId = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", PhoneNumber = "3456789012" },
                new Customer { CustomerId = 4, FirstName = "Bob", LastName = "Brown", Email = "bob.brown@example.com", PhoneNumber = "4567890123" },
                new Customer { CustomerId = 5, FirstName = "Charlie", LastName = "Davis", Email = "charlie.davis@example.com", PhoneNumber = "5678901234" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, FirstName = "Anna", LastName = "Bell", Position = "Manager", RestaurantId = 1 },
                new Employee { EmployeeId = 2, FirstName = "Brian", LastName = "Clark", Position = "Chef", RestaurantId = 2 },
                new Employee { EmployeeId = 3, FirstName = "Catherine", LastName = "Davis", Position = "Waiter", RestaurantId = 3 },
                new Employee { EmployeeId = 4, FirstName = "David", LastName = "Evans", Position = "Manager", RestaurantId = 4 },
                new Employee { EmployeeId = 5, FirstName = "Eleanor", LastName = "Ford", Position = "Chef", RestaurantId = 5 }
            );

            modelBuilder.Entity<Table>().HasData(
                new Table { TableId = 1, Capacity = 4, RestaurantId = 1 },
                new Table { TableId = 2, Capacity = 6, RestaurantId = 2 },
                new Table { TableId = 3, Capacity = 8, RestaurantId = 3 },
                new Table { TableId = 4, Capacity = 4, RestaurantId = 4 },
                new Table { TableId = 5, Capacity = 6, RestaurantId = 5 }
            );

            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { ItemId = 1, Name = "Burger", Description = "Delicious beef burger", Price = 9.99m, RestaurantId = 1 },
                new MenuItem { ItemId = 2, Name = "Pizza", Description = "Cheesy pizza with toppings", Price = 12.99m, RestaurantId = 2 },
                new MenuItem { ItemId = 3, Name = "Salad", Description = "Fresh garden salad", Price = 7.99m, RestaurantId = 3 },
                new MenuItem { ItemId = 4, Name = "Pasta", Description = "Creamy Alfredo pasta", Price = 11.99m, RestaurantId = 4 },
                new MenuItem { ItemId = 5, Name = "Steak", Description = "Grilled steak with sides", Price = 19.99m, RestaurantId = 5 }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { ReservationId = 1, CustomerId = 1, RestaurantId = 1, TableId = 1, ReservationDate = DateTime.Now.AddDays(1), PartySize = 4 },
                new Reservation { ReservationId = 2, CustomerId = 2, RestaurantId = 2, TableId = 2, ReservationDate = DateTime.Now.AddDays(2), PartySize = 6 },
                new Reservation { ReservationId = 3, CustomerId = 3, RestaurantId = 3, TableId = 3, ReservationDate = DateTime.Now.AddDays(3), PartySize = 8 },
                new Reservation { ReservationId = 4, CustomerId = 4, RestaurantId = 4, TableId = 4, ReservationDate = DateTime.Now.AddDays(4), PartySize = 4 },
                new Reservation { ReservationId = 5, CustomerId = 5, RestaurantId = 5, TableId = 5, ReservationDate = DateTime.Now.AddDays(5), PartySize = 6 }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, ReservationId = 1, EmployeeId = 1, OrderDate = DateTime.Now, TotalAmount = 39.96m },
                new Order { OrderId = 2, ReservationId = 2, EmployeeId = 2, OrderDate = DateTime.Now, TotalAmount = 77.94m },
                new Order { OrderId = 3, ReservationId = 3, EmployeeId = 3, OrderDate = DateTime.Now, TotalAmount = 63.92m },
                new Order { OrderId = 4, ReservationId = 4, EmployeeId = 4, OrderDate = DateTime.Now, TotalAmount = 47.96m },
                new Order { OrderId = 5, ReservationId = 5, EmployeeId = 5, OrderDate = DateTime.Now, TotalAmount = 99.95m }
            );

            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { OrderItemId = 1, OrderId = 1, ItemId = 1, Quantity = 4 },
                new OrderItem { OrderItemId = 2, OrderId = 2, ItemId = 2, Quantity = 6 },
                new OrderItem { OrderItemId = 3, OrderId = 3, ItemId = 3, Quantity = 8 },
                new OrderItem { OrderItemId = 4, OrderId = 4, ItemId = 4, Quantity = 4 },
                new OrderItem { OrderItemId = 5, OrderId = 5, ItemId = 5, Quantity = 5 }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
