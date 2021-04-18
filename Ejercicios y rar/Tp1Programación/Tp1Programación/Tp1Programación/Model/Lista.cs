using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Programación.Model
{
    public class Lista
    {
        private Nodo Inicial;

        public Lista()
        {

        }

       //public void AgregarNodo(Alumno unNodo)
        //{
          // if (Inicio == null)
            //{
              //  Inicio = unNodo;
            //}
           // else
            //{
              //  Alumno aux = Inicio;
                //Inicio = unNodo;
                //Inicio.Siguiente = aux;
            //}
       // }
        public void AgregarUnNodo (Alumno nombre)
        {
            Nodo nodo = new Nodo(nombre);
            nodo.Siguiente = Inicial;
            Inicial = nodo;
            
        }
    }
}
