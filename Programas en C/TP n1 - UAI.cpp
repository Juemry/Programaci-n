#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	int nAlumnos; // declaracion de las variables nAlumnos para el número del alumno 
	float pAlumnos,pMax; // y pAlumnos para la variable promedio de alumnos y pMax para el promedio maximo
	nAlumnos = pAlumnos = pMax = 0 ;// colocacion del valor de las variables en 0 para evitar arrastre de errores
	char sAlumnos; // declaracion de la variable sAlumnos para identificar el sexo de los alumnos v = varon, m = mujer
	system ("cls"); //limpiar pantalla
	
	do
	{
		printf("Ingrese el numero de alumno por favor\n");
		scanf("%d", &nAlumnos);
		
		/*printf("Ingrese si la persona es mujer (m) o varon (v)\n");
		scanf("%c", &sAlumnos);*/
		
		printf("Ingrese el promedio del alumno\n");
		scanf("%f", &pAlumnos);
		if (pMax<pAlumnos) 
		{
			pMax = pAlumnos;
		}	
		
	} while (nAlumnos!=0 && nAlumnos<3);
	
	/*printf("La cantidad de alumnas mujeres es de %c \n", sAlumnos);
	printf("La cantidad de alumnos varones es de %c \n", sAlumnos);*/
	printf("El promedio mas alto es de %.2f \n", pMax);
	
	system ("Pause");
	return 0;
}
