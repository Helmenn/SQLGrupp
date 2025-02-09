﻿using SQL;

namespace DataInterface
{
    public interface IProvsvarManager
    {
        public Provsvar AddSkrivetProv(Prov prov, Student student);
        public void AddSvar(Provsvar provsvar, Fråga fråga, Svaralt svaralt);
        public void AddRättatSvar(int SvarID, int SvarAltID, bool Rätt);
        public void RättaProv(int provid, string studentName);

    }
}
