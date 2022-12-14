using System;

namespace Programa06 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Escriba un programa que solicite 20 números enteros positivos, y los vaya insertando ordenados en un vector. " +
                        "\nCada vez que insertamos un número, presentamos todos los elementos que ya hemos insertado hasta ese momento.");
      
      const int MAXIMO_ELEMENTO = 5;
      int[] vectorInicial = new int[MAXIMO_ELEMENTO];
      for (int i = 0; i < MAXIMO_ELEMENTO; i++) {
        Console.Write("\nIntroduzca los números del vector (" + i + ") : ");
        while (!int.TryParse(Console.ReadLine(), out vectorInicial[i])) {
          Console.Write("\nERROR. Introduce un número: ");
        }
        for (int j = 0; j < MAXIMO_ELEMENTO; j++) {
          Console.Write(vectorInicial[j] + " ");
        }   
      }
      for (int i = 0; i < MAXIMO_ELEMENTO; i++) {
        for (int j = i; j < MAXIMO_ELEMENTO; j++) {
          if ((vectorInicial[i] > vectorInicial[j])) {
            int aux = vectorInicial[i];
            vectorInicial[i] = vectorInicial[j];
            vectorInicial[j] = aux;
          }
        }
      }
      Console.Write("\nVector final: ");
      for (int i = 0; i < MAXIMO_ELEMENTO; i++) {
        Console.Write(vectorInicial[i] + " ");
      }
    }
  }
}