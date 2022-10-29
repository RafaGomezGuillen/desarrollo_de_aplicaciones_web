print("Porcentaje de alumnos en el curso actual, pasando por teclado el número de chicas y de chicos.")

numero_chicos = int(input("Introduce el número de chicos: "))
numero_chicas = int(input("Introduce el número de chicas: "))

numero_total = numero_chicos + numero_chicas
porcentaje_chicos = (numero_chicos / numero_total) * 100
porcentaje_chicas = (numero_chicas / numero_total) * 100

print("El número de alumnos es:", numero_total, "con un porcentaje de chicos del", round(porcentaje_chicos, 2), "% y de chicas", round(porcentaje_chicas, 2), "%.")
