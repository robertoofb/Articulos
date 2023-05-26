using Artículos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artículos.Servicios
{
    public class Procedimientos
    {
        public void CargarArticulos()
        {
            Persona persona = new Persona();
            persona.CargarDatos();
            Console.WriteLine("----------------------------------------------");
            Console.Write("Ingresa el precio del primero artículo: ");
            persona.Art1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el precio del segundo artículo: ");
            persona.Art2 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el precio del tercer artículo: ");
            persona.Art3 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el precio del cuarto artículo: ");
            persona.Art4 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el precio del quinto artículo: ");
            persona.Art5 = int.Parse(Console.ReadLine());
            Console.Clear();

            persona.Total = persona.Art1 + persona.Art2 + persona.Art3 + persona.Art4 + persona.Art5;

            if (persona.Total >= 10000)
            {
                Console.WriteLine("Tu compra supera los 10000, como recompensa te otorgamos 6 o 12 meses sin intereses");
                Console.WriteLine("Selecciona la opción que deseas: ");
                Console.WriteLine("1. 6 meses            2. 12 meses");
                int decision = int.Parse(Console.ReadLine());
                if (decision == 1)
                {
                    double seis = persona.Total / 6;
                    Console.WriteLine("Has seleccionado 6 meses, estarás pagando mensualmente: $" + seis);
                }
                else if (decision == 2)
                {
                    double doce = persona.Total / 12;
                    Console.WriteLine("Has seleccionado 12 meses, estarás pagando mensualmente: $" + doce);
                }
            }
            else if (persona.Total >= 8000)
            {
                Console.WriteLine("Tu compra supera los 8000, como recompensa te otorgamos 3 meses sin intereses");
                double tres = persona.Total / 3;
                Console.WriteLine("Estarás pagando mensualmente: $" + tres);
            }
            else if (persona.Total >= 5000)
            {
                Console.WriteLine("Tu compra supera los 5000, como recompensa te otorgamos 10% de descuento");
                double diez = persona.Total - (persona.Total * .10);
                Console.WriteLine("El total a pagar será: $" + diez);
            }
            else if (persona.Total < 5000)
            {
                Console.WriteLine("Ni modo, no hay descuento mi rey :p");
            }
            Console.WriteLine();
            persona.MostrarDatos();
        }
    }
}
