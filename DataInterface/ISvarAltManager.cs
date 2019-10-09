using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface ISvarAltManger
    {
        public void AddSvarAlt(string SvarAltText, bool Rätt, int FrågaID);
    }
}
