using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatSinghv6.Migrations
{
    public partial class candidates1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_JobTitleId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "JobTitleId",
                table: "Candidate");

            migrationBuilder.RenameColumn(
                name: "IndustryId",
                table: "Candidate",
                newName: "IndustryID");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Candidate",
                newName: "CompanyID");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_IndustryId",
                table: "Candidate",
                newName: "IX_Candidate_IndustryID");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate",
                newName: "IX_Candidate_CompanyID");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryID",
                table: "Candidate",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "JobID",
                table: "Candidate",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_JobID",
                table: "Candidate",
                column: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Company_CompanyID",
                table: "Candidate",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Industry_IndustryID",
                table: "Candidate",
                column: "IndustryID",
                principalTable: "Industry",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_JobTitle_JobID",
                table: "Candidate",
                column: "JobID",
                principalTable: "JobTitle",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Company_CompanyID",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryID",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_JobID",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_JobID",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "JobID",
                table: "Candidate");

            migrationBuilder.RenameColumn(
                name: "IndustryID",
                table: "Candidate",
                newName: "IndustryId");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "Candidate",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_IndustryID",
                table: "Candidate",
                newName: "IX_Candidate_IndustryId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_CompanyID",
                table: "Candidate",
                newName: "IX_Candidate_CompanyId");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobTitleId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_JobTitleId",
                table: "Candidate",
                column: "JobTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
