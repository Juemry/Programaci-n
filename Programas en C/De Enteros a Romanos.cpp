#include <stdio.h> 
#include <iostream>
#include <stdlib.h>

int main () {
	system ("cls");
	
	int num, uni, dec, cen, mil;
	
	printf("Digite un numero: ");
	scanf("%i",&num);
	
	uni = num%10; num=num/10;
	dec = num%10; num=num/10;
	cen = num%10; num=num/10;
	mil = num%10; num=num/10;
	
	switch (mil) {
		case 1: printf("M");break;
		case 2: printf("MM");break;
		case 3: printf("MMM");break;
	}
	
	switch (cen) {
		case 1: printf("C");break;
		case 2: printf("CC");break;
		case 3: printf("CCC");break;
		case 4: printf("CD");break;
		case 5: printf("D");break;
		case 6: printf("DC");break;
		case 7: printf("DCC");break;
		case 8: printf("DCCC");break;
		case 9: printf("CM");break;
	}
	
	switch (dec) {
		case 1: printf("X");break;
		case 2: printf("XX");break;
		case 3: printf("XXX");break;
		case 4: printf("XL");break;
		case 5: printf("L");break;
		case 6: printf("LX");break;
		case 7: printf("LXX");break;
		case 8: printf("LXXX");break;
		case 9: printf("XC");break;
	}
	
	switch (uni) {
		case 0: printf("\n");break;
		case 1: printf("I\n");break;
		case 2: printf("II\n");break;
		case 3: printf("III\n");break;
		case 4: printf("IV\n");break;
		case 5: printf("V\n");break;
		case 6: printf("VI\n");break;
		case 7: printf("VII\n");break;
		case 8: printf("VIII\n");break;
		case 9: printf("IX\n");break;
	}
	
	system ("Pause");
	return 0;
}
