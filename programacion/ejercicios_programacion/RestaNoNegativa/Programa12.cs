﻿using System;

namespace RestaNoNegativa {
  class Programa12 {
    public static void Main(String[] args) {
      Console.WriteLine("Presenta por pantalla la resta de dos números solicitados por teclado. " +
                        "No puede devolver el resultado como un número negativo.");

      Console.Write("Introduce el primer número: ");
      int numero_01 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Introduce el segundo número: ");
      int numero_02 = Convert.ToInt32(Console.ReadLine());

      int numero_resta = numero_01 - numero_02;

      if (numero_01 >= numero_02) {
        Console.WriteLine(numero_01 + " - " + numero_02 + " = " + numero_resta);
      } else {
        numero_resta = numero_01 - (- numero_02);
        Console.WriteLine(numero_01 + " - (-" + numero_02 + ") = " + numero_resta);
      }
      Console.ReadKey();
    }
  }
}
