namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var schoolContext = new SchoolContext())
            {
                
                #region Kurser
                var courses = new Courses();
                courses.CourseName = "C#";
                courses.CourseRoom = 101;
                courses.TeacherID = 1;
                schoolContext.Courses.Add(courses);

                courses = new Courses();
                courses.CourseName = ".NET";
                courses.CourseRoom = 102;
                courses.TeacherID = 2;
                schoolContext.Courses.Add(courses);

                courses = new Courses();
                courses.CourseName = "HTML";
                courses.CourseRoom = 103;
                courses.TeacherID = 3;
                schoolContext.Courses.Add(courses);

                courses = new Courses();
                courses.CourseName = "CSS";
                courses.CourseRoom = 104;
                courses.TeacherID = 3;
                schoolContext.Courses.Add(courses);
                #endregion

                #region Studentnamn
                var student = new Student();
                student.StudentName = "Leif";
                student.StudentAge = 19;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Christer";
                student.StudentAge = 22;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Hasse";
                student.StudentAge = 20;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Johan";
                student.StudentAge = 28;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Janne";
                student.StudentAge = 20;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Håkan";
                student.StudentAge = 19;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Johnny";
                student.StudentAge = 20;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Olof";
                student.StudentAge = 28;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Anna";
                student.StudentAge = 31;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Gunnar";
                student.StudentAge = 40;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Eva";
                student.StudentAge = 24;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Anders";
                student.StudentAge = 19;
                schoolContext.Students.Add(student);

                #endregion

                #region Lärare
                var teacher = new Teacher();
                teacher.TeacherName = "lärare1";
                schoolContext.Teachers.Add(teacher);

                teacher = new Teacher();
                teacher.TeacherName = "lärare2";
                schoolContext.Teachers.Add(teacher);

                teacher = new Teacher();
                teacher.TeacherName = "lärare3";
                schoolContext.Teachers.Add(teacher);
                schoolContext.SaveChanges();
                #endregion
                
                /*
                var studentsInCourseOne = (from s in schoolContext.Students
                                           join c in schoolContext.Courses
                                           on s.CourseID equals c.CourseID
                                           where c.Name == "Kurs"
                                           select s);

                foreach (var studentInClass in studentsInCourseOne)
                    Console.WriteLine(studentInClass.Name);
                Console.ReadLine();
                */
            }
        }
    }
}
