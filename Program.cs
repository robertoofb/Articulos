using Artículos.Servicios;
using System;

namespace Artículos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Procedimientos objeto = new Procedimientos();
            objeto.CargarArticulos();
        }
    }
}
