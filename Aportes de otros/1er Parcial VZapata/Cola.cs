using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    class Cola
    {
        Alumno _inicio; //Comienza aca, variable privada
        int cantMaxima;
        int cantActual;

        public Cola(int Cantidad)
        {
            cantMaxima = Cantidad;
            cantActual = 0;
            _inicio = null;
        }

        public bool Llena()
            
        {
            return cantMaxima == cantActual;
        }

        public void Encolar(Alumno unNodo)//agrega al final
        {
            if (_inicio == null)
            {
                _inicio = unNodo;
                cantActual++;
            }
            else
            {
                if (!Llena())
                {
                    Alumno auxiliar = BuscarUltimo(_inicio);
                    auxiliar.Siguiente = unNodo;
                }
                else
                {
                    MessageBox.Show("No se pueden agragar más alumnos");
                }
            }
        }

        private Alumno BuscarUltimo(Alumno unNodo) //fc recursiva para que nos devuelva el ultimo nodo
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }

        public void Desencolar() //quita del principio
        {
            if (_inicio != null)
            {
                _inicio = _inicio.Siguiente; //queda el siguiente como inicio
                cantActual--;
            }
        }
       
        public Alumno Inicio //Propiedad de la cola que devuelva el inicio
        {
            get //propiedad de solo lectura
            {
                return _inicio;
            }
        }

        public bool Vacia()
        {
            return (_inicio == null);
        }
    }
}
