using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilas pilas = new Pilas(5);
            pilas.Agregar("David");
            pilas.Agregar("Jose");
            pilas.Imprimir();
            pilas.Eliminar();
            pilas.Imprimir();
            Console.ReadKey();
        }

    }
}
