using System;

namespace Programa04 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Escriba un programa que lea 10 números enteros positivos de una cifra y los coloque dentro de un vector. " +
                        "\nA continuación lea un nuevo número entero positivo de una cifra. " +
                        "\nFinalmente, creamos un nuevo vector en el que, si la cifra a tratar es mayor que el número dado, " +
                        "\nintroduce el número, y si la cifra es menor o igual que el número dado, introduce un cero.");

      const int MAXIMO_ELEMENTO = 10;
      int[] listaNumeros = new int[MAXIMO_ELEMENTO];

      for (int i = 0; i < MAXIMO_ELEMENTO; i++) {
        Console.Write("\nIntroduzca los números del vector (" + i + ") : ");
        while (!int.TryParse(Console.ReadLine(), out listaNumeros[i]) || (listaNumeros[i] > 9 || listaNumeros[i] < 1)) {
          Console.Write("\nERROR. Introduce un número entre 1 y 10: ");
        }
      }

      Console.Write("\nIntroduzca un número entero positivo de una cifra: ");
      int cifra = 0;
      while (!int.TryParse(Console.ReadLine(), out cifra) || (cifra > 9 || cifra < 1)) {
        Console.Write("\nERROR. Introduce un número entre 1 y 10: ");
      }

      Console.Write("\nVector inicial: ");
      for (int i = 0; i < MAXIMO_ELEMENTO; i++) {
        Console.Write(listaNumeros[i] + " ");
      }

      Console.Write("\nVector final: ");
      for (int i = 0; i < MAXIMO_ELEMENTO; i++) {
        int[] listaCorrecta = new int[MAXIMO_ELEMENTO];
        if (listaNumeros[i] <= cifra) { 
          listaCorrecta[i] = 0;
        } else {
          listaCorrecta[i] = listaNumeros[i];
        }
        Console.Write(listaCorrecta[i] + " ");
      }
    }
  }
}