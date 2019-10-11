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
        public Fråga AddFråga(string text, int provID);
        public IQueryable<Fråga> GetFrågorByProvID(int provid);
        public void AddSvarAlt(string SvarAltText, bool Rätt, int FrågaID);
    }
}
