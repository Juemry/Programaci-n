#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	int i,suma=0;
	
for (i=0;i<=10;i+=2){
		if(i%2==0){
			suma+=i;
		}
	}

/*
	for (i=0;i<=10;i=i+2){
		if(i%2==0){
			suma=suma+i;
		}
	}


	for (i=1;i<=10;i++){
		if(i%2==0){
			suma=suma+i;
		}
	}
		
	*/
	
	printf("La suma de los primeros diez numeros pares es: %i \n", suma);

	
	system ("Pause");
	return 0;
}
