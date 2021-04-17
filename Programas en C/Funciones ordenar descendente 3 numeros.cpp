#include <stdio.h> 

void ascendente (int n1, int n2, int n3);

int main () {
	int n1=0,n2=0,n3=0;
	
	printf("Coloque tres numeros para ordenarlos de manera ascendente: \n");
	scanf("%i %i %i", &n1, &n2, &n3);
	
	ascendente (n1, n2, n3);
	
	return 0;
}

void ascendente (int n1, int n2, int n3){
	
	if(n1>=n2 && n1>=n3){
		if (n2>=n3) {
			printf("Los numeros en orden ascendente son: %i, %i y %i",n1,n2,n3);
		} else {
			printf("Los numeros en orden ascendente son: %i, %i y %i",n1,n3,n2);
		}
	} 
	
	else if(n2>=n1 && n2>=n3){
		if (n3>=n1) {
			printf("Los numeros en orden ascendente son: %i, %i y %i",n2,n3,n1);
		} else {
			printf("Los numeros en orden ascendente son: %i, %i y %i",n2,n1,n3);
	} 
	
	}else{
		if (n1>=n2) {
			printf("Los numeros en orden ascendente son: %i, %i y %i",n3,n1,n2);
		} else {
			printf("Los numeros en orden ascendente son: %i, %i y %i",n3,n2,n1);
		}
	}
}
