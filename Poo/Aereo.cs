using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Aereo : Transporte
    {
        //Constructor 
        public Aereo(string marca, string modelo) : base(marca, modelo)
        {
            base.Mover();
        }

    }
}
