#include <stdio.h> 
#include <math.h> // Alejandro ATS quería que funcionara sin la libreria de matemáticas, pero evidentemente me hace falta a mi


void funcion_matematica();

int main () {
	
	funcion_matematica();
	
	return 0;
}


void funcion_matematica(){
	int x;
	float cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%i", &x);
	
	cambio = sqrt(x); //para sqrt no hace falta la biblioteca math.h
	
	printf("%.2f", cambio);
	
}

/*
void funcion_matematica(){
	int x, y;
	float cambio=0;
	
	printf("Digite dos numeros: \n");
	scanf("%i %i", &x, &y);
	
	cambio = pow(x,y); //para pow no hace falta la biblioteca math.h
	
	printf("%.2f", cambio);
	
}
*/
/*
void funcion_matematica(){
	int x, y;
	float cambio=0;
	
	printf("Digite dos numeros: \n");
	scanf("%i %i", &x, &y);
	
	cambio = fmod(x,y); //para fmod no hace falta la biblioteca math.h
	
	printf("%.2f", cambio);
	
}
*/
/*
void funcion_matematica(){
	float x, cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%f", &x);
	
	cambio = floor(x); //para floor no hace falta la biblioteca math.h
	
	printf("%.2f", cambio);
	
}
*/
/*
void funcion_matematica(){
	float x, cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%f", &x);
	
	cambio = fabs(x); //para fabs no hace falta la biblioteca math.h
	
	printf("%.2f", cambio);
	
}
*/

/*
void funcion_matematica(){
	float x, cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%f", &x);
	
	cambio = ceil(x); // para ceil es necesaria la biblioteca math.h
	
	printf("%.2f", cambio);
	
}*/


