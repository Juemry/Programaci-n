Algoritmo Sanatorios
	// Un sanatorio posee la atencion de 20 obras sociales o preagas en sus 50 consultorios externos de cada servicio.
	// Cuando un paciente se acerca a atenderse se registran los siguientes datos que finalizan con numero de atencion=0
	// Numero de atencion - NA,apellido y nombre del paciente  - apynom , servicio en el que se atendera - serv, obra social que presenta - os y valor de consulta - VC
	// Se desea saber:
	// 1) Monto total a cobrar a cada obra social
	// 2) Valor promedio de las consultas realizadas
	// 3) Que porcentaje resulta de la atencion de cada servicio sobre el total?
	// 4) De cual OS se atendio mas pacientes en total
	// 5) Ctas OS debe pagar mas de 100000 al sanatorio en total?
	
	//Datos de entrada...
	definir NA como entero
	definir apynom como entero
	definir serv como entero
	definir os Como Entero
	definir VC Como Entero
	definir monto Como Entero
	definir montototal Como Entero
	definir cantidadpacientesos1 Como Entero
	definir cantidadpacientesos2 Como Entero
	definir cantidadpacientesos3 Como Entero
	definir cantidadpacientesos4 Como Entero
	definir cienmil Como Entero
	cienmil <- 100000
	NA <- 0
	apynom <- 0
	serv <- 0
	os <- 0
	VC <- 0
	VC1 <- 0
	VC2 <- 0
	VC3 <- 0
	VC4 <- 0
	monto <- 0
	montototal <- 0
	
	//Datos del proceso...
	//1)
	definir montototalos1 como entero
	definir montototalos2 como entero
	definir montototalos3 como entero
	definir montototalos4 como entero
	totamontoos1 <- 0
	totamontoos2 <- 0
	totamontoos3 <- 0
	totamontoos4 <- 0
	//2)
	definir valorPromedio como entero
	valorPromedio <- 0
	//3)
	definir totalservicios como entero
	definir acumuladorservicio1,acumuladorservicio2,acumuladorservicio3,acumuladorservicio4 Como Entero
	acumuladorservicio1 <-0
	acumuladorservicio2<-0
	acumuladorservicio3 <-0
	acumuladorservicio4 <- 0
	definir porcentajeservicio1 Como Real
	definir porcentajeservicio2 Como Real
	definir porcentajeservicio3 Como Real
	definir porcentajeservicio4 Como Real
	totalservicios <- 0
	porcentajeserv1 <- 0
	porcentajeserv2 <- 0
	porcentajeserv3 <- 0
	porcentajeserv4 <- 0
	//4)
	//5)
	

	Escribir "Ingrese el numero de atencion. 0 para salir"
	Leer NA
	
	Mientras NA > 0 Hacer
		
		Escribir "Ingrese apellido y nombre del paciente ."
		Leer apynom
		Escribir "Ingrese servicio en que el paciente se atendera ."
		Leer serv
		Escribir "obra social."
		Leer os	
		
		Segun os Hacer
			1:  
				Escribir "Ingrese el valor de la consutla"
				Leer VC
				monto <- VC 
				cantidadpacientesos1 <- cantidadpacientes1 + 1
				totamontoos1 <- totamontoos1 + monto	
				
			2:
				monto <- VC
				cantidadpacientesos2 <- cantidadpacientes2 + 1
				totamontoos2 <- totamontoos2 + monto		
				
				
			3:
				monto <- VC
				cantidadpacientesosos3 <- cantidadpacientes3 + 1
				totamontoos3 <- totamontoos3 + monto
				
			4:
				monto <- VC
				cantidadpacientesos4 <- cantidadpacientes4 + 1
				totamontoos4 <- totamontoos4 + monto
				
				
				De Otro Modo:
				Escribir "Categoría inválida. Vuelva a ingresar"
		Fin Segun
		
		
		Escribir "Ingrese el numero de atencion. 0 para salir"
		Leer NA		
		
	Fin Mientras
	
	Si (cantidadpacientesos1 > cantidadpacientesos2) Y (cantidadpacientesos1 > cantidadpacientesos3) Y (cantidadpacientesos1 > cantidadpacientesos4) 
		Imprimir "La obra social que 1 atendio mas pacientes"
	FinSi
	Si (cantidadpacientesos2 > cantidadpacientesos1) Y (cantidadpacientesos2 > cantidadpacientesos3) Y (cantidadpacientesos2 > cantidadpacientesos4) 
		Imprimir "La obra social que 2 atendio mas pacientes"
	FinSi
	Si (cantidadpacientesos3 > cantidadpacientesos1) Y (cantidadpacientesos3 > cantidadpacientesos2) Y (cantidadpacientesos3 > cantidadpacientesos4) 
		Imprimir "La obra social que 3 atendio mas pacientes"
	FinSi
	Si (cantidadpacientesos4 > cantidadpacientesos1) Y (cantidadpacientesos4 > cantidadpacientesos2) Y (cantidadpacientesos4 > cantidadpacientesos3) 
		Imprimir "La obra social que 4 atendio mas pacientes"
	FinSi
	
	Si totamontoos1 >cienmil Entonces
		Imprimir "La obra social 1 debe abonar mas de  100000"
	SiNo
		Imprimir "La obra social 1 debe abonar mas de  100000"
	Fin Si
	
	totalvc <- totalmontoos1 + totalmontoos2 + totalmontoos3 + totalmontoos4;
	totalpacientes <-cantidadpacientesos1+cantidadpacientesos2+cantidadpacientesos3+cantidadpacientesos4; 
	valorpromedio <- (totalvc)/totalpacientes;
	
	totalservicios <- cantidadpacientesos1+cantidadpacientesos2+cantidadpacientesos3+cantidadpacientesos4
	acumuladorservicio1 <- serv1+1
	acumuladorservicio2 <- serv2+1
	acumuladorservicio3 <- serv3+1
	acumuladorservicio4 <- serv4+1
	porcentajeservicio1 <- (100*cantidadpacientesos1)/totalservicios
	porcentajeservicio2 <- (100*cantidadpacientesos2)/totalservicios
	porcentajeservicio3 <- (100*cantidadpacientesos3)/totalservicios
	porcentajeservicio4 <- (100*cantidadpacientesos4)/totalservicios
	
	Imprimir "El monto total a cobrar de os1 es de" totamontoos1
	Imprimir "El monto total a cobrar de os2 es de" totamontoos2
	Imprimir "El monto total a cobrar de os3 es de" totamontoos3
	Imprimir"El monto total a cobrar de os4 es de" totamontoos4
	Imprimir"El valor promedio de las consultas es de" valorpromedio
	Imprimir "El porcentaje de la atencion del servicio 1 sobre el total es de" porcentajeservicio1
	Imprimir "El porcentaje de la atencion del servicio 2 sobre el total es de" porcentajeservicio2
	Imprimir "El porcentaje de la atencion del servicio 3 sobre el total es de" porcentajeservicio3
	Imprimir "El porcentaje de la atencion del servicio 4 sobre el total es de" porcentajeservicio4
	Imprimir 'La os que debe pagar mas de 100000 al sanatorio en total la obra social '
	
		
FinAlgoritmo
