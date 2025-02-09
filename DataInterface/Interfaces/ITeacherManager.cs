﻿using System;
using SQL;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface ITeacherManager
    {
        public void AddTeacher(string teacherName);
        public Teacher GetTeacherByID(int TeacherID);
        public Teacher GetTeacherByName(string name);
    }
}
