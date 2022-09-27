using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApi.Migrations
{
    public partial class addedstudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstName = table.Column<string>(maxLength: 100, nullable: true),
                    middleName = table.Column<string>(maxLength: 100, nullable: true),
                    lastName = table.Column<string>(maxLength: 100, nullable: true),
                    mobile = table.Column<string>(maxLength: 12, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    age = table.Column<int>(nullable: false),
                    course = table.Column<string>(maxLength: 3, nullable: true),
                    address = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
