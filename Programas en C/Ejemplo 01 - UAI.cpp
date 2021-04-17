#include <stdio.h> //librerias, habría que saber bien que son o cuales son
#include <iostream>
#include <stdlib.h>

int main () //los parentesis representan que es una función
{
	int ch, vh, sdo;
	printf("Ingrese la cantidad de horas trabajadas");
	scanf("%d", &ch); //%d es una mascara, es de un tipo de dato, es un tipo de dato entero, guarda el dato ingresado de tipo entero ... separado con coma va la variable y el simbolo & significa la dirección a que dato, el nexo entre el dato y la variable
	printf("Ingrese el valor de las horas trabajadas");
	scanf("%d", &vh);
	sdo=ch*vh;// a la izquierda siempre va el dato que recibe el valor de la cuenta, al revés no funciona
	printf("El sueldo es de %d", sdo);
	system("Pause");
	return 0; //para terminar la función principal
}

