using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLUCION
{
    public class Pbc
    {
        public int PrecioPbc {  get; set; }

        public void Crear3()
        {
            Console.WriteLine("Precio:");
            PrecioPbc = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Precio: " + PrecioPbc;
        }

    }
}
