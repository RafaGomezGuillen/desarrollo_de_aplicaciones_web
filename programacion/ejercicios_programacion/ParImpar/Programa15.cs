using System;

namespace ParImpar {
  class Programa15 {
    public static void Main(String[] args) {
      Console.WriteLine("Introducir un número por teclado y mostrar el mensaje de si es par o impar.");

      Console.Write("Introduce un número: ");
      int numero_01 = Convert.ToInt32(Console.ReadLine());


      if (numero_01 % 2 == 0) {
        Console.WriteLine(numero_01 + " es par.");
      } else {
        Console.WriteLine(numero_01 + " es impar.");
      }
      Console.ReadKey();
    }
  }
}
