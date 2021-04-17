#include <stdio.h> 
#include <math.h> 


void funcion_trigonometrica();

int main () {
	
	funcion_trigonometrica();
	
	return 0;
}


void funcion_trigonometrica(){
	float x,cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%f", &x);
	
	cambio = tan(x); //tangente del angulo, resutado en radianes
	
	printf("%.2f", cambio);
}

/*
void funcion_trigonometrica(){
	float x,cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%f", &x);
	
	cambio = sin(x); //seno del angulo, resutado en radianes
	
	printf("%.2f", cambio);
}
*/
/*

void funcion_trigonometrica(){
	float x,cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%f", &x);
	
	cambio = cos(x); //cosano del angulo, resutado en radianes
	
	printf("%.2f", cambio);
}

*/
/*
void funcion_trigonometrica(){
	float x,cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%f", &x);
	
	cambio = atan(x); 
	
	printf("%.2f", cambio);
}
*/
/*
void funcion_trigonometrica(){
	float x,cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%f", &x);
	
	cambio = asin(x); 
	
	printf("%.2f", cambio);
}
*/

/*
void funcion_trigonometrica(){
	float x,cambio=0;
	
	printf("Digite un numero: \n");
	scanf("%f", &x);
	
	cambio = acos(x); 
	
	printf("%.2f", cambio);
}*/


