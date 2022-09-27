using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatSinghv6.Migrations
{
    public partial class company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company");

            migrationBuilder.RenameColumn(
                name: "IndustryId",
                table: "Company",
                newName: "IndustryID");

            migrationBuilder.RenameIndex(
                name: "IX_Company_IndustryId",
                table: "Company",
                newName: "IX_Company_IndustryID");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryID",
                table: "Company",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Industry_IndustryID",
                table: "Company",
                column: "IndustryID",
                principalTable: "Industry",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_IndustryID",
                table: "Company");

            migrationBuilder.RenameColumn(
                name: "IndustryID",
                table: "Company",
                newName: "IndustryId");

            migrationBuilder.RenameIndex(
                name: "IX_Company_IndustryID",
                table: "Company",
                newName: "IX_Company_IndustryId");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
