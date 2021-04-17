/*Ej 2 2do Parcial

Codifique las siguientes funciones en un mismo programa:
a) Que permita cargar una matiz de 4x4 por pantalla.
b) Que calcule el valor maximo de la matriz, sus duplicados y en que posicion se encuentran.
c) Utilizando un solo ciclo FOR, ningun IF, que permita calcular la suma de sus diagonal principal.
d) Calcular el valor promedio de la matriz y cuantos de sus valores son mayores a ese promedio.*/

#include <stdio.h>
#include <conio.h>


int main()
{
    //Crear las variables
    int matriz[4][4];
    int matrizValor[4][4];
    int matrizFilas[4][4];
    int matrizColumnas[4][4];
    int matrizFilas1[4][4];
    int matrizColumnas1[4][4];
    int i=0;
	int j=0;
	int k=0;
	int l=0;
	int imayor=0;
	int jmayor=0;
    int suma=0;
	int total=0;
    float promedio=0;
    int imayorAlProm=0;
	int jmayorAlProm=0;
    int mayorAlPromTot=0;
    int mayor=0;
    int filas=4;
    int columnas=4;
    int diagonal=0;
    
    int matrizValor2[4][4];
    
    //a) Ingreso de datos filas y columnas de la matriz
    printf ("Ingrese los numeros de la matriz:\n");
    for (i=0;i<filas;i++){
    	printf("Coloque los datos de la fila numero %i: \n", i+1);
        for (j=0;j<columnas;j++){
            scanf ("%i", &matriz[i][j]);
        }
	}
	
    //Se imprime la matriz resultante 
			printf( "Matriz resultante: \n");
			for( i=0; i<filas; i++ ){
			 	for( j=0; j<columnas; j++ ){
			 		printf( " %i ", matriz[i][j] );
				}
				printf( "\n");
			}
    
    printf("\n\n**Impresion de resultados**\n\n");
    
    //c) Calcular la suma de diagonal principal.   
    	
    printf( "Los numeros de la diagonal principal son: \n");
		for( i=0; i<filas; i++ ){	 
			diagonal=diagonal+matriz[i][i];
			printf( " %i ", matriz[i][i] ); 		
		}
		printf( "\n");
		printf ("El valor de la suma diagonal principal es : %i\n", diagonal);
		printf( "\n\n");
    
	

    //d) Calcular el valor promedio de la matriz.  
	for( i=0; i<filas; i++ ){
		for( j=0; j<columnas; j++ ){
			total= total+matriz[i][j];
		}
	}
	printf ("El valor total de la matriz es: %i \n", total);
	promedio=total/16;
    printf ("El valor promedio de la matriz es: %.2f\n", promedio); //no pude hacer que salga con los decimales correspondienes

    //Cuantos valores son mayores a ese promedio.
    for( i=0; i<filas; i++ ){
		for( j=0; j<columnas; j++ ){
			if(matriz[i][j]<=promedio){
	            mayorAlPromTot++;
	        }
		}
	}
    printf ("La cantidad de valores mayores al promedio es : %i\n", mayorAlPromTot);
  	printf( "\n\n");
    
    //b) Calcular el valor maximo de la matriz
    for (i=0;i<filas;i++){
        for (j=0;j<columnas;j++){
            if (matriz[i][j]>mayor){
                mayor=matriz[i][j];
                imayor=i;
                jmayor=j;
            }
        }    
    }
    printf ("El mayor valor de la matriz es : %i\n", mayor);
    printf ("La posicion del mayor valor es fila: [%i] columna: [%i]\n", imayor, jmayor);
    printf( "\n\n");
    
    
    
	printf("Los valores duplicados de la matriz son: \n");
	//Se comparan los valores de la matriz consigo misma y cuando se encuentra un valor duplicado se guarda el valor y su ubicacion
	for (k=0; k<filas; k++){  
    	for (l=0; l<columnas; l++){
			for (i=0; i<filas; i++){
				for (j=0; j<columnas; j++){
	              if (matriz[k][l]==matriz[i][j])// &&(i!=k&&j!=l))
	              {
	              matrizValor[i][j]=matriz[i][j];
	              matrizFilas[i][j]=i;
	              matrizColumnas[i][j]=j;
	              printf("Valor : %i \n", matrizValor[i][j]);
				  printf("La ubicacion del valor es: fila %i columna %i \n", matrizFilas[i][j], matrizColumnas[i][j]);
	              } 
	             // else if (matriz[j][i]==matriz[l][k])
	             // {
	             // matrizValor2[i][j]=matriz[i][j]; 
	             //}
	              else
	              {
	              matrizValor[i][j]=0;
	              matrizFilas[i][j]=0;
	              matrizColumnas[i][j]=0;
				  }
         		}
        	}
      	}
	}
 
    
			
	//Impresion de los valores duplicados encontrados con su ubicacion
			for (i=0; i<filas; i++){
				for (j=0; j<columnas; j++){
	              if (matriz[i][j]==matrizValor[i][j])
	              {
	              printf("Valor : %i \n", matrizValor[i][j]);
				  printf("La ubicacion del valor es: fila %i columna %i \n", matrizFilas[i][j], matrizColumnas[i][j]);
				  
	              } 
         		}
        	}

			printf( "Matriz resultante DE VALOR: \n");
			for( i=0; i<4; i++ ){
			 	for( j=0; j<4; j++ ){
			 		printf( " %i ", matrizValor [i][j] );
				}; 
			printf( "\n");
			}; 	
			
			printf( "Matriz resultante DE ORIGINAL: \n");
			for( i=0; i<4; i++ ){
			 	for( j=0; j<4; j++ ){
			 		printf( " %i ", matrizValor2 [i][j] );
				}; 
			printf( "\n");
			}; 	
				printf( "Matriz resultante DE FILAS: \n");
			for( i=0; i<4; i++ ){
			 	for( j=0; j<4; j++ ){
			 		printf( " %i ", matrizFilas [i][j] );
				}; 
			printf( "\n");
			}; 	
			
				printf( "Matriz resultante DE COLUMNA: \n");
			for( i=0; i<4; i++ ){
			 	for( j=0; j<4; j++ ){
			 		printf( " %i ", matrizColumnas [i][j] );
				}; 
			printf( "\n");
			}; 	
	
    return 0;
}

