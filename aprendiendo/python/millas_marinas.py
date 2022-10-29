print("Dado un valor numérico correspondiente a una distancia en", 
      "millas marinas, pasar este valor a metros.")

numero_millas_marinas = float(input("Introduce número de millas marinas: "))
numero_metros = numero_millas_marinas * 1852

print(numero_millas_marinas, "millas marinas =", round(numero_metros, 2), "metros.")