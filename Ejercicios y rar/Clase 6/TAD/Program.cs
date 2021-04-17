using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Listas.Model.TDA;
using Listas.Model;

namespace TAD
{
    class Program
    {     
        static void Main(string[] args)
        {
            Lista listaPacientes = new Lista();
            Paciente paciente1 = new Paciente(37);
            paciente1.Nombre = "Lucía";
            listaPacientes.AgregarAlComienzo(paciente1);

            Paciente paciente2 = new Paciente();
            paciente2.Nombre = "Martín";
            listaPacientes.AgregarAlComienzo(paciente2);

            Paciente paciente3 = new Paciente();
            paciente3.Nombre = "Jorge";
            listaPacientes.AgregarAlComienzo(paciente3);

            listaPacientes.Recorrer();

            Paciente paciente4 = new Paciente();
            paciente4.Nombre = "Gastón";
            listaPacientes.AgregarAlFinal(paciente4);


            Paciente pacienteUltimo =  listaPacientes.QuitarAlFinal();

            Paciente pacienteObtenidoPorPeek = listaPacientes.PeekComienzo();
            Console.WriteLine(pacienteObtenidoPorPeek.Nombre);
            pacienteObtenidoPorPeek = listaPacientes.PeekComienzo();
            Console.WriteLine(pacienteObtenidoPorPeek.Nombre);
            pacienteObtenidoPorPeek = listaPacientes.PeekComienzo();
            Console.WriteLine(pacienteObtenidoPorPeek.Nombre);


            //Console.WriteLine($"Paciente quitado { pacienteLucia.Nombre}, temperatura: { pacienteLucia.Temperatura}");

            listaPacientes.Recorrer();
            listaPacientes.QuitarAlComienzo();
            listaPacientes.Recorrer();
            listaPacientes.QuitarAlComienzo();
            listaPacientes.Recorrer();


            //NodosDesdeMain();
            //ValueReferenceType();
        }

        private static void NodosDesdeMain()
        {
            /*Paciente paciente1 = new Paciente(37);
            paciente1.Nombre = "Lucía";

            Paciente paciente2 = new Paciente();
            paciente2.Nombre = "Martín";
            Nodo nodoPaciente2 = new Nodo(paciente2);

            Paciente paciente3 = new Paciente();
            paciente3.Nombre = "Jorge";
            Nodo nodoPaciente3 = new Nodo(paciente3);

            //Simulación del armado de una lista enlazada simple
            Nodo nodoInicial = new Nodo(paciente1);
            nodoInicial.Siguiente = nodoPaciente2;
            nodoPaciente2.Siguiente = nodoPaciente3;

            while (nodoInicial.Siguiente != null)
            {
                Console.WriteLine("Paciente " + nodoInicial.Paciente.Nombre);
                nodoInicial = nodoInicial.Siguiente;
            }
            Console.WriteLine("Último paciente: " + nodoInicial.Paciente.Nombre);*/
        }

        private static void ValueReferenceType()
        {
            Paciente pacienteMatias = new Paciente(); //Reference Type
            pacienteMatias.Nombre = "Matias";
            pacienteMatias.Temperatura = 38;

            Medico medicoJorge = new Medico();
            medicoJorge.FechaNacimiento = new DateTime(1960, 8, 8);
            medicoJorge.Nombre = "Jorge";
            medicoJorge.Legajo = 1111;
            int sala = 100; //Value Type

            medicoJorge.Curar(pacienteMatias, sala);

            Console.WriteLine("El paciente Matias tiene " + pacienteMatias.Temperatura.ToString() + " y se atendió en la sala " + sala.ToString());
        }
    }
}
