#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int tv;
	
	printf("Ingrese el tipo de vehiculo (1 = turista / 2 = autobus / 3 = motocicleta)\n");
	scanf("%i", &tv);
	
	switch (tv){
		
		case 1: printf("Peaje = $ 500\n");break;
		case 2: printf("Peaje = $ 3000\n");break;
		case 3: printf("Peaje = $ 300\n");break;
		default: printf ("Vehiculo no autorizado\n");
	}
	
	system ("Pause");
	return 0;
}
