#include <stdio.h> 
#include <conio.h>

int main () {
	/*
	//Array entero, se imprime del 1 al 5, de la posicion 0 a 4
	int i,a[5]= {1,2,3,4,5};
	
	for(i=0;i<5;i++){
		printf("%i. \n" , a[i]);	
	}
	*/
	
	/*
	//Array de flotantes, se piden 5 datos al usuario de tipo float, se guardan en las posiciones del vector y se imprimen, todo con ciclos
	float a[5];
	int i;
	
	for(i=0;i<5;i++){
		printf("%i. Digite un numero: \n", i+1);
		scanf("%f", &a[i]);	
	}
	
		printf("\n\n" , a[i]);	
	
	for(i=0;i<5;i++){
		printf("%.2f \n" , a[i]);	
	}
	*/
	
	/*
	//Arrays de caracteres, con las vocales pre colocadas, su impresión
	char a[5]= {'a','e','i','o','u'};
	int i;
	
	for(i=0;i<5;i++){
		printf("%c \n" , a[i]);	
	}
	*/
	
	//Arrays de palabras, pide un nombre y su impresión

	
	char a[20]= "Julian";
	
	printf("Digite su nombre: ");
	gets(a);
	
	printf ("%s", a);
	
	
	
	getch();
	return 0;
}
