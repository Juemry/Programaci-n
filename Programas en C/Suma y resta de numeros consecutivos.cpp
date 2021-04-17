#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int n,i,suma=0,suma_pares=0,suma_impares=0,negativo;
	
	printf("Digite el total de elementos a sumar y restar: \n");
	scanf("%i",&n);
	
	i=1;
	
	while (i<=n){
		if(i%2==0){
			negativo = i*(-1);
			suma_pares = suma_pares + negativo;
		}
		else{
			suma_impares = suma_impares + i;
		}
		i++;
	}
	
	suma = suma_pares + suma_impares;
	
	printf("La suma total es %i\n", suma);

	system ("Pause");
	return 0;
}
