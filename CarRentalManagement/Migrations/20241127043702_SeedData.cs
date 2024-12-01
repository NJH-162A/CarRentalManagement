using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 27, 12, 37, 1, 226, DateTimeKind.Local).AddTicks(9747), new DateTime(2024, 11, 27, 12, 37, 1, 226, DateTimeKind.Local).AddTicks(9764), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 27, 12, 37, 1, 226, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 11, 27, 12, 37, 1, 226, DateTimeKind.Local).AddTicks(9769), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(86), new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(88), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(91), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(227), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(229), new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(230), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(233), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(235), new DateTime(2024, 11, 27, 12, 37, 1, 227, DateTimeKind.Local).AddTicks(235), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
