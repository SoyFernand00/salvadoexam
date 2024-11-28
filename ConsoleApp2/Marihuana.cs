using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SOLUCION
{
    public class Marihuana
    {
        public int PrecioM { get; set; }
        public string Calidad { get; set; }

        public void Crear1()
        {
            Console.WriteLine("Ingrese el precio:");
            PrecioM = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calidad que quiere");
            Calidad = Console.ReadLine();
        }
        public override string ToString()
        {
            return "Precio: " + PrecioM + "Calidad: " + Calidad;
        }
    }
}
