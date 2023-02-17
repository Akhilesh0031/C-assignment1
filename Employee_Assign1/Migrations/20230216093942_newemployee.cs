using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAssign1.Migrations
{
    /// <inheritdoc />
    public partial class newemployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailaddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mailingaddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
