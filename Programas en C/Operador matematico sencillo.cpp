#include <stdio.h> 
#include <iostream>
#include <stdlib.h>
#include <math.h>

int main () {
	system ("cls");
	
	int opcion, num;
	//float num;
	
	printf("\tBienvenido a su operador matematico virtual\n");
	printf("\n1. Calcular el cubo de un numero");
	printf("\n2. Determinar si un numero es par o impar");
	printf("\n3. Salir");
	printf("\nOpcion: ");
	scanf("%i", &opcion);
	
	switch (opcion){
		case 1: printf("Ingrese el numero del cual quiere calcular el cubo: \n");
		scanf("%i", &num);
		num = pow(num,3);
		printf("El cubo del numero es %i\n",num); break;
		
		case 2: printf("Ingrese el numero del cual quiere determinar si es par o impar: \n");
		scanf("%i", &num);
		if (num%2==0){
			printf("El numero %i es par\n", num);
		}
		else{
			printf("El numero %i es impar\n", num);
		}break;
		
		case 3: printf("Usted ha salido del programa\n");break;
		
		default: printf("Ha ingresado una opcion invalida\n");
	}
	
	
	
	system ("Pause");
	return 0;
}
