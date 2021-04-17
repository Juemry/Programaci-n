
/*Un sanatorio posee la atención de 4 obras sociales o prepagas en sus 4 consultorios esternos de cada servicio.
Cuando un paciente se acerca al servicio se registran los siguientes datos que finalizan con número de atención=0.

-Número de atención (NA)
-Apellido y nombre del paciente (apynom)
-Servicio al que se atenderá (serv)
-Obra social que representa (os)
-Valor de la consulta (vc)

Se desea saber:
1-Monto total a cobrar a cada os
2-Valor promedio total de las consultas realizadas
3-Que porcentaje resulta de la atención de cada servicio sobre el total
4-De cuál obra social se atendió más pacientes en total
5-Cuantas obras sociales deben pagar más de $1000000 al sanatorio en total*/


#include <stdio.h>

int main()
{
    //Variables que se ingresan
    int NA, afil, os,serv, cantserv1, cantserv2, cantserv3,cantserv4, os1,os2,os3,os4;
    float vc;
    NA=afil=serv=cantserv1=cantserv2=cantserv3=cantserv3=cantserv4= os= os1=os2=os3=os4=0;
    vc=0;
    
    //Variables de salida
	int cat, c1, c2, c3, c4,serv_t,Max;
	cat=c1=c2=c3=c4=serv_t=Max=0;
	
	float monto_os1, monto_os2, monto_os3, monto_os4, monto_t,valorpromtotconsultas,porc_serv1,porc_serv2,porc_serv3,porc_serv4;
	monto_os1=monto_os2=monto_os3=monto_os4=monto_t=valorpromtotconsultas=porc_serv1=porc_serv2=porc_serv3=porc_serv4=0;
	
	printf("Ingrese número de atención, para salir ingrese 0 (cero)\n");
	scanf("%d", &NA);
	
	while(NA>0)
	{
	    printf("Ingrese número de afiliado\n ");                 /*En lugar de apellido y nombre ingreso nro de afiliado*/
    	scanf("%d", &afil);
	
	    printf("Ingrese valor de la consulta\n ");
	    scanf("%f", &vc);
	    
	    monto_t=monto_t+vc;
	    
	    serv_t++;
	    
		printf("Ingrese el código de la obra social\n ");   /*Cuento para calcular el monto de cada una despues y la cantidad de pacientes de c/u*/
		scanf("%d", &os);
		switch(os)
		{
			case 1: os1=os1+1;
			        monto_os1=monto_os1+vc;
		        	break;
			case 2: os2=os2+1;
			        monto_os2=monto_os2+vc;
		        	break;
			case 3: os3=os3+1;
			        monto_os3=monto_os3+vc;
			        break;
			case 4: os4=os4+1;
			        monto_os4=monto_os4+vc;
			        break;
			
		}
		
		printf("Ingresar servicio que se atenderá\n ");     /*Cuento para calcular el porcentaje de cada servicio sobre el total*/
		scanf("%d", &serv);
		
		switch(serv)
		{
			case 1: cantserv1++;
			break;
			case 2: cantserv2++;
			break;
			case 3: cantserv3++;
			break;
			case 4: cantserv4++;
			break;
		}
		
		
					
	
			
		printf("Ingrese número de atención, para salir ingrese 0 (cero)\n");
	    scanf("%d", &NA);
	}    
	
	
	//1-Monto total a cobrar a cada os
	
	printf("El total a cobrar de la obra social 1 es %.2f \n", monto_os1);
	printf("El total a cobrar de la obra social 2 es %.2f \n", monto_os2);
	printf("El total a cobrar de la obra social 3 es %.2f \n", monto_os3);
	printf("El total a cobrar de la obra social 4 es %.2f \n", monto_os4);
	
	//2-Valor promedio total de las consultas realizadas
	       
	valorpromtotconsultas=monto_t/serv_t;    
	
	printf("El valor promedio total de las consultas realizadas es de %.2f \n", valorpromtotconsultas);
	
	//3-Qué porcentaje resulta de la atención de cada servicio sobre el total

	porc_serv1=cantserv1*100/serv_t;
	porc_serv2=cantserv2*100/serv_t;
	porc_serv3=cantserv3*100/serv_t;
	porc_serv4=cantserv4*100/serv_t;
		
		
	printf("El porcentaje de la atención del servicio 1 sobre el total es de %.2f \n", porc_serv1);
	printf("El porcentaje de la atención del servicio 2 sobre el total es de %.2f \n", porc_serv2);
	printf("El porcentaje de la atención del servicio 3 sobre el total es de %.2f \n", porc_serv3);
	printf("El porcentaje de la atención del servicio 4 sobre el total es de %.2f \n", porc_serv4);
	
	
	//5-Cuantas obras sociales deben pagar más de $100.000 al sanatorio en total
		if (monto_os1>100000)                            
			{
			printf("La obra social 1 debe pagar mas de $100.000\n");
			}
		if (monto_os2>100000)
				{
			printf ("La obra social 2 debe pagar mas de $100.000\n");
				}	
		if(monto_os3>100000)
			{
			printf ("La obra social 3 debe pagar mas de $100.000\n");
				}
		if(monto_os4>100000)
				{
			printf ("La obra social 4 debe pagar mas de $100.000\n");
				}
				
	//4-De cuál obra social se atendió más pacientes en total
	
	Max=os1;
		    if(os2>Max)
	    	{
		        Max=os2;
	    	}
			else if(os3>Max)
			{
				Max=os3;
			}
			else if (os4>Max)
			{
			    Max=os4;			
			}
			else
			{
			    Max=os1;
            }
	
	printf("Se atendieron mas pacientes de la obra social %i \n", Max);
	
		
	return 0;
    }





