using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeLinkedList1
{
    public class ListaSimplementeEnlazada<T>
    {
        //propiedades
        public Foto<T> Primero { get; set; }

        public Foto<T> Ultimo { get; set; }

        public int Cont { get; set;  }

        //Constructor
        public ListaSimplementeEnlazada(Foto<T> primero, Foto<T> ultimo)
        {
            Primero = null;
            Ultimo = null;
        }

        public ListaSimplementeEnlazada()
        {
        }

        //Métodos
        public void Agregar(Foto<T> NewNodo) 
        {
            if (Primero == null) 
            {
                //Si la lista es null está vacía y se agrega el primer dato
                Primero = NewNodo;
                Ultimo = NewNodo;
            }
            else 
            {
                Ultimo.Siguiente = NewNodo;
                Ultimo = NewNodo;
            }
            Cont++;
        }

        public void Eliminar1() 
        {
            if (Primero == null || Cont == 0) 
            {
                return;
            }
            Primero = Primero.Siguiente;
            Cont--;
        }

        public void Eliminar(Foto<T> DelNodo)
        {
            //Lista vacía
            if (Primero == null || Cont == 0)
            {
                return;
            }

            //Se elimina al primero
            if (Primero == DelNodo)
            {
                Eliminar1();
            }

            //Si no entra en ninguna de estas dos categorías se tiene que hacer la tramsversa de la lista
            Foto<T> anterior = Primero;
            Foto<T> Actual = Primero.Siguiente;

            while (Actual != null && Actual != DelNodo) 
            {
                anterior = Actual;
                Actual = anterior.Siguiente;
            }

            if (Actual != null) 
            {
                anterior.Siguiente = Actual.Siguiente;
                Cont--;
            }


        }
        public void MostrarFotos() 
        {
            
        }
    }
}
