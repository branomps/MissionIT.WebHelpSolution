using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MissionIT.WebHelpCore.Data.Migrations.ModelHelp
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblSections",
                columns: table => new
                {
                    SectionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SectionName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSections", x => x.SectionID);
                });

            migrationBuilder.CreateTable(
                name: "tblArticles",
                columns: table => new
                {
                    ArticleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleName = table.Column<string>(maxLength: 100, nullable: false),
                    ArticleDescription = table.Column<string>(maxLength: 10000, nullable: false),
                    ArticleImageUrl = table.Column<string>(nullable: false),
                    SectionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArticles", x => x.ArticleID);
                    table.ForeignKey(
                        name: "FK_tblArticles_tblSections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "tblSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "tblSections",
                columns: new[] { "SectionID", "SectionName" },
                values: new object[,]
                {
                    { 1, "How to use Help" },
                    { 24, "Accounts" },
                    { 23, "Messaging" },
                    { 22, "All DBS Application" },
                    { 21, "Scheduling" },
                    { 20, "Work Shop" },
                    { 19, "Provider" },
                    { 18, "Vehicle" },
                    { 17, "Attendent" },
                    { 16, "Driver" },
                    { 15, "Passenger" },
                    { 14, "Exception" },
                    { 13, "Route" },
                    { 12, "Venue" },
                    { 11, "Lists" },
                    { 10, "Add New" },
                    { 9, "Jobs" },
                    { 8, "Quick Change" },
                    { 7, "Audit Trial" },
                    { 6, "User Diary" },
                    { 5, "My Favourites" },
                    { 4, "Customer Service" },
                    { 3, "Time Line" },
                    { 2, "Introduction" },
                    { 25, "Documents" },
                    { 26, "Utilities" }
                });

            migrationBuilder.InsertData(
                table: "tblArticles",
                columns: new[] { "ArticleID", "ArticleDescription", "ArticleImageUrl", "ArticleName", "SectionID" },
                values: new object[,]
                {
                    { 1, "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe", "010001.jpg", "Menu", 1 },
                    { 2, "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe", "010002.jpg", "Routes", 2 },
                    { 3, "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe", "010003.jpg", "Drivers", 2 },
                    { 4, "wssssssssssssssssssssssssssssssssssss", "020004.jpg", "Vehicles", 3 },
                    { 5, "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee", "020005.jpg", "Drivers", 3 },
                    { 6, "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe", "050006.jpg", "Audit Trial", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblArticles_SectionID",
                table: "tblArticles",
                column: "SectionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblArticles");

            migrationBuilder.DropTable(
                name: "tblSections");
        }
    }
}
