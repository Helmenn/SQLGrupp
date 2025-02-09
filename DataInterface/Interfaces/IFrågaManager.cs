﻿using SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataInterface
{
    public interface IFrågaManager
    {
        public Fråga AddFråga(string text, int provID);
        public IQueryable<Fråga> GetFrågorByProvID(int provid);
    }
}
