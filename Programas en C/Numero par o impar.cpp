#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	int n;
	n=0;
	
	printf("Ingrese un numero\n");
	scanf("%i", &n);
	
	if (n % 2 == 0 ) { // aca se lee algo asi como "%" es el modulo de la división, es decir el resto que quedaria despues de dividir, en este caso por dos, y si el resto desp de dividir por dos es cero, el numero es par, habria que ver para identificar exclusivamente a los impares o en que otros contextos se puede utilizar el % modulo
		printf("El numero es par\n");
	} else 
	{
		printf("El numero es impar\n");
	}
	
	system ("Pause");
	return 0;
}
