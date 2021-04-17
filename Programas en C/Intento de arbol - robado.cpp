#include<stdio.h>

int main(){
 
 printf("\tBienvenidos al arbolito\n\n");
 printf("Digite el numero de niveles: ");
 int n,i,j,k;//contadores:i,j 
 scanf("%i",&n);
 k=1; //fue para entender el codigo
  
 for(i=1;i<=n;i++){
  for(j=1;j<=n-i;j++){
   printf("%i",k); //agregue la variable k
   k++; //lo que hace el codigo es hacer 3 ciclos, un gran ciclo
  }// y dos pequeños ciclos, en el primero imprime espacios en blanco
  //uno atras del otro, iguales al numero de filas menos 1, aca se termina el segundo ciclo
  //en ese lugar menos 1 se coloca el asterisco que conforma el arbolito
  //y en ese lugar se coloca un numero ascendente 1,3,5 de a dos desde el 1
  //que van a formar el arbolito, aca se termina el tercer ciclo
  //despues se hace el salto de linea y se termina el primer gran ciclo
  for(j=1;j<=2*i-1;j++){
   printf("*");
  }
 printf("\n"); 
 }
return 0; 
}
