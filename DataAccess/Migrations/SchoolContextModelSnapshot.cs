﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQL;

namespace DataAccess.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SQL.Betygssgrad", b =>
                {
                    b.Property<int>("BetygssgradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Betyg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("CoursesCourseID")
                        .HasColumnType("int");

                    b.Property<int>("Poäng")
                        .HasColumnType("int");

                    b.HasKey("BetygssgradID");

                    b.HasIndex("CoursesCourseID");

                    b.ToTable("Betygssgrad");
                });

            modelBuilder.Entity("SQL.Courses", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseRoom")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SQL.Fråga", b =>
                {
                    b.Property<int>("FrågaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FrågText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvID")
                        .HasColumnType("int");

                    b.HasKey("FrågaID");

                    b.HasIndex("ProvID");

                    b.ToTable("Fråga");
                });

            modelBuilder.Entity("SQL.Grades", b =>
                {
                    b.Property<int>("GradesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("CoursesCourseID")
                        .HasColumnType("int");

                    b.Property<string>("GradesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("GradesID");

                    b.HasIndex("CoursesCourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("SQL.Prov", b =>
                {
                    b.Property<int>("ProvID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Andel")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("CoursesCourseID")
                        .HasColumnType("int");

                    b.HasKey("ProvID");

                    b.HasIndex("CoursesCourseID");

                    b.ToTable("Prov");
                });

            modelBuilder.Entity("SQL.Provresultat", b =>
                {
                    b.Property<int>("ProvresultatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Poäng")
                        .HasColumnType("int");

                    b.Property<int>("ProvsvarID")
                        .HasColumnType("int");

                    b.HasKey("ProvresultatID");

                    b.HasIndex("ProvsvarID");

                    b.ToTable("Provresultat");
                });

            modelBuilder.Entity("SQL.Provsvar", b =>
                {
                    b.Property<int>("ProvsvarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProvID")
                        .HasColumnType("int");

                    b.Property<int>("studentID")
                        .HasColumnType("int");

                    b.HasKey("ProvsvarID");

                    b.HasIndex("ProvID");

                    b.HasIndex("studentID");

                    b.ToTable("Provsvar");
                });

            modelBuilder.Entity("SQL.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StudentAge")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SQL.StudentCourse", b =>
                {
                    b.Property<int>("StudentCourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("StudentCourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("SQL.Svar", b =>
                {
                    b.Property<int>("SvarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FrågaID")
                        .HasColumnType("int");

                    b.Property<int>("ProvsvarID")
                        .HasColumnType("int");

                    b.Property<int>("SvaraltID")
                        .HasColumnType("int");

                    b.HasKey("SvarID");

                    b.HasIndex("FrågaID");

                    b.HasIndex("ProvsvarID");

                    b.HasIndex("SvaraltID");

                    b.ToTable("Svar");
                });

            modelBuilder.Entity("SQL.Svaralt", b =>
                {
                    b.Property<int>("SvaraltID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FrågaID")
                        .HasColumnType("int");

                    b.Property<bool>("Rätt")
                        .HasColumnType("bit");

                    b.Property<string>("SvaraltText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SvaraltID");

                    b.HasIndex("FrågaID");

                    b.ToTable("Svaralt");
                });

            modelBuilder.Entity("SQL.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SQL.Betygssgrad", b =>
                {
                    b.HasOne("SQL.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CoursesCourseID");
                });

            modelBuilder.Entity("SQL.Fråga", b =>
                {
                    b.HasOne("SQL.Prov", "Prov")
                        .WithMany()
                        .HasForeignKey("ProvID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SQL.Grades", b =>
                {
                    b.HasOne("SQL.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CoursesCourseID");

                    b.HasOne("SQL.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SQL.Prov", b =>
                {
                    b.HasOne("SQL.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CoursesCourseID");
                });

            modelBuilder.Entity("SQL.Provresultat", b =>
                {
                    b.HasOne("SQL.Provsvar", "Provsvar")
                        .WithMany()
                        .HasForeignKey("ProvsvarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SQL.Provsvar", b =>
                {
                    b.HasOne("SQL.Prov", "Prov")
                        .WithMany()
                        .HasForeignKey("ProvID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQL.Student", "Student")
                        .WithMany()
                        .HasForeignKey("studentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SQL.StudentCourse", b =>
                {
                    b.HasOne("SQL.Courses", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SQL.Svar", b =>
                {
                    b.HasOne("SQL.Fråga", "Fråga")
                        .WithMany()
                        .HasForeignKey("FrågaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQL.Provsvar", "Provsvar")
                        .WithMany()
                        .HasForeignKey("ProvsvarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SQL.Svaralt", "Svaralt")
                        .WithMany()
                        .HasForeignKey("SvaraltID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SQL.Svaralt", b =>
                {
                    b.HasOne("SQL.Fråga", "Fråga")
                        .WithMany()
                        .HasForeignKey("FrågaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
