print("Recogida por teclado una cantidad y un porcentaje, calcular el porcentaje ",
      "correspondiente de la cantidad dada.")

numero_cantidad = float(input("Introduzca la cantidad numérica: "))
numero_porcentaje = float(input("Introduzca porcentaje: "))
numero_cantidad_dada = (numero_cantidad / 100) * numero_porcentaje

print("El", numero_porcentaje, "% de", numero_cantidad, "=", numero_cantidad_dada)
