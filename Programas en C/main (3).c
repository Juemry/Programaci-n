

#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <stdlib.h>

void ingresopedido();
void cantpedidosporemp();
void lamparaMasSolicitada();
void PedidosSinSatisfacer();
void ValorDelPedidoSatisfecho();

//Si funciona para 4 articulos y 3 empleados, funciona
int nlampara;
int preciolamp1=100;
int preciolamp2=50;
int preciolamp3=75;
int preciolamp4=20;
int precio=0;
int stock1=60;
int stock2=20;
int stock3=15;
int stock4=50;
int nempleado;
int comision=0.05;
int cant=0;
int treslamp1=0;int treslamp2=0;int treslamp3=0;int treslamp4=0;
int unolamp1=0; int unolamp2=0; int unolamp3=0; int unolamp4=0;
int doslamp1=0; int doslamp2=0; int doslamp3=0; int doslamp4=0;

int modeloLampara [4]={0};
int cantidadLampara[4]={0};
int stock[4]={0};
int numEmpleado [3]={0};
int matrizVentas [3][4]={0}{0};

int main()
{
    ingresopedido();
    
    cantpedidosporemp();
    
    lamparaMasSolicitada();
    
return 0;
}

void ingresopedido()
{
    int npedido;
    int ncliente;
    int i=0;
    //int j=0;
    
    //Se pide el ingreso del stock inicial
    printf ("Ingrese el stock de los modelos de lamparas: \n");
    for (i=0;i<4;i++){
    	printf ("Stock para el modelo de lampara numero %i: \n", i+1);
		scanf("%i", &stock[i]);
	}
    	
    //Se imprime la matriz resultante de stock original
			printf( "Stock resultante: \n");
			for( i=0; i<4; i++ ){
			 		printf( "Stock de lampara n� %i: %i ",i+1, stock[i]);
				printf( "\n");
			}
    
    printf ("Ingrese el numero de pedido. Ingrese 0 (cero) para salir \n");
        scanf("%i", &npedido);
        
    while (npedido!=0){
        printf ("\nIngrese el numero de cliente \n");
            scanf ("%i", &ncliente);
        printf ("\nIngrese el numero de articulo de la lampara \n ");
            scanf ("%i", &modeloLampara[4]);
        printf ("\nIngrese la cantidad pedida\n");
            scanf ("%i", &cantidadLampara[4]);
            
            PedidosSinSatisfacer();
            
            ValorDelPedidoSatisfecho();
            
        printf ("\nIngrese el numero de empleado que despacho el pedido\n");
            scanf("%i", &nempleado);
    
        
    printf ("\nIngrese el numero de pedido. Ingrese 0 (cero) para salir \n");
        scanf("%i", &npedido);
    }
    printf ("Fin del pedido\n");
}

void cantpedidosporemp()
{   
    int emp_3=0;
    int emp_1=0;
    int emp_2=0;
    
    
    switch(nempleado)
    {
        case 1: emp_1++;
                switch(nlampara)
                {
                    case 1:
                    unolamp1++; break;
                    case 2:
                    unolamp2++; break;
                    case 3:
                    unolamp3++; break;
                    case 4:
                    unolamp4++; break;
                }
        break;        
        case 2: emp_2++;
                switch(nlampara)
                {
                    case 1:
                    doslamp1++; break;
                    case 2:
                    doslamp2++; break;
                    case 3:
                    doslamp3++; break;
                    case 4:
                    doslamp4++; break;
                }
        break;        
        case 3: emp_3++;
                switch(nlampara)
                {
                    case 1:
                    treslamp1++; break;
                    case 2:
                    treslamp2++; break;
                    case 3:
                    treslamp3++; break;
                    case 4:
                    treslamp4++; break;
                }
        break;
    } 
        printf ("\t El empleado 1 atendio\n %i pedidos del codigo 1 \n", unolamp1 );
        printf (" %i pedidos del codigo 2 \n", unolamp2 );
        printf (" %i pedidos del codigo 3 \n", unolamp3 );
        printf (" %i pedidos del codigo 4 \n", unolamp4 );
        
        printf ("\t El empleado 2 atendio\n %i pedidos del codigo 1 \n", doslamp1 );
        printf (" %i pedidos del codigo 2 \n", doslamp2 );
        printf (" %i pedidos del codigo 3 \n", doslamp3 );
        printf (" %i pedidos del codigo 4 \n", doslamp4 );
        
        printf ("\t El empleado 3 atendio\n %i pedidos del codigo 1 \n", doslamp1 );
        printf (" %i pedidos del codigo 2 \n", treslamp2 );
        printf (" %i pedidos del codigo 3 \n", treslamp3 );
        printf (" %i pedidos del codigo 4 \n", treslamp4 );
        
  }
  
void lamparaMasSolicitada()
{
    int lampara1=0;int lampara2=0; int lampara3=0; int lampara4=0;
    
    lampara1=treslamp1+unolamp1+doslamp1;
    lampara2=treslamp2+unolamp2+doslamp2;
    lampara3=treslamp3+unolamp3+doslamp3;
    lampara4=treslamp4+unolamp4+doslamp4;
    
    if (lampara1>lampara2 && lampara1>lampara3 && lampara1>lampara4){
        printf ("La lámpara del codigo 1 es la mas solicitada\n");}
    
    if (lampara2>lampara1 && lampara2>lampara3 && lampara2>lampara4){
        printf ("La lámpara del codigo 2 es la mas solicitada\n");}
    
    if (lampara3>lampara1 && lampara3>lampara2 && lampara3>lampara4){
        printf ("La lámpara del codigo 3 es la mas solicitada\n");}
        
    else{
        printf ("La lámpara del codigo 4 es la mas solicitada\n");
    }
}

void PedidosSinSatisfacer()
{   
    
    if (nlampara=1){
        if (stock1>=cant){
            stock1=stock1-cant;
        }
        else {
          printf ("El stock del codigo 1 es insuficiente para satisfacer el pedido, quedan %i lamparas\n", stock1);
        }
  }
    if (nlampara=2){
        if (stock2>=cant){
            stock2=stock2-cant;
            }
        printf ("Se puede satisfacer el pedido\n");
    }
        else {
          printf ("El stock del codigo 2 es insuficiente para satisfacer el pedido, quedan %i lamparas\n", stock2);
            }
  
    if (nlampara=3){
      if (stock3>=cant){
            stock3=stock3-cant;
      }
        printf ("Se puede satisfacer el pedido\n");
    }
        else {
          printf ("El stock del codigo 3 es insuficiente para satisfacer el pedido, quedan %i lamparas\n", stock3);
            }
    
    if (nlampara=4){
      if (stock4>=cant){
            stock4=stock4-cant;
      }
      printf ("Se puede satisfacer el pedido\n");
    }
      else {
          printf ("El stock del codigo 4 es insuficiente para satisfacer el pedido, quedan %i lamparas\n", stock4);
      }
  
}

void ValorDelPedidoSatisfecho()
{
  switch(nlampara)
  {
    case 1:
      precio=preciolamp1*cant; break;
    case 2:
      precio=preciolamp2*cant; break;
    case 3:
      precio=preciolamp3*cant; break;
    case 4:
      precio=preciolamp4*cant; break;
  }
  printf ("El valor del pedido satisfecho es de %i\n", precio);
}




