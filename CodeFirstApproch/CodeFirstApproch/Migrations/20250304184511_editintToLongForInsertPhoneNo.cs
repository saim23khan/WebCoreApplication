using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApproch.Migrations
{
    /// <inheritdoc />
    public partial class editintToLongForInsertPhoneNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "GurdianContactNo",
                table: "Students",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GurdianContactNo",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
