using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface ICourseManager
    {
        public void AddCourse(string name, int roomid, string teacherName);
        public void AddStudentToCourse(string studentName, string courseName);
        public Courses GetCourseByName(string name);
  
    }
}
