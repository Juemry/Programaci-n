#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int opcion;
	float agregar, retirar, saldo = 1000;
	
	printf("\tBienvenido a su cajero virtual\n");
	printf("\n1. Ingresar dinero en cuenta");
	printf("\n2. Retirar dinero de la cuenta");
	printf("\n3. Salir");
	printf("\nOpcion: ");
	scanf("%i", &opcion);
	
	switch (opcion){
		case 1: printf("Cuanto dinero desea ingresar en cuenta\n");
		scanf("%f", &agregar);
		saldo = saldo+agregar;
		printf("El saldo total es de: %.2f\n",saldo); break;
		
		case 2: printf("Cuanto dinero desea retirar?\n");
		scanf("%f", &retirar);
		if (retirar>saldo){
			printf("La cantidad a retirar es mayor al saldo\n");
		}
		else{
			saldo = saldo - retirar;
			printf("El saldo disponible es de %.2f\n",saldo);
		}break;
		
		case 3: printf("Usted ha salido del programa\n");break;
		
		default: printf("Ha ingresado una opcion invalida\n");
	}
	
	
	
	system ("Pause");
	return 0;
}
