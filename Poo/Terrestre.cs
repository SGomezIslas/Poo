using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    //Herencia
    public class Terrestre : Transporte
    {
        public string camionNombre {  get; set; }
        //Constructor
        public Terrestre(string marca, string modelo) : base(marca, modelo)
        {
        }
        public override void Mover()
        {
            Console.WriteLine("El auto " + Marca + " Se mueve de manera rapida");
        }

    }
}
