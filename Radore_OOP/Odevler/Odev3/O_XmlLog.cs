﻿using Radore_OOP.Odevler.Odev3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Odevler.Odev3
{
    public class O_XmlLog : ILog
    {
        public void LogYaz(string mesaj)
        {
            Console.WriteLine(mesaj +" xml e kaydedildi");
        }
    }
}
