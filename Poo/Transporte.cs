using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Transporte
    {
        //Propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string CamionNombre { get; set; }
        //Constructor
        public Transporte(string marca, string modelo)  //Constructor
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        //Metodo
        public virtual void Mover()
        {
            Console.WriteLine("El " + Marca + " Se encuentra en movimiento");
        }
        public virtual void frenar()
        {
            Console.WriteLine("El " + CamionNombre + " tiene frenos abs");
        }
    }
}
