using System;

namespace Programa07 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("Crear un string con 100 letras entre la A y la Z de forma aleatoria. " +
                        "A continuación, calcular cuántas veces aparece cada letra en dicho string, " +
                        "y mostrar este resultado por pantalla, indicando la letra, y el número de veces que aparece.");
      
      const int ElementoMaximo = 100;
      char[] ListaLetrasAleatorias = new char[ElementoMaximo];
      Random LetrasAleatorias = new Random();
      int ContadorA = 0, ContadorB = 0, ContadorC = 0, ContadorD = 0, ContadorE = 0, ContadorF = 0,
          ContadorG = 0, ContadorH = 0, ContadorI = 0, ContadorJ = 0, ContadorK = 0, ContadorL = 0,
          ContadorM = 0, ContadorN = 0, ContadorO = 0, ContadorP = 0, ContadorQ = 0, ContadorR = 0,
          ContadorS = 0, ContadorT = 0, ContadorU = 0, ContadorV = 0, ContadorW = 0, ContadorX = 0,
          ContadorY = 0, ContadorZ = 0;

      Console.WriteLine("\n\nVector de cadenas.\n");
      for (int i = 1; i <= ElementoMaximo; i++) {
        ListaLetrasAleatorias[i - 1] = Convert.ToChar(LetrasAleatorias.Next('A', 'Z'));
      }

      for (int i = 0; i < ElementoMaximo; i++) {
        Console.Write(ListaLetrasAleatorias[i] + " ");
      }

      for (int i = 0; i < ElementoMaximo; i++) {
        if (ListaLetrasAleatorias[i] == 'A') ContadorA++;
        if (ListaLetrasAleatorias[i] == 'B') ContadorB++;
        if (ListaLetrasAleatorias[i] == 'C') ContadorC++;
        if (ListaLetrasAleatorias[i] == 'D') ContadorD++;
        if (ListaLetrasAleatorias[i] == 'E') ContadorE++;
        if (ListaLetrasAleatorias[i] == 'F') ContadorF++;
        if (ListaLetrasAleatorias[i] == 'G') ContadorG++;
        if (ListaLetrasAleatorias[i] == 'H') ContadorH++;
        if (ListaLetrasAleatorias[i] == 'I') ContadorI++;
        if (ListaLetrasAleatorias[i] == 'J') ContadorJ++;
        if (ListaLetrasAleatorias[i] == 'K') ContadorK++;
        if (ListaLetrasAleatorias[i] == 'L') ContadorL++;
        if (ListaLetrasAleatorias[i] == 'M') ContadorM++;
        if (ListaLetrasAleatorias[i] == 'N') ContadorN++;
        if (ListaLetrasAleatorias[i] == 'O') ContadorO++;
        if (ListaLetrasAleatorias[i] == 'P') ContadorP++;
        if (ListaLetrasAleatorias[i] == 'Q') ContadorQ++;
        if (ListaLetrasAleatorias[i] == 'R') ContadorR++;
        if (ListaLetrasAleatorias[i] == 'S') ContadorS++;
        if (ListaLetrasAleatorias[i] == 'T') ContadorT++;
        if (ListaLetrasAleatorias[i] == 'U') ContadorU++;
        if (ListaLetrasAleatorias[i] == 'V') ContadorV++;
        if (ListaLetrasAleatorias[i] == 'W') ContadorW++;
        if (ListaLetrasAleatorias[i] == 'X') ContadorX++;
        if (ListaLetrasAleatorias[i] == 'Y') ContadorY++;
        if (ListaLetrasAleatorias[i] == 'Z') ContadorZ++;
      }

      Console.WriteLine("\n\nLa palabra A aparece " + ContadorA + " veces.");
      Console.WriteLine("La palabra B aparece " + ContadorB + " veces.");
      Console.WriteLine("La palabra C aparece " + ContadorC + " veces.");
      Console.WriteLine("La palabra D aparece " + ContadorD + " veces.");
      Console.WriteLine("La palabra E aparece " + ContadorE + " veces.");
      Console.WriteLine("La palabra F aparece " + ContadorF + " veces.");
      Console.WriteLine("La palabra G aparece " + ContadorG + " veces.");
      Console.WriteLine("La palabra H aparece " + ContadorH + " veces.");
      Console.WriteLine("La palabra I aparece " + ContadorI + " veces.");
      Console.WriteLine("La palabra J aparece " + ContadorJ + " veces.");
      Console.WriteLine("La palabra K aparece " + ContadorK + " veces.");
      Console.WriteLine("La palabra L aparece " + ContadorL + " veces.");
      Console.WriteLine("La palabra M aparece " + ContadorM + " veces.");
      Console.WriteLine("La palabra N aparece " + ContadorN + " veces.");
      Console.WriteLine("La palabra O aparece " + ContadorO + " veces.");
      Console.WriteLine("La palabra P aparece " + ContadorP + " veces.");
      Console.WriteLine("La palabra Q aparece " + ContadorQ + " veces.");
      Console.WriteLine("La palabra R aparece " + ContadorR + " veces.");
      Console.WriteLine("La palabra S aparece " + ContadorS + " veces.");
      Console.WriteLine("La palabra T aparece " + ContadorT + " veces.");
      Console.WriteLine("La palabra U aparece " + ContadorU + " veces.");
      Console.WriteLine("La palabra V aparece " + ContadorV + " veces.");
      Console.WriteLine("La palabra W aparece " + ContadorW + " veces.");
      Console.WriteLine("La palabra X aparece " + ContadorX + " veces.");
      Console.WriteLine("La palabra Y aparece " + ContadorY + " veces.");
      Console.WriteLine("La palabra Z aparece " + ContadorZ + " veces.");
    }
  }
}