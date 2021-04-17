#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int n,m,i,suma=0;
	
	printf("Digite el numero desde el cual desea comenzar a sumar los numeros pares \n");
	scanf("%i",&n);
	
	printf("Digite el numero hasta el cual desea comenzar a sumar los numeros pares \n");
	scanf("%i",&m);
	
	i=n;
	
	while (i>=n && i<=m){
		if (i%2==0){
			suma=suma+i;
		}
		i++;

	}
		
	printf("La suma total de pares entre %i y %i es de %i\n",n,m,suma);

	system ("Pause");
	return 0;
}
