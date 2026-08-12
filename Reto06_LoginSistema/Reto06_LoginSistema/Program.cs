
string usuarioCorrecto = "admin";
string contraseñaCorrecta = "1234";

int intentos = 3;

while (intentos > 0)
{
    Console.Write("usuario: ");
    string usuario = Console.ReadLine()!;

    Console.Write("contrasena: ");
    string contrasena = Console.ReadLine()!;

    if (usuario == usuarioCorrecto && contrasena == contraseñaCorrecta)
    {
        Console.WriteLine("acceso concedido. bienvenido al sistema.");
        break;
    }
    else
    {
        intentos--;  // le quita un intento a usuario
        if (intentos > 0)
            Console.WriteLine($"credenciales incorrectas. intentos restantes: {intentos}");
    }
}

if (intentos == 0)
    Console.WriteLine("SISTEMA BLOQUEADO");