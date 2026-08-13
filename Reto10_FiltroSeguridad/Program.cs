string[] codigos = { "A1", "B2", "ERROR", "C3", "ERROR", "D4", "EXIT", "E5", "F6" };

Console.WriteLine("procesando secuencia de codigos:\n");

foreach (string codigo in codigos)
{
    if (codigo == "ERROR")
    {
        Console.WriteLine("codigo ERROR detectado, ignorando...");
        continue;
    }

    if (codigo == "EXIT")
    {
        Console.WriteLine("codigo EXIT detectado, deteniendo procesamiento.");
        break;
    }

    Console.WriteLine($"procesando codigo: {codigo}");
}

Console.WriteLine("\nprocesamiento finalizado.");