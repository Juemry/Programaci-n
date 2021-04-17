/*
Realizar un programa que permita realizar y mostrar el resultado de
las operaciones de suma y multiplicación de 2 matrices 3 x 3 y la
función transpuesta de una matriz 4 x 4 (Los datos de todas las
matrices las ingre#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */


#define fil 3
#define col 3

void valoresMatrices (int matriz1 [][col], int matriz2 [][col], int, int);
void sumaMatrices  (int matriz1 [][col], int matriz2 [][col], int matriz3 [][col]);


int main(int argc, char *argv[]) {
	
	/*
	Realizar un programa que permita realizar y mostrar el resultado de
	las operaciones de suma y multiplicación de 2 matrices 3 x 3 y la
	función transpuesta de una matriz 4 x 4 (Los datos de todas las
	matrices las ingresa el usuario).
	*/

	int fil = 3;
	int col = 3;
	//Declaración de variables
	int i=0;
	int j=0;
	int k=0;
	int l=0;
	int opcion = 0;
	int matriz1 [fil][col];
	int matriz2 [fil][col];
	int matriz3 [fil][col];

	//Menu Inicial - Solicitud de datos al usuario
	printf("Seleccione una de las siguientes opciones para operar con matrices: \n");
	printf("1: Suma de dos matrices 3x3 \n");
	printf("2: Multiplicacion de dos matrices 3x3 \n");
	printf("3: Suma y multiplicacion de dos matrices 3x3 \n");
	printf("4: Funcion transpuesta de una matriz 4x4 \n");
	printf("0: Salir \n");
	scanf("%i", &opcion);
	
	switch (opcion){
		case 1: printf("Ingrese los datos para la suma de dos matrices 3x3: \n");
		valoresMatrices (matriz1, matriz2, fil, col);
		sumaMatrices (matriz1, matriz2, matriz3);
		case 2: printf("Ingrese los datos para la multiplicacion de dos matrices 3x3 \n");
		break;
		case 3: printf("Ingrese los datos para la suma y multiplicacion de dos matrices 3x3 \n");
		break;
		case 4: printf("Ingrese los datos para la funcion transpuesta de una matriz 4x4 \n");
		break;
		case 0: printf ("Usted a seleccionado salir del programa");
		return 0;
		break;
		default: printf("Ha ingresado una opcion invalida\n");
	}
	
return 0;
}

void valoresMatrices (int matriz1 [fil] [col], int matriz2 [fil] [col], int fil, int col) {
			int i,j,k,l;
			// Introducción de los valores de la primera matriz
		 	for(i=0; i<fil; i++){ // i corresponde a filas
			 	for(j=0; j<col; j++){ // j corresponde a columnas
			 		scanf("%i", &matriz1[i][j]);
				}
			}
			//Impresion de los valores almacenados en la primera matriz
			printf("Primera matriz:\n");
			for(k=0; k<fil; k++ ){
				for( l=0; l<col; l++ ){
					printf( " %i ", matriz1[k][l]);
				}
				printf( "\n");
			} 
				 	 
		 	// Introducción de los valores de la segunda matriz
		 	for(i=0; i<fil; i++){ // i corresponde a filas
				for(j=0; j<col; j++){ // j corresponde a columnas
			 		scanf("%i", &matriz2[i][j]);
				}
			}
			//Impresion de los valores almacenados en la segunda matriz
			printf("Segunda matriz:\n");
				for(k=0; k<fil; k++ ){
				 	for( l=0; l<col; l++ ){
						printf( " %i ", matriz2[k][l] );
					}; 
					printf( "\n");
}
void sumaMatrices (int matriz1 [] [col], int matriz2 [] [col], int matriz3 [] [col]) {
			int i,j,k,l;
			// Se calcula el resultado:
			for( i=0; i<fil; i++ ){
			 	for( j=0; j<col; j++ ){
					matriz3[i][j] = matriz1[i][j] + matriz2[i][j];
			 	}; 
			}; 
			//Se imprime la matriz resultante de la suma
			printf( "Matriz resultante: \n");
			for( i=0; i<fil; i++ ){
			 	for( j=0; j<col; j++ ){
			 		printf( " %i ", matriz3 [i][j] );
				}; 
			printf( "\n");
			}
	}
}
	
sa el usuario).
*/

#include <stdio.h> 

#define fil 3
#define col 3

void valoresMatrices (int matriz1 [] [col], int matriz2 [] [col]);
void sumaMatrices  (int matriz1 [] [col], int matriz2 [] [col], int matriz3 [] [col]);

int main () {
	//Declaración de variables
	int i=0;
	int j=0;
	int k=0;
	int l=0;
	int opcion = 0;
	int matriz1 [fil][col];
	int matriz2 [fil][col];
	int matriz3 [fil][col];

	//Menu Inicial - Solicitud de datos al usuario
	printf("Seleccione una de las siguientes opciones para operar con matrices: \n");
	printf("1: Suma de dos matrices 3x3 \n");
	printf("2: Multiplicacion de dos matrices 3x3 \n");
	printf("3: Suma y multiplicacion de dos matrices 3x3 \n");
	printf("4: Funcion transpuesta de una matriz 4x4 \n");
	printf("0: Salir \n");
	scanf("%i", &opcion);
	
	switch (opcion){
		case 1: printf("Ingrese los datos para la suma de dos matrices 3x3: \n");
		valoresMatrices (matriz1, matriz2);
		sumaMatrices (matriz1, matriz2, matriz3);
		case 2: printf("Ingrese los datos para la multiplicacion de dos matrices 3x3 \n");
		break;
		case 3: printf("Ingrese los datos para la suma y multiplicacion de dos matrices 3x3 \n");
		break;
		case 4: printf("Ingrese los datos para la funcion transpuesta de una matriz 4x4 \n");
		break;
		case 0: printf ("Usted a seleccionado salir del programa");
		return 0;
		break;
		default: printf("Ha ingresado una opcion invalida\n");
	}
	
return 0;
}

void valoresMatrices (int matriz1 [] [col], int matriz2 [] [col]) {
			int i,j,k,l;
			// Introducción de los valores de la primera matriz
		 	for(i=0; i<fil; i++){ // i corresponde a filas
			 	for(j=0; j<col; j++){ // j corresponde a columnas
			 		scanf("%i", &matriz1[i][j]);
				}
			}
			//Impresion de los valores almacenados en la primera matriz
			printf("Primera matriz:\n");
			for(k=0; k<fil; k++ ){
				for( l=0; l<col; l++ ){
					printf( " %i ", matriz1[k][l]);
				}
				printf( "\n");
			} 
				 	 
		 	// Introducción de los valores de la segunda matriz
		 	for(i=0; i<fil; i++){ // i corresponde a filas
				for(j=0; j<col; j++){ // j corresponde a columnas
			 		scanf("%i", &matriz2[i][j]);
				}
			}
			//Impresion de los valores almacenados en la segunda matriz
			printf("Segunda matriz:\n");
				for(k=0; k<fil; k++ ){
				 	for( l=0; l<col; l++ ){
						printf( " %i ", matriz2[k][l] );
					}; 
					printf( "\n");
}
void sumaMatrices (int matriz1 [] [col], int matriz2 [] [col], int matriz3 [] [col]) {
			int i,j,k,l;
			// Se calcula el resultado:
			for( i=0; i<fil; i++ ){
			 	for( j=0; j<col; j++ ){
					matriz3[i][j] = matriz1[i][j] + matriz2[i][j];
			 	}; 
			}; 
			//Se imprime la matriz resultante de la suma
			printf( "Matriz resultante: \n");
			for( i=0; i<fil; i++ ){
			 	for( j=0; j<col; j++ ){
			 		printf( " %i ", matriz3 [i][j] );
				}; 
			printf( "\n");
			}
	}
}
