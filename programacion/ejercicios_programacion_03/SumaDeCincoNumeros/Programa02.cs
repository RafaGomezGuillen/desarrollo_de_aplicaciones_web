using System;

namespace SumaDeCincoNumeros {
  class Programa02 {
    public static void Main(string[] args) {
      Console.WriteLine("Pide por teclado cinco números y muestra su suma.");
      float suma = 0;

      for (int i = 0; i < 5; i++) {
        if(float.TryParse(Console.ReadLine(), out float numero_01)) {
          suma += numero_01;
          Console.WriteLine("La suma = " + suma);
        } else {
          Console.WriteLine("ERROR. No ha introducido un número.");
        }
      }
    }
  }
}