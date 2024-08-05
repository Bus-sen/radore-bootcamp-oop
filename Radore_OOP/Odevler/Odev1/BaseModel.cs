using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Odevler.Odev1
{
    abstract class BaseModel
    {
        public int maas;
        public string unvan;
        abstract public void Calisanlar(string unvani, int maasi);
    }


}
