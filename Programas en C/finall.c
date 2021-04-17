#include <stdio.h> 

int main () {
	int num = 0;
	int i = 0;
	
	printf("Ingrese el numero para mostrar los numeros entre cero y este numero\n"); 
	scanf("%i", &num);
	
	
	printf("Los numeros entre 0 y %i son: \n", num); 
	for(i = 1; i < 4 ; i++) {
	printf("%i\n",i); 
}
	return 0;
}
