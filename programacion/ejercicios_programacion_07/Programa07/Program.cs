using System;

namespace Programa07 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Realizar el algoritmo que, solicitada una cantidad de elementos de un vector, y el límite superior e inferior de los datos a calcular, " +
                        "\nrellenar con elementos aleatorios dentro de los límites pedidos dicho vector y lo presente por pantalla. " +
                        "\nA continuación, pida por teclado un nuevo valor  que debe cumplir las mismas condiciones de los anteriores " +
                        "\ny una posición que debe estar dentro de los límites del vector inicial. " +
                        "\nCrear un nuevo vector que contenga la información del vector inicial pero insertando el valor pedido en la posición pedida. ");

      Console.Write("\nIntroduce el número de elemntos que tendrá el vector: ");
      int numeroElementos = 0;
      while(!int.TryParse(Console.ReadLine(), out numeroElementos)) {
        Console.Write("\nERROR. Introduce un número: ");
      }

      Console.Write("\nIntroduce el límite inferior: ");
      int limiteInferior = 0;
      while (!int.TryParse(Console.ReadLine(), out limiteInferior)) {
        Console.Write("\nERROR. Introduce un número: ");
      }

      Console.Write("\nIntroduce el límite superior: ");
      int limiteSuperior = 0;
      while (!int.TryParse(Console.ReadLine(), out limiteSuperior)) {
        Console.Write("\nERROR. Introduce un número: ");
      }

      int[] lista = new int[numeroElementos];
      Random aleatorio = new Random();
      for (int i = 1; i <= numeroElementos; i++) {
        lista[i - 1] = aleatorio.Next(limiteInferior, limiteSuperior);
      }

      Console.Write("\nVector inicial: ");
      for (int i = 0; i < numeroElementos; i++) {
        Console.Write(lista[i] + " ");
      }

      Console.Write("\nIntroduce el dato nuevo: ");
      int dato = 0;
      while (!int.TryParse(Console.ReadLine(), out dato)) {
        Console.Write("\nERROR. Introduce un número: ");
      }

      Console.Write("\nIntroduce una posición: ");
      int posicion = 0;
      while (!int.TryParse(Console.ReadLine(), out posicion) || (posicion > limiteSuperior || posicion < limiteInferior)) {
        Console.Write("\nERROR. Introduce un número: ");
      }

      Console.Write("\nVector inicial: ");
      for (int i = 0; i < numeroElementos; i++) {
        Console.Write(lista[i] + " ");
      }

      int[] vectorFinal = new int[numeroElementos];
      for (int i = 0; i < numeroElementos; i++) {
        if (i == posicion) {
          vectorFinal[i] = dato;
        } else {
          vectorFinal[i] = lista[i];
        }
      }

      Console.Write("\nVector final: ");
      for (int i = 0; i < numeroElementos; i++) {
        Console.Write(vectorFinal[i] + " ");
      }
    }
  }
}