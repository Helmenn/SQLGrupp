using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface IFrågaManager
    {
        public void AddFråga(string text, int provID);
    }
}
