using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetsAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OwnerNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Conditions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatID);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OwnerNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Conditions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogID);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatID", "Age", "Breed", "Conditions", "Name", "OwnerName", "OwnerNumber", "Weight" },
                values: new object[,]
                {
                    { 1, 2, "Domestic Shorthair", "Healthy", "Fluffy", "John", "0821234567", 6 },
                    { 2, 5, "Ragdoll", "Diabetes", "Snowball", "Emily", "0721234567", 10 },
                    { 3, 1, "Russian Blue", "Malnourished", "Hercules", "Aldron", "0824567893", 5 }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogID", "Age", "Breed", "Conditions", "Name", "OwnerName", "OwnerNumber", "Weight" },
                values: new object[,]
                {
                    { 1, 2, "Husky", "Healthy", "Jasper", "Liam", "0821284567", 10 },
                    { 2, 10, "Boerbull", "Healthy - Elderly", "Bruno", "Luke", "0735849612", 9 },
                    { 3, 5, "Jack Russel", "Healthy", "Billy", "Alex", "0824569693", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
