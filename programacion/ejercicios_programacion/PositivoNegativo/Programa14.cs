using System;

namespace PositivoNegativo {
  class Programa14 {
    public static void Main(String[] args) {
      Console.WriteLine("Introducir un número por teclado y mostrar el mensaje de si es positivo o negativo.");

      Console.Write("Introduce un número: ");
      double numero_01 = Convert.ToDouble(Console.ReadLine());
      

      if (numero_01 > 0) {
        Console.WriteLine(numero_01 + " es positivo.");
      } else  if (numero_01 == 0) {
        Console.WriteLine(numero_01 + " es neutro.");
      } else {
        Console.WriteLine(numero_01 + " es negativo.");
      }
      Console.ReadKey();
    }
  }
}
