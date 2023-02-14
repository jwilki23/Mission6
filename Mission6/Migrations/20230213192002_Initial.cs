using Microsoft.EntityFrameworkCore.Migrations;
//This page was made when I ran the migrations
namespace Mission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entries",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entries", x => x.EntryID);
                });

            migrationBuilder.InsertData(
                table: "entries",
                columns: new[] { "EntryID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Sci-Fi", "James Cameron", false, null, "Saw it twice in theaters", "PG-13", "Avatar: Way of Water", 2022 });

            migrationBuilder.InsertData(
                table: "entries",
                columns: new[] { "EntryID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Historical", "Angelina Jolie", false, "Mitchell", "Very inspirational", "PG-13", "Unbroken", 2014 });

            migrationBuilder.InsertData(
                table: "entries",
                columns: new[] { "EntryID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Joseph Kosinski", false, "Ryan", "Almost made me join AF", "PG-13", "Top Gun: Maverick", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entries");
        }
    }
}
