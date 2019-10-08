using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface IGradesManager
    {
        public void AddGrade(string gradeName, int courseID, int studentID);
    }
}
