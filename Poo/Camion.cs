using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Camion : Terrestre
    {
        public Camion(string marca, string modelo) : base(marca, modelo)
        {
            base.frenar();
        }

    }
}
