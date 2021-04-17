#include <stdio.h> 
#include <math.h>

void funcion_matematica();

int main () {
	
	funcion_matematica();
	
	return 0;
}

void funcion_matematica(){
	float x, cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%f", &x);
	
	cambio = ceil(x);
	
	printf("%.2f", cambio);
	
}
