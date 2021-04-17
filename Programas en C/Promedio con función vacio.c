#include <stdio.h> 

void calculo (); 

int main () {
		
	int n1,n2;
	
	printf("Digite dos numeros para sacar su promedio: \n");
	scanf("%i %i", &n1, &n2);
	
	//no habia llamado a la función e igual se imprimio, jejej
	
	//ahi la llamo
	
	calculo(); //llamado a la función o invocación de la función
		
	return 0;
}

void calculo () { //va sin nada adentro

	int a1,a2,promedio=0; //puede ir con distintas variables, se reasignan los valores
	promedio = (a1+a2)/2;
	printf("El promedio de los dos numeros ingresados es %i \n", promedio);
	
}
