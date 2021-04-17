#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
int cEmpleados,nEmpleado,cat,vh,ch,sdo,tsdo; 
	cEmpleados=nEmpleado=cat=vh=ch=sdo=tsdo=0; 
	
	printf("Ingrese la cantidad de empleados por favor\n");
	scanf("%d", &cEmpleados);
	
	do
	{
		printf("Ingrese el numero del empleado \n");
		scanf("%d", &nEmpleado);
		
		printf("Ingrese la categoria del empleado (1 o 2)\n");
		scanf("%d", &cat);
		
		if (cat==1)
		{
		vh=150;
		}
		else if(cat==2)
		{
		vh=100;
		} 
		else 
		{
		printf("El valor ingresado es incorrecto\n");
		break;
		}
				
		printf("Ingrese la cantidad de horas trabajadas por el empleado\n");
		scanf("%d", &ch);
		
		sdo=ch*vh;
		tsdo=tsdo + sdo;
		
		printf("El sueldo del empleado %d es de %d \n", nEmpleado, sdo);
	
	} while (cEmpleados!=0 && nEmpleado<cEmpleados);
	
	
	printf("El total de sueldos es de %d \n", tsdo);
	
	system ("Pause");
	return 0;
}
