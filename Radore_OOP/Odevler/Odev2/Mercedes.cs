using Radore_OOP.Odevler.Odev2.Cars_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Odevler.Odev2
{
    public class Mercedes : Cars, IUc, IYuz
    {
        public override double benzinHarca()
        {
            return 70.0;
        }

        public void uc(string marka)
        {
            Console.WriteLine(marka + " havada uçuyor");
        }

        public void yuz(string marka)
        {
            Console.WriteLine(marka + " denizde yüzüyor");
        }
    }
}
