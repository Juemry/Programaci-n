#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	int emp, cat, c1, c2, c3, c4;
	c1 = c2 = c3 = c4 = emp = cat = 0;
	system ("cls");
	
	printf("Ingrese el numero del empleado \n");
	scanf("%d", &emp);
	while (emp != 0)
	{
		printf("Ingrese la catergoria del empleado %d (categoria 1,2,3 o 4) \n", emp);
		scanf ("%d", &cat);
		switch (cat)
		{
			case 1:
			c1=c1+1;
			break;
			
			case 2:
			c2=c2+1;
			break;
			
			case 3:
			c3=c3+1;
			break;
			
			case 4:
			c4=c4+1;
			break;
			
			default:
			printf("La categoria ingresada es incorrecta");
		}
	printf("Ingrese el numero del empleado \n");
	scanf("%d", &emp);
	}
	
	printf("El total de empleados de la categoria 1 es %d \n", c1);
	printf("El total de empleados de la categoria 2 es %d \n", c2);
	printf("El total de empleados de la categoria 3 es %d \n", c3);
	printf("El total de empleados de la categoria 4 es %d \n", c4);
	
	system ("Pause");
	return 0;
}
