Algoritmo PorcentajeDelCentroEducativo
	Escribir "Un centro educativo desea saber qu� porcentaje de ni�os y qu� porcentaje de ni�as hay en el curso actual, pasando por teclado el n�mero de chicas y de chicos.";
	
	Escribir "Introduzca el numero de chicos: ";
	Leer numero_chicos;
	
	Escribir "Introduzca el numero de chicas: ";
	Leer numero_chicas;
	
	total = numero_chicas + numero_chicos;
	numero_chicas = (numero_chicas / total) * 100;
	numero_chicos = (numero_chicos / total) * 100;
	
	Escribir numero_chicas "% de chicas y " numero_chicos "% de chicos de un total de " total " alumnos";
FinAlgoritmo
