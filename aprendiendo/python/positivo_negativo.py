print("Introducir un número por teclado y mostrar el mensaje de si es positivo o negativo.")

numero_01 = int(input("Introduce el primer número: "))

if numero_01 > 0:
  print(numero_01, "es positivo.")
elif numero_01 < 0:
  print(numero_01, "es negativo.")
else:
  print(numero_01, "es neutro.")