#ifndef CLASE03_01_H
#define CLASE03_01_H

class clase03_01
{
	public:
	protected:
		
int nro1, nro2 = 0;
	
	printf("Ingrese un numero\n");
	
	scanf("%d",&nro1);
	
	printf("Ingrese un numero\n");
	
	scanf("%d",&nro2);	
		
	if(nro1 == nro2)
	{printf("Los numeros son iguales\n");
	} else
	{printf("Los numeros son distintos\n");
	}
	
	system ("pause");
	
	return 0;
	
};

#endif
