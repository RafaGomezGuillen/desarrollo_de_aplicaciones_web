from os import truncate


print("Dado un número de segundos determinado por teclado, mostrar su correspondencia en horas, ",
      "minutos y segundos.")

numero_segundos = int(input("Introduce los segundos: "))

segundos = numero_segundos % 60
numero_minutos = (numero_segundos % 3600) / 60
numero_horas = numero_segundos / 3600

print(round(numero_horas, 0), ":", round(numero_minutos, 0), ":", round(segundos, 0))