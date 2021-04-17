#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	int v1,v2,r;
	system ("cls");
	
	printf("Ingrese el primer valor\n");
	scanf("%d",&v1);
	printf("Ingrese el segundo valor\n");
	scanf("%d",&v2);
		
		if (v1==v2) /*no lleva punto y coma, su contenido va entre llaves, igual que el main*/
		{
		r = v1 + v2;
		printf ("Los numeros son iguales y su suma es de %d\n",r);
		
		} 
		else 
		{
		r=v1*v2;
		printf("Los numeros son distintos y su multiplicacion es de %d\n",r);
		}
	
	system ("Pause");
	return 0;
}
