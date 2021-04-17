#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

float precio, total; //variables declaradas antes del main, son de tipo globales
int cantidad;
float calcularIVA (int cantidad, float precio);

int main () {
	system ("cls");
	
	printf ("Ingrese las unidades del articulo requerido \n");
	scanf ("%d", &cantidad);
	printf ("Ingrese el precio unitario del articulo requerido \n");
	scanf ("%f", &precio);
	total = calcularIVA (cantidad, precio);
	printf("El importe total es de %.2f con IVA incluido \n", total);
		
	system ("Pause");
	return 0;
}

float calcularIVA (int cantidad, float precio)
{
	float resultado;
	resultado = precio * cantidad;
	return (resultado * 1.21);
}
