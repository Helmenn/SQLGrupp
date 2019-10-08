using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ver1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: true),
                    CourseRoom = table.Column<int>(nullable: false),
                    TeacherID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(nullable: true),
                    StudentAge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "Betygssgrad",
                columns: table => new
                {
                    BetygssgradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(nullable: false),
                    CousesCourseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Betygssgrad", x => x.BetygssgradID);
                    table.ForeignKey(
                        name: "FK_Betygssgrad_Courses_CousesCourseID",
                        column: x => x.CousesCourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prov",
                columns: table => new
                {
                    ProvID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Andel = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    CoursesCourseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prov", x => x.ProvID);
                    table.ForeignKey(
                        name: "FK_Prov_Courses_CoursesCourseID",
                        column: x => x.CoursesCourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentCourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => x.StudentCourseID);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradesName = table.Column<string>(nullable: true),
                    CourseID = table.Column<int>(nullable: false),
                    CoursesCourseID = table.Column<int>(nullable: true),
                    StudentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradesID);
                    table.ForeignKey(
                        name: "FK_Grades_Courses_CoursesCourseID",
                        column: x => x.CoursesCourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fråga",
                columns: table => new
                {
                    FrågaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrågText = table.Column<string>(nullable: true),
                    ProvID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fråga", x => x.FrågaID);
                    table.ForeignKey(
                        name: "FK_Fråga_Prov_ProvID",
                        column: x => x.ProvID,
                        principalTable: "Prov",
                        principalColumn: "ProvID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provsvar",
                columns: table => new
                {
                    ProvsvarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvID = table.Column<int>(nullable: false),
                    studentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provsvar", x => x.ProvsvarID);
                    table.ForeignKey(
                        name: "FK_Provsvar_Prov_ProvID",
                        column: x => x.ProvID,
                        principalTable: "Prov",
                        principalColumn: "ProvID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Provsvar_Students_studentID",
                        column: x => x.studentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Svaralt",
                columns: table => new
                {
                    SvaraltID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SvaraltText = table.Column<string>(nullable: true),
                    Rätt = table.Column<bool>(nullable: false),
                    FrågaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Svaralt", x => x.SvaraltID);
                    table.ForeignKey(
                        name: "FK_Svaralt_Fråga_FrågaID",
                        column: x => x.FrågaID,
                        principalTable: "Fråga",
                        principalColumn: "FrågaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provresultat",
                columns: table => new
                {
                    ProvresultatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Poäng = table.Column<int>(nullable: false),
                    ProvsvarID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provresultat", x => x.ProvresultatID);
                    table.ForeignKey(
                        name: "FK_Provresultat_Provsvar_ProvsvarID",
                        column: x => x.ProvsvarID,
                        principalTable: "Provsvar",
                        principalColumn: "ProvsvarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Svar",
                columns: table => new
                {
                    SvarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    provsvarID = table.Column<int>(nullable: false),
                    FrågaID = table.Column<int>(nullable: false),
                    SvaraltID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Svar", x => x.SvarID);
                    table.ForeignKey(
                        name: "FK_Svar_Fråga_FrågaID",
                        column: x => x.FrågaID,
                        principalTable: "Fråga",
                        principalColumn: "FrågaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Svar_Svaralt_SvaraltID",
                        column: x => x.SvaraltID,
                        principalTable: "Svaralt",
                        principalColumn: "SvaraltID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Svar_Provsvar_provsvarID",
                        column: x => x.provsvarID,
                        principalTable: "Provsvar",
                        principalColumn: "ProvsvarID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Betygssgrad_CousesCourseID",
                table: "Betygssgrad",
                column: "CousesCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Fråga_ProvID",
                table: "Fråga",
                column: "ProvID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_CoursesCourseID",
                table: "Grades",
                column: "CoursesCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentID",
                table: "Grades",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Prov_CoursesCourseID",
                table: "Prov",
                column: "CoursesCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Provresultat_ProvsvarID",
                table: "Provresultat",
                column: "ProvsvarID");

            migrationBuilder.CreateIndex(
                name: "IX_Provsvar_ProvID",
                table: "Provsvar",
                column: "ProvID");

            migrationBuilder.CreateIndex(
                name: "IX_Provsvar_studentID",
                table: "Provsvar",
                column: "studentID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseID",
                table: "StudentCourses",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Svar_FrågaID",
                table: "Svar",
                column: "FrågaID");

            migrationBuilder.CreateIndex(
                name: "IX_Svar_SvaraltID",
                table: "Svar",
                column: "SvaraltID");

            migrationBuilder.CreateIndex(
                name: "IX_Svar_provsvarID",
                table: "Svar",
                column: "provsvarID");

            migrationBuilder.CreateIndex(
                name: "IX_Svaralt_FrågaID",
                table: "Svaralt",
                column: "FrågaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Betygssgrad");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Provresultat");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Svar");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Svaralt");

            migrationBuilder.DropTable(
                name: "Provsvar");

            migrationBuilder.DropTable(
                name: "Fråga");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Prov");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
