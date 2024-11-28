using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLUCION
{
    public class Tussi
    {
        public int PrecioT { get; set; }
        public string Color { get; set; }

        public void Crear2()
        {
            Console.WriteLine("Ingresa el precio:");
            PrecioT = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el color");
            Color = Console.ReadLine();
        }
        public override string ToString()
        {
            return "Precio: " + PrecioT + "Calidad: " + Color;
        }
    }
}
