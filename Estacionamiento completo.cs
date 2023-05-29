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

    static string auto, nombre; //parte 1
    static void Main(string[] args)
    {
        InicializarEstacionamiento();

        while (true)
        {
            Console.WriteLine("ESTADO DEL ESTACIONAMIENTO:");

            MostrarEstacionamiento();

            Console.WriteLine();
            Console.WriteLine("La tarifa del estacionamiento es 0.5 ctv x 30 seg");
            Console.WriteLine();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Ingresar un carro");
            Console.WriteLine("2. Retirar un carro");
            Console.WriteLine("Ingrese 3 para salir.");
            Console.WriteLine();

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 3)
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
                    break; // parte 2
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
            estacionamientoMotos[i] = 0; // parte 3
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
        Console.WriteLine(); // parte 4
    }

    static void IngresarCarro()
    {
        Console.WriteLine("Seleccione la categoría del carro:");
        Console.WriteLine("1. Carro tipo Sedan");
        Console.WriteLine("2. Carro tipo Pick Up");
        Console.WriteLine("3. Moto");
        Console.WriteLine();

        int categoria = Convert.ToInt32(Console.ReadLine());

        switch (categoria)
        {
            case 1:
                IngresarSedan();
                break;
            case 2:
                IngresarPickup();
                break;
            case 3:
                IngresarMoto();
                break;
            default:
                Console.WriteLine("Categoría inválida.");
                break; // parte 5
        }
    }

    static void IngresarSedan()
    {
        bool espacioDisponible = false;
        for (int i = 0; i < estacionamientoSedan.Length; i++)
        {
            if (estacionamientoSedan[i] == 0)
            {
                estacionamientoSedan[i] = 1;
                informacionSedan[i] = ObtenerInformacionVehiculo();
                tiemposSedan[i] = DateTime.Now;
                espacioDisponible = true;
                break;
            }
        }

        if (espacioDisponible)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Carro tipo Sedan ingresado correctamente.");
            Console.WriteLine("========================================");

            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("No hay espacio disponible para ingresar un carro tipo Sedan.");
            Console.WriteLine("==============================================================");

            Console.WriteLine(); // parte 6
        }
    }

    static void IngresarPickup()
    {
        bool espacioDisponible = false;
        for (int i = 0; i < estacionamientoPickup.Length; i++)
        {
            if (estacionamientoPickup[i] == 0)
            {
                estacionamientoPickup[i] = 1;
                informacionPickup[i] = ObtenerInformacionVehiculo();
                tiemposPickup[i] = DateTime.Now;
                espacioDisponible = true;
                break;
            }
        }

        if (espacioDisponible)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Carro tipo Pick Up ingresado correctamente.");
            Console.WriteLine("==========================================");

            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("No hay espacio disponible para ingresar un carro tipo Pick Up.");
            Console.WriteLine("==============================================================");

            Console.WriteLine(); //parte 7
        }
    }

    static void IngresarMoto()
    {
        bool espacioDisponible = false;
        for (int i = 0; i < estacionamientoMotos.Length; i++)
        {
            if (estacionamientoMotos[i] == 0)
            {
                estacionamientoMotos[i] = 1;
                informacionMotos[i] = ObtenerInformacionVehiculo();
                tiemposMotos[i] = DateTime.Now;
                espacioDisponible = true;
                break;
            }
        }

        if (espacioDisponible)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Moto ingresada correctamente.");
            Console.WriteLine("============================");

            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("No hay espacio disponible para ingresar un carro tipo Moto.");
            Console.WriteLine("==============================================================");

            Console.WriteLine(); //parte 8
        }
    }

    static void RetirarCarro()
    {
        Console.WriteLine("Seleccione la categoría del carro a retirar:");
        Console.WriteLine("1. Carro tipo Sedan");
        Console.WriteLine("2. Carro tipo Pick Up");
        Console.WriteLine("3. Moto");
        Console.WriteLine();

        int categoria = Convert.ToInt32(Console.ReadLine());

        switch (categoria)
        {
            case 1:
                RetirarSedan();
                break;
            case 2:
                RetirarPickup();
                break;
            case 3:
                RetirarMoto();
                break;
            default:
                Console.WriteLine("Categoría inválida.");
                Console.WriteLine();
                break;
        }
    }

    static void RetirarSedan()
    {
        Console.WriteLine("Ingrese el número del espacio a liberar (1-5):");
        int numeroEspacio = Convert.ToInt32(Console.ReadLine()) - 1;

        if (numeroEspacio >= 0 && numeroEspacio < estacionamientoSedan.Length)
        {
            if (estacionamientoSedan[numeroEspacio] == 1)
            {
                estacionamientoSedan[numeroEspacio] = 0;

                TimeSpan tiempoTranscurrido = DateTime.Now - tiemposSedan[numeroEspacio];
                double tiempoEstacionado = tiempoTranscurrido.TotalSeconds;
                double totalAPagar = CalcularCobro(tiempoEstacionado);

                Console.WriteLine("===============================================================================");
                Console.WriteLine("HOLA " + nombre + ", su vehiculo: " + auto + " HA SIDO RETIRADO CORRECTAMENTE");
                Console.WriteLine("Tiempo transcurrido: " + tiempoTranscurrido.ToString(@"hh\:mm\:ss"));
                Console.WriteLine("Total a pagar: $" + totalAPagar);
                Console.WriteLine("===============================================================================");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No hay carro tipo Sedan en el espacio especificado.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Número de espacio inválido.");
            Console.WriteLine(); //parte 9
        }
    }

    static void RetirarPickup()
    {
        Console.WriteLine("Ingrese el número del espacio a liberar (1-5):");
        int numeroEspacio = Convert.ToInt32(Console.ReadLine()) - 1;

        if (numeroEspacio >= 0 && numeroEspacio < estacionamientoPickup.Length)
        {
            if (estacionamientoPickup[numeroEspacio] == 1)
            {
                estacionamientoPickup[numeroEspacio] = 0;

                TimeSpan tiempoTranscurrido = DateTime.Now - tiemposPickup[numeroEspacio];
                double tiempoEstacionado = tiempoTranscurrido.TotalSeconds;
                double totalAPagar = CalcularCobro(tiempoEstacionado);

                Console.WriteLine("===============================================================================");
                Console.WriteLine("HOLA " + nombre + ", su vehiculo: " + auto + " HA SIDO RETIRADO CORRECTAMENTE");
                Console.WriteLine("Tiempo transcurrido: " + tiempoTranscurrido.ToString(@"hh\:mm\:ss"));
                Console.WriteLine("Total a pagar: $" + totalAPagar);
                Console.WriteLine("===============================================================================");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No hay carro tipo Pick Up en el espacio especificado.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Número de espacio inválido.");
            Console.WriteLine(); // parte 10
        }
    }

    static void RetirarMoto()
    {
        Console.WriteLine("Ingrese el número del espacio a liberar (1-5):");
        int numeroEspacio = Convert.ToInt32(Console.ReadLine()) - 1;

        if (numeroEspacio >= 0 && numeroEspacio < estacionamientoMotos.Length)
        {
            if (estacionamientoMotos[numeroEspacio] == 1)
            {
                estacionamientoMotos[numeroEspacio] = 0;

                TimeSpan tiempoTranscurrido = DateTime.Now - tiemposMotos[numeroEspacio];
                double tiempoEstacionado = tiempoTranscurrido.TotalSeconds;
                double totalAPagar = CalcularCobro(tiempoEstacionado);

                Console.WriteLine("===============================================================================");
                Console.WriteLine("HOLA " + nombre + ", su vehiculo: " + auto + " HA SIDO RETIRADO CORRECTAMENTE");
                Console.WriteLine("Tiempo transcurrido: " + tiempoTranscurrido.ToString(@"hh\:mm\:ss"));
                Console.WriteLine("Total a pagar: $" + totalAPagar);
                Console.WriteLine("===============================================================================");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No hay moto en el espacio especificado.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Número de espacio inválido.");
            Console.WriteLine(); // parte 11
        }
    }

    static double CalcularCobro(double tiempoEstacionado)
    {
        int segundosPorCobrar = 30;
        double tarifa = 0.50;

        int cantidadCobros = (int)Math.Ceiling(tiempoEstacionado / segundosPorCobrar);
        double totalAPagar = cantidadCobros * tarifa;

        return totalAPagar; // parte 12
    }

}
