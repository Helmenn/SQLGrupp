using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class tobiasaddedcoursegradedetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Betygssgrad_Courses_CousesCourseID",
                table: "Betygssgrad");

            migrationBuilder.DropForeignKey(
                name: "FK_Svar_Provsvar_provsvarID",
                table: "Svar");

            migrationBuilder.DropIndex(
                name: "IX_Betygssgrad_CousesCourseID",
                table: "Betygssgrad");

            migrationBuilder.DropColumn(
                name: "CousesCourseID",
                table: "Betygssgrad");

            migrationBuilder.RenameColumn(
                name: "provsvarID",
                table: "Svar",
                newName: "ProvsvarID");

            migrationBuilder.RenameIndex(
                name: "IX_Svar_provsvarID",
                table: "Svar",
                newName: "IX_Svar_ProvsvarID");

            migrationBuilder.AddColumn<string>(
                name: "Betyg",
                table: "Betygssgrad",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoursesCourseID",
                table: "Betygssgrad",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Poäng",
                table: "Betygssgrad",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Betygssgrad_CoursesCourseID",
                table: "Betygssgrad",
                column: "CoursesCourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Betygssgrad_Courses_CoursesCourseID",
                table: "Betygssgrad",
                column: "CoursesCourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Svar_Provsvar_ProvsvarID",
                table: "Svar",
                column: "ProvsvarID",
                principalTable: "Provsvar",
                principalColumn: "ProvsvarID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Betygssgrad_Courses_CoursesCourseID",
                table: "Betygssgrad");

            migrationBuilder.DropForeignKey(
                name: "FK_Svar_Provsvar_ProvsvarID",
                table: "Svar");

            migrationBuilder.DropIndex(
                name: "IX_Betygssgrad_CoursesCourseID",
                table: "Betygssgrad");

            migrationBuilder.DropColumn(
                name: "Betyg",
                table: "Betygssgrad");

            migrationBuilder.DropColumn(
                name: "CoursesCourseID",
                table: "Betygssgrad");

            migrationBuilder.DropColumn(
                name: "Poäng",
                table: "Betygssgrad");

            migrationBuilder.RenameColumn(
                name: "ProvsvarID",
                table: "Svar",
                newName: "provsvarID");

            migrationBuilder.RenameIndex(
                name: "IX_Svar_ProvsvarID",
                table: "Svar",
                newName: "IX_Svar_provsvarID");

            migrationBuilder.AddColumn<int>(
                name: "CousesCourseID",
                table: "Betygssgrad",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Betygssgrad_CousesCourseID",
                table: "Betygssgrad",
                column: "CousesCourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Betygssgrad_Courses_CousesCourseID",
                table: "Betygssgrad",
                column: "CousesCourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Svar_Provsvar_provsvarID",
                table: "Svar",
                column: "provsvarID",
                principalTable: "Provsvar",
                principalColumn: "ProvsvarID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
