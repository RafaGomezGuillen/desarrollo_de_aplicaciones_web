using System;

namespace Programa10 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("\tIntroduciremos números enteros por teclado hasta pulsar el cero. " +
                        "\nLos número deben ser mayores de cero y menores de diez. " +
                        "\nOrdenar y presentar por pantalla estos números ordenados de mayor a menor y de menor a mayor.\r\n");

      bool salir = false;
      decimal[] vectorInicial;
      int contadorSize = 1, i = 0; ;    
      while (salir == false) {
        
        vectorInicial = new decimal[contadorSize];
        Console.Write("\nIntroduce los números del vector (" + i + ") : ");
        while (!decimal.TryParse(Console.ReadLine(), out vectorInicial[i]) || vectorInicial[i] <= 0 || vectorInicial[i] >= 10) {
          if (vectorInicial[i] == 0) {
            salir = true;
            break;
          }
          Console.Write("\nERROR. Introduce los números del vector (" + i + ") : ");
        }
        i++;
        contadorSize++;
        Array.Sort(vectorInicial);
        //for (int j = 0; j < contadorSize; j++) {
        //  Console.Write(vectorInicial[j] + " ");
        //}
      }
    }
  }
}