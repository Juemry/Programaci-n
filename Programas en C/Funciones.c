#include <stdio.h> 

int comprobar (int numero); //prototipo es decir como una anticipación al programa de que existe una función
//las funciones pueden ser de dos tipos, de tipo vacio (void) [no devuelve ningún dato] o de tipo de dato (int, char, float) [la función devuelve el tipo de dato especificado]

int main () {
	system ("cls");
	
	int numero=0,x=0;
	
	printf("Digite un numero: \n");
	scanf("%i", &numero);
	
	x = comprobar (numero); //se agrega la variable x relacionando la función principal con la función de comprobación
	//según el valor de X, aportado por la función comprobar, se va a imprimir si el número es par o impar
	
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

int comprobar (int numero){ //función de comprobación de la paridad
	if (numero%2==0)
	{
	return 1;
	} 
	else
	{
	return 2;
	}
}
