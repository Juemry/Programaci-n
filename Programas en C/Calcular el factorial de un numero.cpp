#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int i,num,factorial=1;
	
	printf("Ingrese el numero del cual quiere calcular el factorial: \n");
	scanf("%i",&num);
	
	for(i=1;i<=num;i++){
		factorial*=i;
		//factorial=factorial*i;
	}
	
	printf("El factorial del numero %i es %i\n", num, factorial);
	
	system ("Pause");
	return 0;
}
