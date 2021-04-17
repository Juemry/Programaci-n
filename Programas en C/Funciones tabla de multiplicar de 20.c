#include <stdio.h> 

void multiplicaciones (int num);

int main () {
	
	int num=0;
	
	printf("Coloque un numero del que desea saber los primeros 20 multiplos. Coloque 0 para salir.\n");
	scanf("%i", &num);
	
	while (num!=0) {
	multiplicaciones (num);
	
	printf("Coloque un numero del que desea saber los primeros 20 multiplos. Coloque 0 para salir.\n");
	scanf("%i", &num);
	} 
	
	return 0;
}

void multiplicaciones (int num) {
	
	int num1=0, num2=0, num3=0, num4=0, num5=0, num6=0, num7=0, num8=0, num9=0, num10=0, num11=0, num12=0, num13=0, num14=0, num15=0, num16=0, num17=0, num18=0, num19=0, num20=0;
	
	num1 = num * 1;
	printf("%i x 1 = %i\n", num, num1);
	
	num2 = num * 2;
	printf("%i x 2 = %i\n", num, num2);
	
	num3 = num * 3;
	printf("%i x 3 = %i\n", num, num3);
	
	num4 = num * 4;
	printf("%i x 4 = %i\n", num, num4);
	
	num5 = num * 5;
	printf("%i x 5 = %i\n", num, num5);
	
	num6 = num * 6;
	printf("%i x 6 = %i\n", num, num6);
	
	num7 = num * 7;
	printf("%i x 7 = %i\n", num, num7);
	
	num8 = num * 8;
	printf("%i x 8 = %i\n", num, num8);
	
	num9 = num * 9;
	printf("%i x 9 = %i\n", num, num9);
	
	num10 = num * 10;
	printf("%i x 10 = %i\n", num, num10);
	
	num11 = num * 11;
	printf("%i x 11 = %i\n", num, num11);
	
	num12 = num * 12;
	printf("%i x 12 = %i\n", num, num12);
	
	num13 = num * 13;
	printf("%i x 13 = %i\n", num, num13);
	
	num14 = num * 14;
	printf("%i x 14 = %i\n", num, num14);
	
	num15 = num * 15;
	printf("%i x 15 = %i\n", num, num15);
	
	num16 = num * 16;
	printf("%i x 16 = %i\n", num, num16);
	
	num17 = num * 17;
	printf("%i x 17 = %i\n", num, num17);
	
	num18 = num * 18;
	printf("%i x 18 = %i\n", num, num18);
	
	num19 = num * 19;
	printf("%i x 19 = %i\n", num, num19);
	
	num20 = num * 20;
	printf("%i x 20 = %i\n", num, num20);
	
}

