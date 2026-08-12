
int opcion;

do
{
    Console.WriteLine("\n=== MENU DEL SISTEMA ===");
    Console.WriteLine("1. ver estado del sistema");
    Console.WriteLine("2. iniciar modulo");
    Console.WriteLine("3. detener modulo");
    Console.WriteLine("4. ver registros");
    Console.WriteLine("5. salir");
    Console.Write("elige una opcion: ");

    string entrada = Console.ReadLine()!;

    if (!int.TryParse(entrada, out opcion)) 
    {
        Console.WriteLine("entrada invalida. ingresa un numero del 1 al 5.");
        opcion = 0;
        continue;
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine("estado del sistema: operativo.");
            break;
        case 2:
            Console.WriteLine("modulo iniciado correctamente.");
            break;
        case 3:
            Console.WriteLine("modulo detenido.");
            break;
        case 4:
            Console.WriteLine("mostrando registros del sistema...");
            break;
        case 5:
            Console.WriteLine("saliendo del sistema...");
            break;
        default:
            Console.WriteLine("opcion no valida. intenta de nuevo.");
            break;
    }

} while (opcion != 5);