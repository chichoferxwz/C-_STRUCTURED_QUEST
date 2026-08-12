Console.Write("ingresa el numero: ");
int numero = int.Parse(Console.ReadLine()!);

Console.Write("ingresa el inicio del rango: ");
int inicio = int.Parse(Console.ReadLine()!);

Console.Write("ingresa el fin del rango: ");
int fin = int.Parse(Console.ReadLine()!);

if (inicio > fin)
{
    Console.WriteLine("el inicio no puede ser mayor que el fin.");
}
else
{
    Console.WriteLine($"\ntabla del {numero} del {inicio} al {fin}:\n");

    for (int i = inicio; i <= fin; i++)
    {
        int resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}