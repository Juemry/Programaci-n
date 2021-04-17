// 3x13: Suma dos matrices
/*
 Escribe un programa que solicite al usuario dos matrices y las sume.
*/
 
 
#include <stdio.h>
#include <stdlib.h> 

#define fil 4
#define col 4
 
 
main(){
 
 system("cls");
 
 int mA[fil][col];
 int mB[fil][col];
 int mC[fil][col];
 
 int i, j, k, l;
 
 
 printf("\vA continuacion se sumaran dos matrices de %ix%i. Comience a introducir los datos:\n\v", fil, col);
 
 // Se ponen las matrices a cero:
 for( i=0; i<fil; i++ ){
 for( j=0; j<col; j++ ){
 mA[i][j] = 0;
 mB[i][j] = 0;
 }; 
 };
 
 
 // Se introducen los valores de la matriz Uno:
 for( i=0; i<fil; i++ ){ // La i marca las filas
 
	 for( j=0; j<col; j++ ){ // La j marca las columnas
	 
		 // En la fila i, columna j, se guarda el entero introducido:
		 scanf( "%i", &mA[i][j] );
		 system("cls");
		 
		 // Se imprime la matriz completa con el valor almacenado:
		 printf( "Primera matriz\n");
		 for( k=0; k<fil; k++ ){
		 
			 for( l=0; l<col; l++ ){
			 printf( " %i ", mA[k][l] );
			 }; 
			 
			 printf( "\n");
		 }; 
	 
	 }; 
 
 };
 system("cls");
 
 
 // Se introducen los valores de la matriz Dos:
 printf( "Segunda matriz\n");
 for( i=0; i<fil; i++ ){
 
 for( j=0; j<col; j++ ){
 
 // En la fila i, columna j, se guarda el entero introducido:
 scanf( "%i", &mB[i][j] );
 system("cls");
 
 // Se imprime la matriz completa con el valor almacenado:
 printf( "Segunda matriz\n");
 for( k=0; k<fil; k++ ){
 
 for( l=0; l<col; l++ ){
 printf( " %i ", mB[k][l] );
 }; 
 
 printf( "\n");
 }; 
 
 }; 
 
 }; 
 system("cls");
 
 
 // Se calcula el resultado:
 for( i=0; i<fil; i++ ){
 
 for( j=0; j<col; j++ ){
 mC[i][j] = mA[i][j] + mB[i][j];
 }; 
 
 }; 
 
 
 // y se imprimen las tres matrices
 printf( "Primera matriz   +   Segunda matriz   =   Matriz resultado\n");
 for( i=0; i<fil; i++ ){
 
 printf(" ");
 for( j=0; j<col; j++ ){
 printf( " %i ", mA[i][j] );
 };
 printf( "         ");
 for( j=0; j<col; j++ ){
 printf( " %i ", mB[i][j] );
 };
 printf( "          ");
 for( j=0; j<col; j++ ){
 printf( " %i ", mC[i][j] );
 }; 
 printf( "\n");
 
 }; 
 
 printf( "\v\v");
 
};
