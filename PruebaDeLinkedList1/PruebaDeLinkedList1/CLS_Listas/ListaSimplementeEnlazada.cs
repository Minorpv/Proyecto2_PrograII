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
        //Apuntadores
        public Foto<T> Primero { get; set; }

        public Foto<T> Ultimo { get; set; }

        //Propiedades
        public int ContLSM { get; set;  }

        public int TipoDeLista = 0;

        //Constructor
        public ListaSimplementeEnlazada()
        {
            Primero = null;
            Ultimo = null;
        }

        //Métodos
        //Agregar nodos a la lista
        public void Agregar(Foto<T> NewNodo) 
        {
            if (Primero == null)
            {
                //Si la lista es null está vacía y se agrega el primer dato
                Primero = NewNodo;
                Ultimo = NewNodo;
                Ultimo.Siguiente = null;
            }
            else
            {
                Ultimo.Siguiente = NewNodo;
                Ultimo = NewNodo;
                Ultimo.Siguiente = null;
            }
            ContLSM++;
        }

        //Eliminar el primer nodo de la lista
        public void Eliminar1() 
        {
            //Se asegura de que no sté vacía
            if (Primero == null || ContLSM == 0) 
            {
                return;
            }
            //Se elimina todo vinvulo del primero nodo con los demás elementos de la lista
            Primero = Primero.Siguiente;
            //Se disminuye el contador
            ContLSM--;
        }

        public void Eliminar(Foto<T> DelNodo)
        {
            //Lista vacía
            if (Primero == null || ContLSM == 0)
            {
                return;
            }

            //Se elimina al primero
            if (Primero.ID == DelNodo.ID)
            {
                Eliminar1();
            }

            //Si no entra en ninguna de estas dos categorías se tiene que hacer la tramsversa de la lista
            Foto<T> anterior = Primero;
            Foto<T> Actual = Primero.Siguiente;

            while (Actual != null && Actual.ID != DelNodo.ID)
            {
                anterior = Actual;
                Actual = anterior.Siguiente;
            }

            if (Actual != null)
            {
                anterior.Siguiente = Actual.Siguiente;
                ContLSM--;
            }
        }
    }
}
