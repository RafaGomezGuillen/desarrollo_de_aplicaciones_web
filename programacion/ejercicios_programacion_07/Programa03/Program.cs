﻿using System;

namespace Programa03 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Escriba un programa para representar mediante barras de asteriscos 10 números recogidos por teclado con valores enteros entre 1 y 20. " +
                        "\nLos 10 números se introducen separados por un espacio mediante un string.");

      const int MAXIMO_ELEMENTO = 10;
      int[] listaNumeros = new int[MAXIMO_ELEMENTO];

      for (int i = 0; i < MAXIMO_ELEMENTO; i++) {
        Console.Write("\nIntroduzca los números del vector (" + i + ") : ");
        while(!int.TryParse(Console.ReadLine(), out listaNumeros[i]) || (listaNumeros[i] > 20 || listaNumeros[i] < 1)) {
          Console.Write("\nERROR. Introduce un número entre 1 y 20: ");
        }
      }

      int contador = 0;

      for (int i = 0; i < MAXIMO_ELEMENTO; i++) {
        string asterisco = "*";

        Console.WriteLine(listaNumeros[i] + " " + asterisco);
        for (int j = 0; j < MAXIMO_ELEMENTO; j++) { 
          
        }
      }
    }
  }
}