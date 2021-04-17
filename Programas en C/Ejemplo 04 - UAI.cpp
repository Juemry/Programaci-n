#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	int i, sdo, total, emp;
	total = 0;
	system ("cls");
	
	printf("Ingrese el numero de empleado \n");
	scanf("%d", &emp);
		while (emp !=0)
		{
			printf("Ingrese el sueldo del empleado %d \n", emp);
			scanf("%d", &sdo); //con el & permite guardar el valor en esa variable sdo
			total = total + sdo;
			printf("Ingrese el numero de empleado \n");
			scanf("%d", &emp);
		}
	printf("El total de los sueldos pagados es de %d\n", total);
	
	system ("Pause");
	return 0;
}
