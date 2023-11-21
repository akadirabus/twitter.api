using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace twitter.dataaccess.Migrations
{
    /// <inheritdoc />
    public partial class UserTweetAddColumnType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "UserTweet",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "UserTweet");
        }
    }
}
