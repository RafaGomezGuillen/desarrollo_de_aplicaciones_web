using System;

namespace MaximoMinimoMedia {
  class Programa11 {
    public static void Main(string[] args) {
      Console.WriteLine("Leer números enteros hasta teclear cero, y nos muestre el máximo, el mínimo y la media de todos ellos.");

      int numero_01 = 1, minimo = 0, maximo = 0, media = 0;

      while (numero_01 != 0) {
        Console.Write("Introduce número: ");
        numero_01 = Convert.ToInt32(Console.ReadLine());
        if (numero_01 == 0) {
          minimo = numero_01;
          maximo = numero_01;
        }
        if (maximo < numero_01) {
          maximo = numero_01;
        }
        if (minimo > numero_01) {
          minimo = numero_01;
        }
      }
      Console.WriteLine("El máximo es: " + maximo + " y el mínimo es: " + minimo);
      Console.WriteLine("Pulse tecla para salir...");
      Console.ReadKey();
    }
  }
}