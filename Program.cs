using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOBasicoPractica2
{
    class Program
    {
        static void Main(string[]args)
        {
            //Instanciacion
            Vehiculo vehiculo1 = new Vehiculo();

            vehiculo1.Motor = "Apagado";
            vehiculo1.TanqueGasolina = 5;
            vehiculo1.Velocidad = 0;
            

            Console.WriteLine(vehiculo1.Motor);
            vehiculo1.Disminuir();

            Console.WriteLine(vehiculo1.Velocidad);
            vehiculo1.Frenar();

            Console.WriteLine(vehiculo1.Velocidad);
            vehiculo1.Frenar();

            Console.WriteLine(vehiculo1.TanqueGasolina);
        }
    }
}
