#include <stdio.h> 
#include <time.h> 

void funcion_aleatoria();

int main () {
	
	funcion_aleatoria();
	
	return 0;
}

void funcion_aleatoria(){
	int num,i,limiteInferior,limiteSuperior;
	
	srand(time(NULL));
	
	printf("Digite el limite inferior: ");
	scanf("%i",&limiteInferior);
	
	printf("Digite el limite superior: ");
	scanf("%i",&limiteSuperior);
	
	
	for(i=1;i<=10;i++){
	num= limiteInferior+ rand()%((limiteSuperior+1)-limiteInferior);
	printf("%i\n", num);
	}
}

/*
// para imprimir 10 numeros aleatorios, uno abajo del otro, en un rango de 1 a 10
void funcion_aleatoria(){
	int num,i;
	
	srand(time(NULL));
	
	for(i=1;i<=10;i++){
	num= 1+ rand()%((10+1)-1);
	printf("%i\n", num);
	}
}
*/
/*
//para imprimir 1 vez 1 numero aleatorio, en un rango de 1 a 10
void funcion_aleatoria(){
	int num,i;
	
	srand(time(NULL));
	num= 1+ rand()%((10+1)-1);
	printf("%i\n", num);
	
}
*/
