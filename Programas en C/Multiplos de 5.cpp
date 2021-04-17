#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int n, i;
	
	printf("Digite el total de numero a comprobar\n");
	scanf("%i", &n);
	
	i=1;
	
	printf("Estos son los numeros multiplos de 5 desde 1 hasta el numero %i:\n",n);	
	
	while(i<=n) {
		if(i%5==0){
			printf("%i \n",i);
		}
		i++;
	}
	
	system ("Pause");
	return 0;
}
