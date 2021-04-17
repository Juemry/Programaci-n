#include <stdio.h>

int funcion (int n);

int main () {
	
	int num=0, i=0;
	
	printf("Digite un numero para ver todos numeros desde el 1: \n");
	scanf("%i", &num);
	
	printf("Los numeros del 1 al %i son: \n",num);
	
	for(i=1;i<=num;i++){
	printf("%i ", funcion(i));
	}
	printf("%i", num);
	return 0;
}

int funcion (int n){
	if (n<=1){
		return 0;
	} else {
		return (n-1);
	} 
}
