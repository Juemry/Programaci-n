using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Cola
    {
        Nodo _inicio; //Comienza aca, variable privada
        public void Encolar(Nodo unNodo)//agrega al final
        {
            if (_inicio == null)
            {
                _inicio = unNodo;
            }
            else
            {
                Nodo auxiliar = BuscarUltimo(_inicio);
                auxiliar.Siguiente = unNodo;

            }

        }
        //public void EncolarSexo(Nodo unNodo)
        //{
        //    if (_inicio == null)
        //    {
        //        _inicio = unNodo;
        //    }
        //    else
        //    {
        //        Nodo auxiliar = BuscarUltimo(_inicio);
        //        auxiliar.Siguiente = unNodo;
        //    }
        //}


        private Nodo BuscarUltimo(Nodo unNodo) //fc recursiva para que nos devuelva el ultimo nodo
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
            _inicio = _inicio.Siguiente;//queda el siguiente como inicio

        }

        public Nodo Inicio //Propiedad de la cola que devuelva el inicio
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
