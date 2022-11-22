using System;

namespace Programa02 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Solicitada una frase y una letra, encontrar el número " +
                        "de veces que dicha letra aparece en la frase dada.");

      Console.Write("Introduce la cadena: ");
      string? cadena_01 = Console.ReadLine();

      Console.Write("Introduce una letra: ");
      char letra_01 = Convert.ToChar(Console.ReadLine());

      int contador_01 = 0;
      for (int i = 0; i < cadena_01.Length; i++) {
        if (cadena_01.Contains(letra_01)) {
          contador_01++;
        }
      }
      Console.WriteLine(letra_01 + " aparece " + contador_01 + " veces en la cadena " + cadena_01);
    }
  }
}