//Una función recursiva es una función que se llama a si misma.

// Vamos a hallar el factorial de un numero a traves de una funcion recursiva

#include <stdio.h> 
#include <time.h> 

long factorial(int n);

int main () {
	
	int num=0;
	
	printf("Digite un numero: \n");
	scanf("%i", &num);
	
	printf("El factorial del numero es: %li", factorial(num));
	
	return 0;
}

long factorial(int n){
	if (n<=1){
		return 1;
	} else {
		return (n*factorial(n-1));
	}
}

