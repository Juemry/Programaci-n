#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int i,num,factorial=1,suma_factorial=0;
	
	printf("Ingrese el numero del cual quiere calcular el factorial: \n");
	scanf("%i",&num);
	
	for(i=1;i<=num;i++){
		factorial*=i;
		//factorial=factorial*i;
		suma_factorial+=factorial;
	}
	
	printf("La suma de los factoriales del numero %i es %i\n", num, suma_factorial);
	
	system ("Pause");
	return 0;
}
