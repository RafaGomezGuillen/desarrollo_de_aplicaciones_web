using System;

namespace MayorMenorQue10 {
  class Programa11 {
    public static void Main(String[] args) {
      Console.WriteLine("Pide un número por teclado y muestra si es mayor que diez, " +
                        "menor que diez o igual a diez.");

      Console.Write("Introduce el número: ");
      int numero_01 = Convert.ToInt32(Console.ReadLine());

      if (numero_01 > 10) {
        Console.WriteLine(numero_01 + " > 10");
      } else if (numero_01 < 10) {
        Console.WriteLine(numero_01 + " < 10");
      } else {
        Console.WriteLine(numero_01 + " = 10");
      }
      Console.ReadKey();
    }
  }
}
