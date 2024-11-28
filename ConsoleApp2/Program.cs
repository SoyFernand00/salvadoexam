using SOLUCION;

int respuesta, resp;
int r2;
byte opcion;
int posicion=0;
Marihuana marihuana = new Marihuana();
Pbc pbc = new Pbc();
Tussi tussi = new Tussi();

do
{
    Console.Write("Presione [1] para ingresar al aplicativo!: ");
    respuesta = int.Parse(Console.ReadLine());
    Console.Clear();

} while (respuesta <= 0);
Console.Clear();

int[] arreglopreciom = new int[respuesta];
string[] arreglocalidad = new string[respuesta];
int[] arreglopreciopbc = new int[respuesta];
int[] arreglopreciot = new int[respuesta];
string[] arreglocolor = new string[respuesta];


do
{

    Console.WriteLine("\n**MENU**");
    Console.WriteLine("CREAR [1]: ");
    Console.WriteLine("LISTAR [2]: ");
    Console.WriteLine("MODIFICAR [3]: ");
    Console.WriteLine("FIN [0]: ");
    Console.WriteLine("Ingrese opcion: ");
    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
    {
        Console.WriteLine("Error: Ingrese valor: ");
    }
    Console.Clear();

    switch (opcion)
    {
        case 1:
            for (int i = 0; i < respuesta; i++)
            {

                Console.WriteLine("Ingresa la droga con la que quieres volar");
                Console.WriteLine("Marihuana [1]");
                Console.WriteLine("Tussi [2]");
                Console.WriteLine("Pbc [3]");
                r2 = int.Parse(Console.ReadLine());


                switch (r2)
                {
                    case 1:
                        marihuana.Crear1();
                        arreglopreciom[posicion] = marihuana.PrecioM;
                        arreglocalidad[posicion] = marihuana.Calidad;
                        posicion++;
                        break;
                    case 2:
                        tussi.Crear2();
                        arreglopreciot[posicion] = tussi.PrecioT;
                        arreglocolor[posicion] = tussi.Color;
                        posicion++;
                        break;
                    case 3:
                        pbc.Crear3();
                        arreglopreciopbc[posicion] = pbc.PrecioPbc;
                        posicion++;
                        break;
                        
                }
            }
            break;
        case 2:
            Console.WriteLine("Que desea mostrar?: ");
            Console.WriteLine("Marihuana [1]");
            Console.WriteLine("Tussi [2]");
            Console.WriteLine("Pbc [3]");
            int res=int.Parse(Console.ReadLine());
            switch (res)
            {
                case 1:
                    for (int i = 0; i < posicion; i++)
                        Console.WriteLine("\nPrecio: " + arreglopreciom[i] + "\nCalidad: " + arreglocalidad[i]); break;
                case 2:
                    for (int i = 0; i < posicion; i++)
                        Console.WriteLine("\nPrecio" + arreglopreciot[i] + "\nColor:" + arreglocolor[i]); break;
                case 3:
                    for (int i = 0; i < posicion; i++)
                        Console.WriteLine("\nPrecio" + arreglopreciopbc[i]); break;

            }
            /*
            for (int i = 0; i < posicion; i++)
            {
                Console.Write("\n\n*precio*" + arreglopreciom[i] + "\nColor:" + arreglocolor[i] + "\npbc:" + arreblopreciopbc[i] + "\n\n*precio*" + arreglopreciom[i] + "\nColor:" + arreglocolor[i] + "\npbc:" + arreblopreciopbc[i] + " ");
            }*/
            break;
            
        case 3:
            Console.Write("El dato es (numerico) o (letra): ");
            string usuario = Console.ReadLine().Trim().ToLower();
            if (usuario == "numerico")
            {
                Console.WriteLine("Ingresa el dato que Eliminaras: ");
                int eliminar = int.Parse(Console.ReadLine());
                foreach (int i in arreglopreciom)
                {
                    if (i == eliminar)
                    {
                        Console.WriteLine("Encontrado correctamente");
                        Console.WriteLine("*");
                        Console.WriteLine("Se eliminara");
                        Console.Write("Ingresa el dato que modificaras: ");
                        int cambio = int.Parse(Console.ReadLine());
                        for (int l = 0; l < respuesta; l++)
                        {
                            if (arreglopreciom[l] == eliminar)
                            {
                                arreglopreciom[l] = cambio;
                                Console.Write("El cambio fue realizado");
                            }
                        }
                    }
                }
                foreach (int i in arreglopreciot)
                {
                    if (i == eliminar)
                    {
                        Console.WriteLine("Encontrado correctamente");
                        Console.WriteLine("*");
                        Console.WriteLine("Se eliminara");
                        Console.Write("Ingresa el dato que modificaras: ");
                        int cambio = int.Parse(Console.ReadLine());
                        for (int o = 0; o < respuesta; o++)
                        {
                            if (arreglopreciot[o] == eliminar)
                            {
                                arreglopreciot[o] = cambio;
                                Console.Write("El cambio fue realizado");
                            }
                        }

                    }
                }
            }
   
            if (usuario == "letra")
            {
                Console.Write("Ingresa el dato que deseas eliminar: ");
                string eliminar1 = Console.ReadLine().Trim().ToLower();
                foreach (string r in arreglocalidad)
                {

                    if (r == eliminar1)
                    {
                        Console.WriteLine("Encontrado correctamente");
                        Console.WriteLine("*");
                        Console.WriteLine("Se eliminara");
                        Console.Write("Ingresa el dato que modificaras: ");
                        string cambio2 = Console.ReadLine();
                        for (int i = 0; i < respuesta; i++)
                        {
                            if (arreglocalidad[i] == eliminar1)
                            {
                                arreglocalidad[i] = cambio2;
                                Console.Write("El cambio fue realizado");
                            }
                        }
                    }
                }
                foreach (string r in arreglocolor)
                {

                    if (r == eliminar1)
                    {
                        Console.WriteLine("Encontrado correctamente");
                        Console.WriteLine("*");
                        Console.WriteLine("Se eliminara");
                        Console.Write("Ingresa el dato que modificaras: ");
                        string cambio2 = Console.ReadLine().Trim().ToLower();
                        for (int i = 0; i < respuesta; i++)
                        {
                            if (arreglocolor[i] == eliminar1)
                            {
                                arreglocolor[i] = cambio2;
                                Console.Write("El cambio fue realizado");
                            }
                        }
                    }
                }
            }

            break;
    }
}while (opcion!=4);