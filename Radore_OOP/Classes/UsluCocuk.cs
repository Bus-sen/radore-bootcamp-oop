using Radore.Classes;
using Radore_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Classes
{
    public class UsluCocuk : Cocuk, IDinle, IYaz
    {
        public void dinle(string isim)
        {
            Console.WriteLine(isim + " dinliyor");
        }

        public void yaz(string isim)
        {
            Console.WriteLine(isim + " yazıyor");
        }
    }
}
