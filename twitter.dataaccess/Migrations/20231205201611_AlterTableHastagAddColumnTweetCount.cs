using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace twitter.dataaccess.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableHastagAddColumnTweetCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TweetCount",
                table: "Hashtag",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TweetCount",
                table: "Hashtag");
        }
    }
}
