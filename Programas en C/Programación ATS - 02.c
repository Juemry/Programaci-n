// Directivas del preprocesador y variables

#include<stdio.h> //librerias agregadas
#include<string.h>
#include<math.h>
#include<stdlib.h>

#define PI 3.1416 // macro

int y = 5; // variable global (por la posición, afuera de una función//

int main (){ //función principal
	int x = 10; //variable local (adentro de la función)
	
	float suma = 0; //float permite la inclusión de números decimales
	
	suma = PI + x;
	
	printf ("La suma es %.3f", suma); //% sigo sin saber para que sirve, pero tenia el i para los int o enteros y el f para los datos "float" y el .3 para la cantidad de decimales
	
	return 0;
}
