using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetCoreDatabaseFirstAndWebAPIDemo.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Blog_BlogId",
                table: "posts");

            migrationBuilder.DropTable(
                name: "attachements");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Realname",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "blogs");

            migrationBuilder.RenameColumn(
                name: "Conent",
                table: "posts",
                newName: "Content");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "posts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishTime",
                table: "posts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "blogs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_posts_BlogId",
                table: "posts",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_blogs_BlogId",
                table: "posts",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_blogs_BlogId",
                table: "posts");

            migrationBuilder.DropIndex(
                name: "IX_posts_BlogId",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "PublishTime",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "blogs");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "posts",
                newName: "Conent");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Realname",
                table: "users",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "posts",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "posts",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "blogs",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "attachements",
                columns: table => new
                {
                    AttachmentId = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Filename = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attachements", x => x.AttachmentId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Blog_BlogId",
                table: "posts",
                column: "PostId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
