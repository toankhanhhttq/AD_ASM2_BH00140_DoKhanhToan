 using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tranning.Migrations
{
    /// <inheritdoc />
    public partial class CouresDBCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCourse = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "Varchar(200)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Vote = table.Column<int>(type: "int", nullable: false),
                    Avatar = table.Column<string>(type: "Varchar(200)", nullable: false),
                    Status = table.Column<int>(type: "Integer", nullable: false),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedAt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "Courses");
        }
    }
}
