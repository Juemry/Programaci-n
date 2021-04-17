#include <stdio.h> 
#include <conio.h>

void copiandoArrays (int a [], int b [], int tamanio);

int main () {
	int array1 [5];
	int array2 [5];
	int i;
	
	printf("Digite cinco numeros: \n");
	
	for(i=0;i<5;i++){
		scanf("%i", &array1[i]);	
		i+1;
	}
	
	printf("\n Numeros guardados. Array copiado \n");	
	
	copiandoArrays(array1,array2,5);
		
	getch();
	return 0;
}

//debido al orden, los datos de la función son:
// a[]=array1
// b[]=array2

void copiandoArrays (int a [], int b [], int tamanio){
	int i;
	
	for(i=0;i<tamanio;i++){
		b[i] = a[i]; // array2 = array1
	}

	for(i=0;i<tamanio;i++){
		printf("%i \n", b[i]);//imprimiendo array1
	}
	
}
