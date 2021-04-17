#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	int n1, fac, car, sed, tur, cm, insc, vf [7];
	
	for (int i=1;i<=6;i++)
	{
	vf [i] = 0;
	}
	
	int min, aux, i, k;
	min=vf [1];
	aux=1;
	
	printf ("Ingrese el numero de legajo \n");
	scanf("%d", &n1);
	
	while(n1!=0)
	{
	printf("En que facultad se quiere inscribir \n");
	scanf("%d", &fac);
	
	vf[fac] = vf [fac]+1;
	
	printf ("Ingrese el numero de legajo \n");
	scanf("%d", &n1);
	} 
	
	for (k=2;k<=6;k++);
	{
	if (vf[k]<min)
			{
			min = vf [k];
			aux = k;
			}	
	}
	
	for (i=aux;i<=6;i++)
	{
	if (vf [i]==min)
			{
			printf("\nLa facultad donde se inscribieron menor cantidad de alumnos es la %d con %d inscriptos\n",i,vf[i]);
			}
	}
	
	system ("Pause");
	return 0;
}
