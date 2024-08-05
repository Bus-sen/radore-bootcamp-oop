using Radore_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore.Classes
{
    // Anne classı Insan classından türemiştir
    // Anne classı Insan classındaki public olan tüm değişkenlere ve metodlara da erişebilir
    public class Anne : Insan, IOku, IYaz
    {
        public void oku(string isim)
        {
            Console.WriteLine(isim + " okuyor");
        }

        public void yaz(string isim)
        {
            Console.WriteLine(isim + " yazıyor");
        }

    }
}
