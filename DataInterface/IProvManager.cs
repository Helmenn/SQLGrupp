using SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataInterface
{
    public interface IProvManager
    {
        public Prov AddProv(int Andel, string CourseName);
        public Prov GetProv(int id);
        // Flyttad från IFrågaManager
        public Fråga AddFråga(string text, int provID);
        //FLyttad från IFrågaManager
        public IQueryable<Fråga> GetFrågorByProvID(int provid);
        // Flyttad från ISvarALtManager
        public void AddSvarAlt(string SvarAltText, bool Rätt, int FrågaID);
    }
}
