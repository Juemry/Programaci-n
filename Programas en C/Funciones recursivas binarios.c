#include <stdio.h>

void binario (int n);

int main () {
	
	int num=0;
	
	do{
	printf("Digite un numero para ver su version en binario: \n");
	scanf("%i", &num);
	} while (num<0);	
	
	binario (num);
	
	return 0;
}

void binario (int n){
	if (n>1)binario (n/2);
	printf("%i",n%2);
}
