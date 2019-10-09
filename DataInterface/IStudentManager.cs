using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
   public interface IStudentManager
    {
        public void AddStudent(string StudentName, int StudentAge);

        public Student GetStudentByID(int studentID);
        public Student GetStudentByName(string name);
    }
}
