using System;

namespace Programa08 {
  class Program {
    public static void Main(string[] args) {
      Console.WriteLine("\nIntroduce la siguiente información.");

      Console.Write("\n-Nombres de 4 empleados.");
      const int ElementoMaximoNombreEmpleados = 4;
      string[] NombreEmpleados = new string[ElementoMaximoNombreEmpleados];
      string Nombres;
      int i, j;

      for (i = 0; i < ElementoMaximoNombreEmpleados; i++) {
        Console.Write("\n Introduzca los nombres del vector (" + i + ") : ");
        Nombres = Console.ReadLine();
        NombreEmpleados[i] = Nombres;
      }

      Console.WriteLine("\n-Ingresos en concepto de sueldo, cobrado por cada empleado, en los últimos 3 meses.");
      decimal Sueldo = 0;
      decimal[] SueldoEmpleados = new decimal[ElementoMaximoNombreEmpleados];
      decimal TotalSueldo = 0, MaximoSueldo = SueldoEmpleados[0];
      string MaximoSueldoNombre = "";
      j = 0; 
      i = 0;

      while (i < ElementoMaximoNombreEmpleados && j < ElementoMaximoNombreEmpleados) {
        Console.Write($"\nIntroduzca el sueldo de: " + NombreEmpleados[j] + " (" + i + ") : ");
        while (!decimal.TryParse(Console.ReadLine(), out Sueldo)) {
          Console.Write("Error. Introduzca un número (" + i + ") : ");
        }
        SueldoEmpleados[i] = Sueldo;
        TotalSueldo += SueldoEmpleados[i];
        if (SueldoEmpleados[i] > MaximoSueldo) {
          MaximoSueldo = SueldoEmpleados[i];
          MaximoSueldoNombre = NombreEmpleados[j];
        } 
        i++;
        j++;
      }

      for (i = 0, j = 0; i < ElementoMaximoNombreEmpleados && j < ElementoMaximoNombreEmpleados; i++, j++) {
        Console.Write("\n" + NombreEmpleados[i] + " cobra en tres meses " + SueldoEmpleados[j] + " euros.");
      }

      Console.WriteLine("\n\n" + MaximoSueldoNombre + " es el empleado que más cobra con " + MaximoSueldo + " euros.");
      Console.WriteLine("El total a pagar a los empleados es de " + TotalSueldo + " euros.");
    }
  }
}