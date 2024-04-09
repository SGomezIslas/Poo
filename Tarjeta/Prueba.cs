using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjeta
{
    public class Prueba
    {
        public int id { get; set; }
        public int id2 { get; set; }

        public Prueba() { }

        public Prueba(int id, int id2)
        {
            this.id = id;
            this.id2 = id2;
        }
    }


    public class Prueba2 : Prueba
    {

    }

}
