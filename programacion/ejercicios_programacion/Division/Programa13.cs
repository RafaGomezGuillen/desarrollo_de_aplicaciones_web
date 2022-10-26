using System;

namespace Division {
  class Programa13 {
    public static void Main(String[] args) {
      Console.WriteLine("Presenta por pantalla la división de dos números solicitados por teclado.");

      Console.Write("Introduce el primer número: ");
      int numero_01 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Introduce el segundo número: ");
      int numero_02 = Convert.ToInt32(Console.ReadLine());      

      if (numero_02 == 0) {
        Console.WriteLine("No se posible dividir entre 0.");
      }
      else {
        decimal numero_division = Convert.ToDecimal(numero_01) / Convert.ToDecimal(numero_02);
        Console.WriteLine(numero_01 + " / " + numero_02 + " = " + Math.Round(numero_division, 1));
      }
      Console.ReadKey();
    }
  }
}
