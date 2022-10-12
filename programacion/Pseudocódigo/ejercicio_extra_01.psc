Algoritmo EjercicioExtra01
	Escribir "Cual es su renta anual: ";
	Leer numero_01;
	
	Si (numero_01 < 10000) Entonces
		tipo_impositivo = numero_01 * 0.05;
		Escribir "Su tipo impositivo es del 5% " tipo_impositivo;
	FinSi
	
	Si ((numero_01 >= 10000) Y (numero_01 <= 20000)) Entonces
		tipo_impositivo = numero_01 * 0.15;
		Escribir "Su tipo impositivo es del 15% " tipo_impositivo;
	FinSi
	
	Si ((numero_01 >= 20000) Y (numero_01 <= 35000)) Entonces
		tipo_impositivo = numero_01 * 0.2;
		Escribir "Su tipo impositivo es del 20% " tipo_impositivo;
	FinSi
	
	Si ((numero_01 >= 35000) Y (numero_01 <= 60000)) Entonces
		tipo_impositivo = numero_01 * 0.3;
		Escribir "Su tipo impositivo es del 30% " tipo_impositivo;
	FinSi
	
	Si (numero_01 > 60000) Entonces
		tipo_impositivo = numero_01 * 0.45;
		Escribir "Su tipo impositivo es del 45% " tipo_impositivo;
	FinSi
FinAlgoritmo
