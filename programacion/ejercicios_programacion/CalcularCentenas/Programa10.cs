﻿using System;

namespace CalcularCentena {
  class Programa10 {
    public static void Main(String[] args) {
      Console.WriteLine("Dado un número por teclado, devolver la cifra correspondiente a las centenas.");

      Console.Write("Introduce el número: ");
      int numero_01 = Convert.ToInt32(Console.ReadLine());
      int numero_cenena = (numero_01 % 1000) / 100;

      Console.WriteLine("La centena de " + numero_01 + " = " + numero_cenena);
      Console.ReadKey();
    }
  }
}
