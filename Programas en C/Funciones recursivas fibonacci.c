#include <stdio.h>

int fibonacci (int n);

int main () {
	
	int num=0, i=0;
	
	printf("Digite el numero de la serie Fibonacci que desea conocer: \n");
	scanf("%i", &num);
	
	printf("Los numeros de la serie Fibonacci son: \n");
	for(i=1;i<=num;i++){
	printf("%i ", fibonacci(i));
	}
	return 0;
}

int fibonacci (int n){
	if (n==0 || n==1){
		return n;
	} else {
		return (fibonacci(n-1)+fibonacci(n-2));
	}
}
