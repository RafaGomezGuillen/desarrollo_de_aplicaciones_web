using System;

namespace Programa05 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Dada una cadena por teclado, indicar cuáles son las vocales que contiene.");

      Console.Write("Introduce la cadena: ");
      string cadena_01 = Console.ReadLine();
      
      if (cadena_01.Contains('a') || cadena_01.Contains('A')) Console.WriteLine(cadena_01 + " contiene la letra a.");
      if (cadena_01.Contains('e') || cadena_01.Contains('E')) Console.WriteLine(cadena_01 + " contiene la letra e.");
      if (cadena_01.Contains('i') || cadena_01.Contains('I')) Console.WriteLine(cadena_01 + " contiene la letra i.");
      if (cadena_01.Contains('o') || cadena_01.Contains('O')) Console.WriteLine(cadena_01 + " contiene la letra o.");
      if (cadena_01.Contains('u') || cadena_01.Contains('U')) Console.WriteLine(cadena_01 + " contiene la letra u.");
    }
  }
}