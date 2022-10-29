from __future__ import division


print("Presenta por pantalla la división de dos números solicitados por teclado.")

numero_01 = int(input("Introduce el primer número: "))
numero_02 = int(input("Introduce el segundo número: "))

if numero_02 != 0:
  division = numero_01 / numero_02
  print(numero_01, "/", numero_02, "=", division)
else:
  print("No se puede dividir entre 0.")