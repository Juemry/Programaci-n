#include <stdio.h> 

void menu ();
void sumar ();
void restar ();
void multiplicar ();
void dividir ();

int main () {
	
	menu();
	
	return 0;
}

void menu (){
	int opc;
	
	do {
	printf("1. Sumar\n");
	printf("2. Restar\n");
	printf("3. Multiplicar\n");
	printf("4. Dividir\n");
	printf("5. Salir\n");
	printf("Digite la opcion que desea: ");
	scanf("%i",&opc);
	
	switch(opc){
		case 1: sumar (); break;
		case 2: restar (); break;
		case 3: multiplicar (); break;
		case 4: dividir (); break;
		case 5: break;
		default: printf ("La opcion ingresada es incorrecta. Intente de nuevo\n"); continue;
	}
	
	} while (opc !=5);
	
}

void sumar (){
	int n1, n2, suma=0;
	printf("Digite 2 numeros: \n");
	scanf("%i %i", &n1, &n2);
	
	suma=n1+n2;
	
	printf("La suma de los dos numeros es de %i\n", suma);
}

void restar (){
	int n1, n2, suma=0;
	printf("Digite 2 numeros: \n");
	scanf("%i %i", &n1, &n2);
	
	suma=n1-n2;
	
	printf("La resta del primer numero menos es segundo resulta en %i\n", suma);
}

void multiplicar (){
	int n1, n2, multiplicacion=0;
	printf("Digite 2 numeros: \n");
	scanf("%i %i", &n1, &n2);
	
	multiplicacion=n1*n2;
	
	printf("La multiplicacion de los dos numeros es de %i\n", multiplicacion);
}

void dividir (){
	int n1, n2, dividir=0;
	printf("Digite 2 numeros: \n");
	scanf("%i %i", &n1, &n2);
	
	dividir=n1/n2;
	
	printf("La division del primer numero sobre es segundo resulta en %i\n", dividir);
}
