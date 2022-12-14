using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCandidates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fullName = table.Column<string>(maxLength: 100, nullable: true),
                    mobile = table.Column<string>(maxLength: 12, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    age = table.Column<int>(nullable: false),
                    bloodGroup = table.Column<string>(maxLength: 3, nullable: true),
                    address = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCandidates", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DCandidates");
        }
    }
}
