string[] nombres = { "Ana", "Carlos", "Luis", "Gabriela", "Eva", "Roberto", "Kim", "Alejandro" };

Console.WriteLine("nombres con mas de 4 caracteres:\n");

foreach (string nombre in nombres)
{
    if (nombre.Length > 4)
    {
        Console.WriteLine(nombre);
    }
}