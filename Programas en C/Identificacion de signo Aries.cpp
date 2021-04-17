#include <stdio.h> 
#include <string.h>
#include <stdlib.h>

int main () {
	system ("cls");
	
	char nombre [30], signo [20];
	
	printf ("Digite su nombre: ");
	gets (nombre);
	printf ("Digite su signo: ");
	gets (signo);
	
	if (strcmp (signo, "aries") == 0) {
		printf("\n %s es de signo Aries \n",nombre);
	}
	else 
	{
		printf("\n No es de signo Aries \n");
	}
	
	
	system ("Pause");
	return 0;
}
