#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int i, n, x=0, y=1, z=1;
	
	printf("Ingrese la cantidad de numeros de la serie Fibbonacci que quiere conocer: \n");
	scanf("%i",&n);
	
	printf("1");
	
	for(i=1;i<n;i++){
		z=x+y;
		x=y;
		y=z;
		
		printf(", %i",z);
	}
	
	printf(".\n");
	
	system ("Pause");
	return 0;
}
