/******************************************************************************
Una fábrica de autos tiene los siguientes lotes de datos
Lote 1 composición del auto
• Modelo
• Pieza
• Cantidad a usar de esa pieza
Lote 2 stock de modelos terminados
• Modelo
• Stock
Lote 3 stock de piezas
• Pieza
• Stock
Lote 4 pedidos de las sucursales, finaliza con modelo = 0
• Modelo
• Cantidad pedida en total
La fábrica construye 20 modelos de auto, que utilizan entre sí 100 piezas distintas
Se desea saber:
•Modelo, Stock Inicial, Cantidad Pedida, Stock Final, a fabricar, a deuda
•Pieza, stock inicial, stock final, cantidad a comprar
*******************************************************************************/
#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <stdlib.h>

int main()
{
//Defino variables
	//variables iniciles para hacer las matrices del ejercicio
	int cantidadModelo=4;
	int cantidadPieza=4;
    int modelo=0;
    int pieza=0;
    int i=0;
	int j=0;
    //matriz componentes, que modelos de autos utilizan que componentes:
    int MC[cantidadModelo][cantidadPieza];
    //int piezasPorModelo=0;
    //stock inicial y final de modelos de autos:
    int VSIM[cantidadModelo];
    int stockModelo;
    int VSFM[cantidadModelo];
    //stock inicial y final de piezas de autos:
    int VSIP[cantidadPieza];
    int stockPieza;
    int VSFP[cantidadPieza];
    //cantidad de modelos pedidos
    int cantidadPedida=0;
    //detalles de lista //detalles listado 1
    int AFabricar=0;
    int ADeuda=0;
    //recorrido de piezas
    int x=0;
    int minimaCantidad=0;
    int cantidadAFabricar=0;
    //posible cantidad de piezas a comprar
    int VPCP[cantidadPieza];
    //impresion final de datos
    int aComprar[cantidadPieza];
    //auxiliares
    int carga=0;
    //inicio del programa
    printf("***Bienvenido al software de Fabrica de Autos***\n");
    /*
    printf("***Ingreso de cantidad de MODELOS y PIEZAS a trabajar***\n");
    while(carga!=1){
    printf("Por favor ingrese la cantidad de MODELOS con la que desea trabajar (se recomienda 4):\n");
    scanf("%i",&cantidadModelo);
    printf("Por favor ingrese la cantidad de PIEZAS con la que desea trabajar (se recomienda 4):\n");
    scanf("%i",&cantidadPieza);
    printf("Las cantidades seleccionadas son %i de modelos y %i de piezas", cantidadModelo,cantidadPieza);
    printf("\nSi la carga fue correcta ingrese el valor 1, si fue incorrecta ingrese el valor 0...\n");
    scanf("%i", &carga);
	}*/
    
//Lote 1 (de todo:modelo, piezas, stock)--> (i=1,20)(j=1,100) Matriz composici�n --> MC (Modelo, Parte) = Cantidad a Utilizar
	
	printf("***Ingreso de piezas por modelo***\n");
	
	while(carga!=2){
	for(i=0;i<cantidadModelo;i++){
		for (j=0; j<cantidadPieza;j++){
			printf("Cantidad de veces que la pieza %i es utilizada en el modelo numero %i :", j+1, i+1);
			scanf("%i", &MC[i][j]);
		}
		printf("\n");
	}

	//Impresi�n de la matriz resultante
		
	for(i=0;i<cantidadModelo;i++){
		printf("Composicion del modelo n%i :", i+1);
		for (j=0; j<cantidadPieza;j++){
			printf("* %i *", MC[i][j]);
		}
		printf("\n");
	}
	printf("\nSi la carga fue correcta ingrese el valor 2, si fue incorrecta ingrese el valor 0...\n");
	scanf("%i", &carga);
	}

	
//Lote 2 (modelo)--> (i=1,20) Vector Stock Inicial de Modelo --> VSIM (Stock) = Cantidad inicial de Stock de Modelos
//Ingreso de la cantidad de modelos en stock

	printf("***Ingreso de stock por modelo***\n");
	while(carga!=3){
	for(i=0;i<cantidadModelo;i++){
		printf("Stock del modelo n%i: ", i+1);
		scanf("%i", &VSIM[i]);
		//Lote 2 (modelo)--> (i=1,20) Vector Stock Final de Modelo --> VSFM (Stock) = Cantidad final de Stock de Modelos
		VSFM[i]=VSIM[i];
		printf("\n");
	}
	
		//Impresion para corroboracion
		
		
		printf("El stock por modelo es: \n");
		for(i=0;i<cantidadModelo;i++){
			printf("Stock del modelo n%i es de: %i\n", i+1, VSIM[i]);
		}
		
	printf("\n Si la carga fue correcta ingrese el valor 3, si fue incorrecta ingrese el valor 0...\n");
	scanf("%i", &carga);
	}


//Lote 3 (piezas)--> (i=1,100) Vector Stock Inicial de Piezas --> VSIP (Stock) = Cantidad inicial de Stock de Piezas
//Ingreso de la cantidad de piezas en stock

	printf("***Ingreso de stock por pieza***\n");
	while(carga!=4){
	for(i=0;i<cantidadPieza;i++){
		printf("\n Stock de la pieza n%i: ", i+1);
		scanf("%i", &VSIP[i]);
		//Lote 3 (piezas)--> (i=1,100) Vector Stock Final de Piezas --> VSFP (Stock) = Cantidad final de Stock de Piezas
		VSFP[i]=VSIP[i];
		printf("\n");
	}
	
		//Impresion para corroboracion
		
		{
		printf("El stock por pieza es: \n");
		for(i=0;i<cantidadPieza;i++){
			printf("\n Stock de la pieza n%i es de: %i ", i+1, VSIP[i]);
		}
		
	printf("\n Si la carga fue correcta ingrese el valor 4, si fue incorrecta ingrese el valor 0...\n");
	scanf("%i", &carga);
	}
	
//Lote 4 (vendido)--> Ciclo while, modelo!=0, ingreso el modelo y la cantidad pedida del modelo -->

//Proceso	
	printf("***Pedido de autos***\n");
    printf("Por favor ingrese el numero del modelo de auto que desea comprar. Para salir, ingrese 0 \n");
    scanf("%i",&modelo);

	while(modelo!=0){
    printf("Por favor ingrese la cantidad autos que desea comprar:\n");
    scanf("%i",&cantidadPedida);
    //Corroborar stock
	//Si la cantidad pedida es menor o igual que el vector final de modelos, resto la cantidad pedida al vector final y prosigo con el programa
	//AFabricar=0;Adeuda=0;VSFM(modelo)=VSFM(modelo)-CantidadPedida
    if(cantidadPedida<=VSFM[modelo]){
    	printf("Control stock antes del pedido %i, cantidad pedida %i:\n", VSFM[modelo], cantidadPedida);
    	VSFM[modelo]=VSFM[modelo]-cantidadPedida; 
    	printf("Control stock desp del pedido %i, cantidad pedida %i:\n", VSFM[modelo], cantidadPedida );
    	
    	//Impresion del primer listado
    	//Modelo, VSIM, CantidadPedida, VSFM, AFabricar, Adeuda
    	
    	printf("Del modelo numero %i, se pidieron % cantidad de autos, de los cuales habia un stock inicial de %, dejando un stock de %i, se deben fabricar %i y se adeudan %i", modelo+1, cantidadPedida, VSIM[modelo], VSFM[modelo], AFabricar, ADeuda);
	}

	
	//Primer listado
	//Modelo, VSIM, CantidadPedida, VSFM, AFabricar, Adeuda

	//Sino
			//Cantidad de Posible de Autos a Fabricar CPAF = CantidadPedida-VSFM(modelo)
			//VSFM(modelo)=0
			
			//Corroborar cantidad minima de piezas
					//Primero corroboro utilizaci�n de la pieza
					//Si MatrizComponentes MC(modelo,pieza)=!0 
						//x=VSFP(pieza)/MC(modelo,pieza)
						//x tiene que ser la menor posible, porque son autos enteros;
							//Si x<min
								//min=x
									//AFabricar=x
									//Adeuda= CantidadPedida-AFabricar
//Finaliza el proceso de control de piezas, es hora de descontar las piezas
//vuelvo sobre el stock de piezas					
//Ciclo--> (i=1,100)
//Verifico si se utiliza
//Si MatrizComposicion(modelo,pieza)=!0
	//Si se utiliza, resto:
	//VSFP(pieza)=VSFP(pieza)-(AFabricar * MC(modelo,pieza))
	//A la vez que descuento puedo ir en un vector auxiliar anotando las piezas que puede que tenga que comprar
	//Vector de Posibles Compras de Piezas VPCP(pieza)=VPCP(pieza)+(Adeuda* MC(modelo,pieza))

// Fin de while
	 else{
		
	}
    
    
    
    
    printf("***Pedido de autos***\n");
    printf("Por favor ingrese el numero del modelo de auto que desea comprar. Para salir, persione 0 \n");
    scanf("%i",&modelo);
	}


	
//Ahora finalizo, imprimiendo el listado 2
	//Ciclo--> (i=1,100)
	//Si VPCP(pieza)>VSFP(pieza)
		//PiezasAComprar(pieza)=VPCP(pieza)-VSFP(pieza)
	//Imprimir
	//pieza
	//VSIP(pieza)
	//VSFP(pieza)
	//PiezasAComprar(pieza)

}
return 0;
}






