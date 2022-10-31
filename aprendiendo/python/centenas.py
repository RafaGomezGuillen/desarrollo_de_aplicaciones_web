from os import truncate


import math
print("Dado un número por teclado, devolver la cifra correspondiente a las centenas.")

numero_01 = int(input("Introduce el número: "))
numero_centenas = (numero_01 % 1000) / 100

print("La centana de", numero_01, "=", math.trunc(numero_centenas))