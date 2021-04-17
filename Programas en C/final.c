#include <stdio.h> 

int main () {
	
	int j = 2;
int vector[4] = {0, 200, 95, 100};
vector[3] = 95;
vector[2] = 100;
printf("%d", vector[j]);


	int pepe=2;
	printf("%i\n",pepe); 
	printf("%i\n",&pepe); 
	
	char cadena[] = "Hola";
	//char cadena[] = "LANIF";
	int i = 0;
	for(i = strlen(cadena) - 1 ; i >= 0; i--) // strlen devuelve la cantidad de caracteres de una cadena
	printf("%c",cadena[i]); 
 
	return 0;
}
