using System;

namespace Programa03 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Escriba un programa para representar mediante barras de asteriscos 10 números recogidos por teclado con valores enteros entre 1 y 20. " +
                        "Los 10 números se introducen separados por un espacio mediante un string.");
      /*Console.Write("\nIngrese los 10 números separados por espacios: ");
      string input = Console.ReadLine();

      // Convertir la entrada del usuario en una matriz de números enteros
      string[] inputNumbers = input.Split(' ');
      int[] numbers = new int[inputNumbers.Length];
      for (int i = 0; i < inputNumbers.Length; i++) {
        numbers[i] = int.Parse(inputNumbers[i]);
      }

      // Dibujar las barras de asteriscos para cada número
      Console.WriteLine("\nResultado:");
      for (int i = 0; i < numbers.Length; i++) {
        Console.Write(numbers[i] + "\t");
        for (int j = 0; j < numbers[i]; j++) {
          Console.Write("*");
        }
        Console.WriteLine();
      }*/

      const int MAXIMO_ELEMENTO = 10;
      int[] listaNumeros = new int[MAXIMO_ELEMENTO];

      for (int i = 0; i < MAXIMO_ELEMENTO; i++) {
        Console.Write("\nIntroduzca los números del vector (" + i + ") : ");
        while (!int.TryParse(Console.ReadLine(), out listaNumeros[i]) || (listaNumeros[i] > 20 || listaNumeros[i] < 1)) {
          Console.Write("\nERROR. Introduce un número entre 1 y 20: ");
        }
      }

      for (int i = 0; i < MAXIMO_ELEMENTO; i++) {
        Console.Write(listaNumeros[i] + "\t");
        for (int j = 0; j < listaNumeros[i]; j++) {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }
  }
}
