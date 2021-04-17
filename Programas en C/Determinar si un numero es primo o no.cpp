#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int i,num,cont=0;
	
	printf("Digite un numero para determinar si es primo o no\n");
	scanf("%i", &num);
	
	for (i=1;i<=num;i++){
		if(num%i==0){
			cont++;
		}
	}
	
	if (cont>2){
		printf("El numero es compuesto\n");
	}
	else {
		printf("El numero es primo\n");
	}
	
	system ("Pause");
	return 0;
}
