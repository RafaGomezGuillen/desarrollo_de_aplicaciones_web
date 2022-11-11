using System;

namespace Suma50oMas {
  class Programa06 {
    public static void Main(string[] args) {
      Console.Write("Pide números por teclado, hasta que sumen 50 o más. Introduce tu número: ");
      string? cadena_01 = Console.ReadLine();
      if (int.TryParse(cadena_01, out int numero_01)) {
        numero_01 = Convert.ToInt32(Console.ReadLine());
        while (numero_01 <= 50) {
          Console.WriteLine("Suma = " + numero_01);
          Console.Write("Introduce tu número se para hasta que su suma sea 50 o más: ");
        }
        numero_01 = numero_01 + numero_01;
      }
      else {
        Console.WriteLine(cadena_01 + " no es número");
      }

      Console.ReadKey();
    }
  }
}