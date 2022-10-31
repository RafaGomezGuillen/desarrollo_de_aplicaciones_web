print("Dado un precio inicial de una prenda, y un porcentaje de descuento, ",
      "mostrar cuál era el precio inicial, y cuál es el precio que debemos ",
      "pagar aplicado el descuento.")

numero_precio_inicial = float(input("Introduzca el precio inicial del producto: "))
numero_descuento = float(input("Introduzca el descuento del producto: "))

numero_descuento_aplicado = numero_precio_inicial - (numero_precio_inicial / 
                                                    100) * numero_descuento

print("Descuento del", numero_descuento, "% de un producto de", numero_precio_inicial,
      "=", numero_descuento_aplicado, "con descuento aplicado.")  