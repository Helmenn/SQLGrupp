using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface IProvManager
    {
        public void AddProv(int Andel, int CourseID, int ProvresultatID, int ProvsvarID,int RättatSvarID,int SvarID,int SvarAltID);

        public void RättaProv(int provID, int studentID);

    }
}
