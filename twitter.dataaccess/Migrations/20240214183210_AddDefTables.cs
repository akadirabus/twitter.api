using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace twitter.dataaccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDefTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTweet");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordTime",
                table: "User",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddColumn<long>(
                name: "DefTweetTypeId",
                table: "Tweet",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "DefTweetTypeId1",
                table: "Tweet",
                type: "smallint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DefActionType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefActionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DefTweetType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefTweetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTweetAction",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    TweetId = table.Column<long>(type: "bigint", nullable: false),
                    DefActionTypeId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTweetAction_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTweetAction_DefActionType_DefActionTypeId",
                        column: x => x.DefActionTypeId,
                        principalTable: "DefActionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTweetAction_Tweet_TweetId",
                        column: x => x.TweetId,
                        principalTable: "Tweet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTweetAction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tweet_DefTweetTypeId1",
                table: "Tweet",
                column: "DefTweetTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserTweetAction_DefActionTypeId",
                table: "UserTweetAction",
                column: "DefActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTweetAction_TweetId",
                table: "UserTweetAction",
                column: "TweetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTweetAction_UserId",
                table: "UserTweetAction",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tweet_DefTweetType_DefTweetTypeId1",
                table: "Tweet",
                column: "DefTweetTypeId1",
                principalTable: "DefTweetType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tweet_DefTweetType_DefTweetTypeId1",
                table: "Tweet");

            migrationBuilder.DropTable(
                name: "DefTweetType");

            migrationBuilder.DropTable(
                name: "UserTweetAction");

            migrationBuilder.DropTable(
                name: "DefActionType");

            migrationBuilder.DropIndex(
                name: "IX_Tweet_DefTweetTypeId1",
                table: "Tweet");

            migrationBuilder.DropColumn(
                name: "DefTweetTypeId",
                table: "Tweet");

            migrationBuilder.DropColumn(
                name: "DefTweetTypeId1",
                table: "Tweet");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordTime",
                table: "User",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.CreateTable(
                name: "UserTweet",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TweetId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTweet_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTweet_Tweet_TweetId",
                        column: x => x.TweetId,
                        principalTable: "Tweet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTweet_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTweet_TweetId",
                table: "UserTweet",
                column: "TweetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTweet_UserId",
                table: "UserTweet",
                column: "UserId");
        }
    }
}
