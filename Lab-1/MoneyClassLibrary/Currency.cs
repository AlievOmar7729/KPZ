﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyClassLibrary
{
    public class Currency
    {
        public string Symbol { get; }

        public Currency(string symbol)
        {
            Symbol = symbol;
        }
    }
}
