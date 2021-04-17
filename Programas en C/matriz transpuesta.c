//matrices transpuestas
 
#include <stdio.h>
#include <stdlib.h> 

#define fila 4
#define colu 4
 
 
int main(){

	int i,j;
	int matriz4 [fila] [colu];
	int matrizTranspuesta [fila] [colu];
	
	printf ("Introduce los valores para la matriz inicial de 4x4: \n");
	
	for (i=0; i<fila; i++){
		for(j=0; j<colu; j++){
			scanf("%d", &matriz4 [i] [j]); //Lectura de los valores iniciales
		}
		printf("\n");
	}
	
	//Proceso de transposicion de la matriz
	for (i=0; i<fila; i++){
		for(j=0; j<colu; j++){
			matrizTranspuesta [j] [i] = matriz4 [i] [j]; //Proceso de intercambio de los indices de lugar
		}
	}
	
	//Impresion de los resultados
	for (i=0; i<fila; i++){
		for(j=0; j<colu; j++){
			printf("%d", matrizTranspuesta [i] [j]); 
			printf(" ");
		}
		printf("\n");
	}
	
	
 return 0;
}
