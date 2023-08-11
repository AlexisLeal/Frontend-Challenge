using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blogers.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "auth",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    pass = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__auth__3213E83F9BBE2922", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "blogger",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    website = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    picture_url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__blogger__3213E83F14B0A831", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "friendship",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bloggerid = table.Column<int>(type: "int", nullable: true),
                    friendID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__friendsh__3213E83F70BD3C06", x => x.id);
                    table.ForeignKey(
                        name: "FK__friendshi__blogg__3A81B327",
                        column: x => x.bloggerid,
                        principalTable: "blogger",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__friendshi__frien__3B75D760",
                        column: x => x.friendID,
                        principalTable: "blogger",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "UQ__blogger__AB6E6164C824D4EE",
                table: "blogger",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_friendship_bloggerid",
                table: "friendship",
                column: "bloggerid");

            migrationBuilder.CreateIndex(
                name: "IX_friendship_friendID",
                table: "friendship",
                column: "friendID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "auth");

            migrationBuilder.DropTable(
                name: "friendship");

            migrationBuilder.DropTable(
                name: "blogger");
        }
    }
}
