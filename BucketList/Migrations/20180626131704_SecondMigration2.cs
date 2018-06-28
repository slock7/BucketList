using Microsoft.EntityFrameworkCore.Migrations;

namespace BucketList.Migrations
{
    public partial class SecondMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "BucketDatas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "BucketDatas");
        }
    }
}
