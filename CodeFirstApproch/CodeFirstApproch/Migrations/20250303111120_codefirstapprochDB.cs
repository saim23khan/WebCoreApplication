using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApproch.Migrations
{
    /// <inheritdoc />
    public partial class codefirstapprochDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudenName = table.Column<string>(type: "varchar(100)", nullable: false),
                    FatherName = table.Column<string>(type: "varchar(100)", nullable: false),
                    StudenGender = table.Column<string>(type: "varchar(10)", nullable: false),
                    GurdianContactNo = table.Column<int>(type: "int", nullable: false),
                    StudenClass = table.Column<string>(type: "varchar(50)", nullable: false),
                    StudenAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
