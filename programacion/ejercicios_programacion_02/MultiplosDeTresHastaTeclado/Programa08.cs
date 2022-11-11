﻿using System;

namespace Numero1HastaTeclado {
  class Programa07 {
    public static void Main(string[] args) {
      Console.Write("Imprimir y contar el número de múltiplos de tres que existen desde el 1 a un número solicitado por teclado." +
                    "Introduce tu número: ");
      string? cadena_01 = Console.ReadLine();
      int contador = 0;
      int contador_02 = 0;
      if (int.TryParse(cadena_01, out int numero_01)) {
        while (contador <= numero_01) {
          if(contador % 3 == 0) {
            Console.WriteLine("Número: " + contador);
            contador_02++;
          }
          contador++;
        }
      }
      else {
        Console.WriteLine(cadena_01 + " no es número");
      }
      Console.WriteLine("Hay " + contador_02 + " números multiplos de 3 de 1 al " + cadena_01);
      Console.ReadKey();
    }
  }
}