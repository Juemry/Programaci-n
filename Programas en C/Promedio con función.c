#include <stdio.h> 

int calculo (int n1, int n2); 

int main () {
		
	int n1,n2;
	
	printf("Digite dos numeros para sacar su promedio: \n");
	scanf("%i" "%i", &n1, &n2);
	
	printf("El promedio de los dos numeros ingresados es %i \n", calculo (n1,n2));
	
	return 0;
}

int calculo (int n1, int n2) {

	int promedio=0; //varible local
	promedio = (n1+n2)/2;
	return promedio; //no se como funciona, pero da el resultado correcto con y sin esta linea, tendré que averiguar bien
	// lo que entiendo es que hay que hacer el prototipo, hay que invocarla en la función main o principal, pero el tema de las variables
	// y los datos de variables entre funciones, me confunden un poco, también como es el tema de lo que devuelve o no, el orden
	//de ejecución y la pelotudez del "%"i para las variables
	
}
