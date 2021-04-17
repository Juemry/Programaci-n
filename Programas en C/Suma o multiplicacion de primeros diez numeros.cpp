#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int i,n,suma, multi;
	i=1;
	suma=0;
	multi=1;
	
	printf("Digite un numero: \n");
	scanf("%i", &n);
	
	if (n<=10) {
		while (i<=10){
		suma = suma + i;
		i++;
		}
		printf("La operacion resulta en %i\n", suma); 
	} 
	else {
		while (i<=10){
		multi = multi * i;
		i++;
		}
		printf("La operacion resulta en %i\n", multi); 
	}  
	
	
		
	system ("Pause");
	return 0;
}
