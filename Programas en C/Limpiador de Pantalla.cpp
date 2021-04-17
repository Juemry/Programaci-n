#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	char tecla;
	
	printf("Programa de borrado de pantalla");
	printf("-------------------------------\n");
	printf("-------------------------------\n");
	printf("-------------------------------\n");
	printf("Digite el numero 1 para limpiar la pantalla: ");
	scanf ("%c", &tecla);
	
	if (tecla=='1') { //cuando se compara un caracter se colocan comillas simples
		system("cls");
		printf("El limpiado de pantalla ha funcionado\n");
	}
	else {
		fflush(stdin); // función especial que sirve para limpiar el buffer, como para que no se llene la memoria interna del sistema, limpia el buffer para que yo pueda seguir almacenando datos
		printf("\nNo ha funcionado el limpiado de pantalla\n");
		printf("\nPor favor, digite el numero 1: ");
		scanf ("%c", &tecla);
		
		if (tecla=='1') { 
		system("cls");
		printf("El limpiado de pantalla ha funcionado\n");
	}
		else {
			printf("El limpiado de pantalla fallo, intente iniciando el programa nuevamente\n");
		}
		
	}
	
	
	system ("Pause");
	return 0;
}
