using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BucketList.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "BucketDatas",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "BucketDatas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "BucketDatas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PeopleCount",
                table: "BucketDatas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "BucketDatas");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "BucketDatas");

            migrationBuilder.DropColumn(
                name: "PeopleCount",
                table: "BucketDatas");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "BucketDatas",
                newName: "Status");
        }
    }
}
