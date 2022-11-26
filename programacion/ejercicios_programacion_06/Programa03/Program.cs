using System;

namespace Programa03 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Solicitar 10 números distintos por teclado y mostrarlos.");
      int ElementoMaximo = 10;
      double[] NumerosDistintos = new double[ElementoMaximo];
      double Elementos;

      for (int i = 0; i < ElementoMaximo; i++) {
        Console.Write($"\n Introduzca los elementos del vector (" + i + ") : ");
        Elementos = Convert.ToDouble(Console.ReadLine());
        NumerosDistintos[i] = Elementos;
      }

      for (int i = 0; i < ElementoMaximo; i++) {
        Console.Write(NumerosDistintos[i] + " ");
      }
    }
  }
}