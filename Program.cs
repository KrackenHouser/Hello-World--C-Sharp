using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Hello Wordl!\n");
        }
        finally
        {
            ExitWithMessage();
        }
    }
    static void ExitWithMessage()
    {
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(); // Espera a que el usuario presione una tecla
        Environment.Exit(0); // Salir del programa con código de salida 0 (éxito)
    }
}
