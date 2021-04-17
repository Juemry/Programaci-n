#include <stdio.h> 
#include <string.h>
#include <stdlib.h> //libreria utilizada para la función strcmp que permite la compración de Strings de caracteres

int main () {
	system ("cls");
	
	char nombre [30], sexo [20]; //para hacer Strings se determina la cantidad de caracteres, creo que tambien habia otro metodo, quedará investigar para despues
	int edad;
	
	printf ("Digite su nombre: ");
	gets (nombre);
	printf ("Digite su sexo: ");
	gets (sexo);
	printf ("Digite su edad: ");
	scanf("%i", &edad);
	
	if (strcmp (sexo, "masculino") == 0 && edad>=18) { //strcmp es la función del programa que permite comparar cadenas de caracteres exactos y que es case sensitive, o sea que importan las mayusculas, para usar esta función se debe incluir la libreria string.h
		printf("%s es un hombre mayor de edad \n",nombre);
	}
	else 
	{
		printf("No es un hombre mayor de edad \n");
	}
	
	
	system ("Pause");
	return 0;
}
