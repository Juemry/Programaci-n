#include <stdio.h> 

void comprobar (int numero); //prototipo es decir como una anticipación al programa de que existe una función
//las funciones pueden ser de dos tipos, de tipo vacio (void, tambien llamadas procedimientos) [no devuelve ningún dato] o de tipo de dato (int, char, float) [la función devuelve el tipo de dato especificado]

int main () {
		
	int numero=0;
	
	printf("Digite un numero: \n");
	scanf("%i", &numero);
	
	comprobar (numero); //invoco a la función vacio
	
	return 0;
}

void comprobar (int numero){ //función de comprobación de la paridad de tipo vacio
	if (numero%2==0)
	{
		printf("El numero es par\n");
	}
	else
	{
		printf("El numero es impar\n");
	}
}
