using System;

namespace Programa13 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Programa que, dada una cadena de caracteres, elimine los caracteres " +
                        "en blanco a la izquierda de una cadena y la muestre por pantalla.");

      Console.Write("Introduce una frase: ");
      string? cadena_01 = Console.ReadLine();

      string cadena_02 = "";
      for (int i = 0; i < cadena_01.Length; i++) {
        if (cadena_01[i] != ' ') {
          cadena_02 += cadena_01[i];
        }
      }
      Console.WriteLine(cadena_02);
    }
  }
}