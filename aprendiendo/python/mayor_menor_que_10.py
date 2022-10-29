print("Pide un número por teclado y muestra si es mayor que diez, ",
      "menor que diez o igual a diez.")

numero_01 = int(input("Introduce un número entero: "))

if numero_01 > 10:
  print(numero_01, "> 10.")
elif numero_01 < 10:
  print(numero_01, "< 10.")
else:
  print(numero_01, "= 10.")