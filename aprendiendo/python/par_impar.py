print("Introducir un número por teclado y mostrar el mensaje de si es par o impar.")

numero_01 = int(input("Introduce el primer número: "))

if numero_01 % 2 == 0:
  print(numero_01, "es par.")
else:
  print(numero_01, "es impar.")