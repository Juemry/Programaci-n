#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	int i, sdo, total;
	total = 0;
	system ("cls");
	
		for(i=1;i<=10;i++)// no termina con punto y coma, se abren llaves, podria ser menor a 11, se lee mientras que i sea menor o igual a 10 y que i va a ir creciendo de 1 en 1, pero podria ser de a más ¿Cómo? Un misterio
		{
			printf("Ingrese el sueldo del empleado %d \n", i);
			scanf("%d", &sdo); //con el & permite guardar el valor en esa variable sdo
			total = total + sdo;
		}
	printf("El total de los sueldos pagados es de %d\n", total);
	
	system ("Pause");
	return 0;
}
