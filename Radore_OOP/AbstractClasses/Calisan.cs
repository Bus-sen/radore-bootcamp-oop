using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Abstract_Classes
{
    public abstract class Calisan
    {

        //bu class tan türeyen tüm classlar böyle bir metodun içini doldurmak zorundadır. 
        public abstract double maasinizNedir();
        public void mesaiyeBasla()
        {
            Console.WriteLine("mesaiye başlandı");
        }
    }
}
