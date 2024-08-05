using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Odevler.Odev1
{
    class Programci : BaseModel
    {
        public override void Calisanlar(string unvani, int maasi)
        {
            Console.WriteLine(unvani + "Programcı: " + maasi);
        }

        /*public override void MaasOde()
        {
        }*/
    }
}
