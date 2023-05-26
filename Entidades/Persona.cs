using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artículos.Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Teléfono { get; set; }
        public string Correo { get; set; }
        public double Art1 { get; set; }
        public double Art2 { get; set; }
        public double Art3 { get; set; }
        public double Art4 { get; set; }
        public double Art5 { get; set; }
        public double Total { get; set; }

        public void CargarDatos()
        {
            Console.WriteLine("Hola, necesito pedirte los siguientes datos:");
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Teléfono: ");
            Teléfono = Console.ReadLine();
            Console.Write("Correo: ");
            Correo = Console.ReadLine();
        }
        public void MostrarDatos()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Los datos de la persona son los siguientes:");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Teléfono: " + Teléfono);
            Console.WriteLine("Correo: " + Correo);
        }
    }
}
