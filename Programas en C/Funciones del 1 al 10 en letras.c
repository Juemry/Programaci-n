#include <stdio.h> 

void entradaDeDatos ();
void salidaDeDatos ();

int main () {
	
	int num=0;
	
	do{
	entradaDeDatos ();
	salidaDeDatos ();
	} while (num != 0);
	
	return 0;
}

void entradaDeDatos (){
	int num;
	printf("Ingrese un numero del 1 al 10 para verlo escrito en letras (0 para salir): \n");
	scanf("%i", &num);
}

void salidaDeDatos (){
	int num;
	switch (num) {
		case 1: printf("Uno\n");break;
		case 2: printf("Dos\n");break;
		case 3: printf("Tres\n");break;
		case 4: printf("Cuatro\n");break;
		case 5: printf("Cinco\n");break;
		case 6: printf("Seis\n");break;
		case 7: printf("Siete\n");break;
		case 8: printf("Ocho\n");break;
		case 9: printf("Nueve\n");break;
		case 10: printf("Diez\n");break;
		default: printf("El numero ingresado es incorrecto. Intente nuevamente \n");
		}
}
