using System;

namespace Division {
  class Programa13 {
    public static void Main(String[] args) {
      Console.WriteLine("Presenta por pantalla la división de dos números solicitados por teclado.");

      Console.Write("Introduce el primer número: ");
      double numero_01 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Introduce el segundo número: ");
      double numero_02 = Convert.ToDouble(Console.ReadLine());      

      if (numero_02 == 0) {
        Console.WriteLine("No se posible dividir entre 0.");
      }
      else {
        double numero_division = numero_01 / numero_02;
        Console.WriteLine(numero_01 + " / " + numero_02 + " = " + Math.Round(numero_division, 1));
      }
      Console.ReadKey();
    }
  }
}
