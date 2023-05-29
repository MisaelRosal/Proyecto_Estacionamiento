class Parqueo
{
    static int[] estacionamientoSedan = new int[5];
    static string[] informacionSedan = new string[5];
    static DateTime[] tiemposSedan = new DateTime[5];

    static int[] estacionamientoPickup = new int[5];
    static string[] informacionPickup = new string[5];
    static DateTime[] tiemposPickup = new DateTime[5];

    static int[] estacionamientoMotos = new int[5];
    static string[] informacionMotos = new string[5];
    static DateTime[] tiemposMotos = new DateTime[5];

    static string confirmar = "", nombre = "", auto = "";
    static void Main(string[] args)
    {
        InicializarEstacionamiento();

        while (true)
        {
            Console.WriteLine("ESTADO DEL ESTACIONAMIENTO:");
            MostrarEstacionamiento();

            Console.WriteLine();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Ingresar un carro");
            Console.WriteLine("2. Retirar un carro");
            Console.WriteLine("Ingrese -1 para salir.");
            Console.WriteLine();

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == -1)
                break;

            switch (opcion)
            {
                case 1:
                    IngresarCarro();
                    break;
                case 2:
                    RetirarCarro();
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }

    static string ObtenerInformacionVehiculo()
    {
        Console.WriteLine("Ingrese el nombre del propietario:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la marca del vehículo:");
        auto = Console.ReadLine();

        return "Propietario: " + nombre + ", Vehículo: " + auto;
    }

    static void InicializarEstacionamiento()
    {
        for (int i = 0; i < estacionamientoSedan.Length; i++)
        {
            estacionamientoSedan[i] = 0;
        }

        for (int i = 0; i < estacionamientoPickup.Length; i++)
        {
            estacionamientoPickup[i] = 0;
        }

        for (int i = 0; i < estacionamientoMotos.Length; i++)
        {
            estacionamientoMotos[i] = 0;
        }
    }
     
         static void MostrarEstacionamiento()
    {
        Console.WriteLine("Carros tipo Sedan:");
        for (int i = 0; i < estacionamientoSedan.Length; i++)
        {
            if (estacionamientoSedan[i] == 0)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("X ");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Carros tipo Pick Up:");
        for (int i = 0; i < estacionamientoPickup.Length; i++)
        {
            if (estacionamientoPickup[i] == 0)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("X ");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Motos:");
        for (int i = 0; i < estacionamientoMotos.Length; i++)
        {
            if (estacionamientoMotos[i] == 0)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("X ");
            }
        }
        Console.WriteLine();
    }

