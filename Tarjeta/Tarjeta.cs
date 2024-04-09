using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjeta
{
    public class Tarjeta
    {
        //Atributo
        int CVV;

        //Propiedades
        public int Numero { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Nombre { get; set; }
        private string Banco { get; set; }

        //Sobrecargar de constructor  
        public Tarjeta() 
        {
        
        }


        //Constructor

        public Tarjeta(int Numero, DateTime FechaVencimiento, string Nombre)
        {
            this.Numero = Numero;
            this.FechaVencimiento = FechaVencimiento;
            this.Nombre = Nombre;
        }
        //Herencia

        //Polimorfismo
        public static void GenerarCvv()
        {

        }
        public virtual void GenerarCvv(int Cvv)
        {

        }

    }

    public class TarjetaCredito : Tarjeta
    {
        public TarjetaCredito(int Numero, DateTime FechaVencimiento, string Nombre) : base(Numero, FechaVencimiento, Nombre)
        {
        }
        //SobreEscritura
        public override void GenerarCvv(int Cvv)
        {
            base.GenerarCvv(Cvv);
        }
    }

    public class TarjetaDebito : Tarjeta
    {
        public TarjetaDebito(int Numero, DateTime FechaVencimiento, string Nombre) : base(Numero, FechaVencimiento, Nombre)
        {
        }
    }

    public  class TarjetaPuntos : Tarjeta
    {

    }

    public class TarjetaAhorra : TarjetaDebito
    {
        public TarjetaAhorra(int Numero, DateTime FechaVencimiento, string Nombre) : base(Numero, FechaVencimiento, Nombre)
        {
        }
    }



}
