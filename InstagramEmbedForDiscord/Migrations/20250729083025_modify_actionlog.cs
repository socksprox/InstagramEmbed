using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstagramEmbedForDiscord.Migrations
{
    /// <inheritdoc />
    public partial class modify_actionlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "ActionLogs");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "ActionLogs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ActionLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "ActionLogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
