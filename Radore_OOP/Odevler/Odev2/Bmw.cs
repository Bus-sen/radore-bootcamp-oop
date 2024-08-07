using Radore_OOP.Odevler.Odev2.Cars_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Odevler.Odev2
{
    public class Bmw : Cars, IUc, IYuz, IGit
    {
        public override double benzinHarca()
        {
            return 60.0;
        }

        public void git(string marka)
        {
            Console.WriteLine(marka + " çok hızlı gidiyor");
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
