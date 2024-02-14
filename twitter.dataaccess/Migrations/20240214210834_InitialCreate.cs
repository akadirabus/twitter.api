using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace twitter.dataaccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Hashtag",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RecordTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "GETDATE()"),
                    TweetCount = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hashtag_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UserName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    PersonelInformation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    MessageType = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tweet",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    DefTweetTypeId = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tweet_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tweet_DefTweetType_DefTweetTypeId",
                        column: x => x.DefTweetTypeId,
                        principalTable: "DefTweetType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tweet_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRelation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    FollowerId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follow_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRelation_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TweetHashtag",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TweetId = table.Column<long>(type: "bigint", nullable: false),
                    HasttagId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TweetHashtag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TweetHashtag_Hashtag_HasttagId",
                        column: x => x.HasttagId,
                        principalTable: "Hashtag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TweetHashtag_Tweet_TweetId",
                        column: x => x.TweetId,
                        principalTable: "Tweet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TweetUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TweetId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    DefActionTypeId = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TweetUser_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TweetUser_DefActionType_DefActionTypeId",
                        column: x => x.DefActionTypeId,
                        principalTable: "DefActionType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TweetUser_Tweet_TweetId",
                        column: x => x.TweetId,
                        principalTable: "Tweet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TweetUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserId",
                table: "Message",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_UserId",
                table: "Notification",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tweet_DefTweetTypeId",
                table: "Tweet",
                column: "DefTweetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tweet_UserId",
                table: "Tweet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TweetHashtag_HasttagId",
                table: "TweetHashtag",
                column: "HasttagId");

            migrationBuilder.CreateIndex(
                name: "IX_TweetHashtag_TweetId",
                table: "TweetHashtag",
                column: "TweetId");

            migrationBuilder.CreateIndex(
                name: "IX_TweetUser_DefActionTypeId",
                table: "TweetUser",
                column: "DefActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TweetUser_TweetId",
                table: "TweetUser",
                column: "TweetId");

            migrationBuilder.CreateIndex(
                name: "IX_TweetUser_UserId",
                table: "TweetUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelation_UserId",
                table: "UserRelation",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "TweetHashtag");

            migrationBuilder.DropTable(
                name: "TweetUser");

            migrationBuilder.DropTable(
                name: "UserRelation");

            migrationBuilder.DropTable(
                name: "Hashtag");

            migrationBuilder.DropTable(
                name: "DefActionType");

            migrationBuilder.DropTable(
                name: "Tweet");

            migrationBuilder.DropTable(
                name: "DefTweetType");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
