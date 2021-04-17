#include <stdio.h> 

float fahrenheit (float C);
float kelvin (float C);

int main () {
	int opc;
	float C=0,F=0,K=0;
	
		
	do {
		printf("Digite el valor de los grados Celsius: \n");
		scanf("%f", &C);
		
		printf("1. Convertir a grados Fahrenheit\n");
		printf("2. Convertir a grados Kelvin\n");
		printf("3. Salir\n");
		printf("Digite la opcion que desee: \n");
		scanf("%i", &opc);
		
		switch (opc) {
			case 1: F = fahrenheit (C);
			printf ("El equivalente en grados Fahrenheit es: %f \n\n", F); 
			break;
			case 2: K= kelvin (C);
			printf ("El equivalente en grados Kelvin es: %f \n\n", K); 
			break;
			case 3: printf("Hasta luego!\n"); break;
			default: printf ("Ha ingresado un numero incorrecto\n"); break;
		}
		
	} while (opc != 3);
	
	
	return 0;
}

float fahrenheit (float C){
	float F;
	F = (9*C)/5 +32;
	return F;
}

float kelvin (float C){
	float K;
	K = C + 273.15;
	return K;
}

	
