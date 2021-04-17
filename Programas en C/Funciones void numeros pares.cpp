#include <stdio.h> 

void comprobar (int numero); //prototipo es decir como una anticipaci�n al programa de que existe una funci�n
//las funciones pueden ser de dos tipos, de tipo vacio (void, tambien llamadas procedimientos) [no devuelve ning�n dato] o de tipo de dato (int, char, float) [la funci�n devuelve el tipo de dato especificado]

int main () {
		
	int numero=0;
	
	printf("Digite un numero: \n");
	scanf("%i", &numero);
	
	comprobar (numero); //invoco a la funci�n vacio
	
	return 0;
}

void comprobar (int numero){ //funci�n de comprobaci�n de la paridad de tipo vacio
	if (numero%2==0)
	{
		printf("El numero es par\n");
	}
	else
	{
		printf("El numero es impar\n");
	}
}
