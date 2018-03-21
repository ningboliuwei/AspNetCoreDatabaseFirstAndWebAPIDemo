using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetCoreDatabaseFirstAndWebAPIDemo.Migrations
{
    public partial class changeback2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usernames",
                table: "users",
                newName: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
