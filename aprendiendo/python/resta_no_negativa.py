from turtle import numinput


print("Presenta por pantalla la resta de dos números solicitados por teclado. ",
      "No puede devolver el resultado como un número negativo.")

numero_01 = int(input("Introduce el primer número: "))
numero_02 = int(input("Introduce el segundo número: "))

if numero_01 >= numero_02:
  resta = numero_01 - numero_02
  print(numero_01, "-", numero_02, "=", resta)
else:
  resta = numero_01 - (- numero_02)
  print("Resta negativa.", numero_01, "-", numero_02, "=", resta)