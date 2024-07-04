using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    public partial class seeding_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OpeningHours",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 7, 5, 0, 45, 56, 800, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 7, 5, 0, 45, 56, 800, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 7, 5, 0, 45, 56, 800, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 7, 5, 0, 45, 56, 800, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 7, 5, 0, 45, 56, 800, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2024, 7, 6, 0, 45, 56, 800, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2024, 7, 7, 0, 45, 56, 800, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2024, 7, 8, 0, 45, 56, 800, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2024, 7, 9, 0, 45, 56, 800, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2024, 7, 10, 0, 45, 56, 800, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "OpeningHours", "PhoneNumber" },
                values: new object[] { "9 AM - 9 PM", "111-222-3333" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "OpeningHours", "PhoneNumber" },
                values: new object[] { "10 AM - 10 PM", "222-333-4444" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "OpeningHours", "PhoneNumber" },
                values: new object[] { "8 AM - 8 PM", "333-444-5555" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4,
                columns: new[] { "OpeningHours", "PhoneNumber" },
                values: new object[] { "7 AM - 7 PM", "444-555-6666" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "OpeningHours", "PhoneNumber" },
                values: new object[] { "6 AM - 6 PM", "555-666-7777" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpeningHours",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Restaurants");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 7, 4, 23, 43, 44, 655, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 7, 4, 23, 43, 44, 655, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 7, 4, 23, 43, 44, 655, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 7, 4, 23, 43, 44, 655, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 7, 4, 23, 43, 44, 655, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2024, 7, 5, 23, 43, 44, 655, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2024, 7, 6, 23, 43, 44, 655, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2024, 7, 7, 23, 43, 44, 655, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2024, 7, 8, 23, 43, 44, 655, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2024, 7, 9, 23, 43, 44, 655, DateTimeKind.Local).AddTicks(2860));
        }
    }
}
