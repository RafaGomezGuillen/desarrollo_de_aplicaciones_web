using System;

namespace Programa01 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("\tDada una cadena por teclado, indicar cuáles son las vocales que contiene.\r\n");

      // Pido la cadena
      Console.Write("\t\nIntroduce una cadena: ");
      string cadenaInicial = Console.ReadLine();

      // Compruebo si la cadena contiene cada una de las vocales
      if (cadenaInicial.Contains('a') || cadenaInicial.Contains('A')) Console.WriteLine(cadenaInicial + " contiene la vocal a.");
      if (cadenaInicial.Contains('e') || cadenaInicial.Contains('E')) Console.WriteLine(cadenaInicial + " contiene la vocal e.");
      if (cadenaInicial.Contains('i') || cadenaInicial.Contains('I')) Console.WriteLine(cadenaInicial + " contiene la vocal i.");
      if (cadenaInicial.Contains('o') || cadenaInicial.Contains('O')) Console.WriteLine(cadenaInicial + " contiene la vocal o.");
      if (cadenaInicial.Contains('u') || cadenaInicial.Contains('U')) Console.WriteLine(cadenaInicial + " contiene la vocal u.");
    }
  }
}