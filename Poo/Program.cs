namespace Poo;
public class Program
{
    static void Main(string[] args)
    {
        Terrestre terrestre = new Terrestre("Chevrolet", "Aveo");
        Aereo aereo = new Aereo("Boeing", "747");
        Camion camion = new Camion("ADO", "235");
        //llamar al metodo mover
        terrestre.Mover();
    }
}
