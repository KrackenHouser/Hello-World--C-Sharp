# Hello-World--C-Sharp

Un simple programa de "¡Hola Mundo!" en C#.

## Descripción

Este proyecto es una aplicación de consola que imprime "Hello World!" y espera a que el usuario presione una tecla antes de salir.

## Requisitos

- Visual Studio 2022
- .NET SDK

## Cómo Ejecutar

1. Clona este repositorio:
    ```sh
    git clone https://github.com/KrackenHouser/Hello-World--C-Sharp.git
    ```

2. Abre `Hello World!-C#.sln` en Visual Studio.

3. Ejecuta el proyecto presionando `F5`.

## Código

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Hello World!\n");
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
