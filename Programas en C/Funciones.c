#include <stdio.h> 

int comprobar (int numero); //prototipo es decir como una anticipaci�n al programa de que existe una funci�n
//las funciones pueden ser de dos tipos, de tipo vacio (void) [no devuelve ning�n dato] o de tipo de dato (int, char, float) [la funci�n devuelve el tipo de dato especificado]

int main () {
	system ("cls");
	
	int numero=0,x=0;
	
	printf("Digite un numero: \n");
	scanf("%i", &numero);
	
	x = comprobar (numero); //se agrega la variable x relacionando la funci�n principal con la funci�n de comprobaci�n
	//seg�n el valor de X, aportado por la funci�n comprobar, se va a imprimir si el n�mero es par o impar
	
	if (x==1)
	{
		printf("El numero es par\n");
	}
	else
	{
		printf("El numero es impar\n");
	}
	
	system ("Pause");
	return 0;
}

int comprobar (int numero){ //funci�n de comprobaci�n de la paridad
	if (numero%2==0)
	{
	return 1;
	} 
	else
	{
	return 2;
	}
}
