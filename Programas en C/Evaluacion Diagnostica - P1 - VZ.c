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
    int Modelo;
    int i,j;
    int CantAutosPedida=0;
    int ModAFabricar=0;
    int CantPiezasAUtilizar=0;
    int MatrizComp[20][100]={{0},{0}};
    int StockModelo=0;
    int VectorStockInicialModelo[20]={0};
    int VectorStockFinalModelo[20]={0};
    int VectorStockInicialPieza[100]={0};
    int VectorStockFinalPieza[100]={0};
    int StockPieza=0;
    int Pieza;
    int NumPieza[100];
    int CantPosibledeAutosAFabricar=0;
    int Min=0;
    int X=0;
    int VectorPosibleCompraPieza[100]={0};
    int AComprar=0;
    int AFabricar=0;
    int ADeuda=0;
    int Sucursal;
    int MatrizPedidoXSucursal[20][2];
    
//Lote 1
    printf("Ingrese el modelo de auto a fabricar, del 1 al 20, por favor. Ingrese 0 (cero) para salir \n");
    scanf("%i", &Modelo);
    
    while(Modelo!=0){
        printf("Ingrese la cantidad de autos pedida \n");
        scanf("%i",&CantAutosPedida);
        
            printf("Ingrese el numero de pieza a utilizar: \n");
            scanf("%i", &NumPieza);
        
        while(NumPieza!=s){     //Para fabricar 1 auto
       
            j=NumPieza;
        
        printf("Ingrese la cantidad de piezas a utilizar: \n");
        scanf("%i",&Pieza);
            Pieza=j;
                
        for(i=0; i<=20; i++){
            for(j=0; j<=100; j++){
                MatrizComp[Modelo][Pieza];
            }
        }
        printf("Ingrese el numero de pieza a utilizar, presione 0 para salir: \n");
        scanf("%i", &NumPieza);   
    }
    //Fin Mientras
//Lote 2
        printf("Ingresar el stock del modelo a fabricar\n");
        scanf("%i", &StockModelo);
    
    for(i=0; i<20; i++){
        VectorStockInicialModelo[Modelo]=StockModelo;
        VectorStockFinalModelo[Modelo]=StockModelo;
    }
    
//Lote 3
    printf("Ingresar el stock de la pieza a utilizar\n");
    scanf("%i",&StockPieza);
    
    for(i=0; i<100; i++){
        VectorStockInicialPieza[Pieza] = StockPieza;
        VectorStockFinalPieza[Pieza] = StockPieza;
    }    
        if(CantAutosPedida <= VectorStockInicialModelo[Modelo]){
            VectorStockFinalModelo[Modelo] = VectorStockFinalModelo[Modelo] - CantAutosPedida;
            AFabricar = 0;
            ADeuda = 0;
        }
        else{
            CantPosibledeAutosAFabricar = CantAutosPedida - VectorStockFinalModelo[Modelo];
            VectorStockFinalModelo[Modelo] = 0;
            Min=CantPosibledeAutosAFabricar;
                if(MatrizComp[Modelo][Pieza] !=0 ){
                    X = (VectorStockFinalPieza[i] / MatrizComp[i][j]);
                        if(X < Min){
                            Min = X;
                        }
            VectorStockFinalPieza[Pieza];
                }
            AFabricar = X;
            ADeuda = CantPosibledeAutosAFabricar - AFabricar;
            
            for(i=0; i<100; i++){
                VectorStockFinalPieza[Pieza] = VectorStockFinalPieza[Pieza]-(AFabricar * MatrizComp[Modelo][Pieza]);
                VectorPosibleCompraPieza[Pieza] = VectorPosibleCompraPieza[Pieza]+(ADeuda * MatrizComp[Modelo][Pieza]);
                
            }
        } 
        
    printf("Ingrese el modelo de auto a fabricar, del 1 al 20, por favor. Ingrese 0 (cero) para salir \n");
    scanf("%i", &Modelo);  
    }
//Fin Mientras
    
    for(i=0; i<100; i++){
        if(VectorPosibleCompraPieza[Pieza] > VectorStockFinalPieza[Pieza]){
            AComprar = VectorPosibleCompraPieza[Pieza] - VectorStockFinalPieza[Pieza];
        }
        else{
            AComprar = 0;
        }
    printf("\t -Modelo: %i \n-Stock Inicial: %i \n-Cantidad Pedida: %i \n-Stock Final: %i \n-A Fabricar: %i \n-A deuda: %i \n", Modelo+1, VectorStockInicialModelo[i], CantAutosPedida, VectorStockFinalModelo[i]+1, AFabricar, ADeuda);
    printf("\n");
    printf("\t -Pieza: %i \n- Stock inicial: %i \n- Stock final: %i \n- A comprar: %i \n", Pieza, VectorStockInicialPieza[i], VectorStockFinalPieza[i], AComprar);
    printf("\n");
    }
    
    return 0;
}



