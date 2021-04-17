#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int i, n, suma=0, cont=0;
	
	printf("Ingrese un numero para saber la suma de los numeros pares entre 1 y ese numero : \n");
	scanf("%i",&n);
		
	for(i=1;i<=n;i++){
		if (i%2==0){
			suma=suma+i;
			
			cont++;
		}	
	}
	
	printf("La suma de los numeros pares entre 1 y el ingresado es de %i.\n",suma);
	printf("Y la cantidad de numeros pares es de %i\n",cont);
		
	system ("Pause");
	return 0;
}
