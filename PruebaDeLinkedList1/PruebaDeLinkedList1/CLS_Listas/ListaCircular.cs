using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeLinkedList1.CLS_Listas
{
    public class ListaCircular<T>
    {
        //Apuntadores
        public Foto<T> Primero { get; set; }
        public Foto<T> Ultimo { get; set; }

        //Propiedades
        protected int ContLCL { get; set; }

        public int TipoDeLista = 2;

        //Constructor
        public ListaCircular()
        {
            Primero = null;
            Ultimo = null;
        }

        //Metodos

        //Metodo para agregar nodos al final de la lista
        public void Agregar(Foto<T> NewNodo)
        {
            if (Primero == null) //Lista vacía
            {
                Primero = NewNodo;
                Ultimo = Primero;
                Primero.Siguiente = Primero;
                
            }
            else //Se añade un nuevo nodo delpues del ultimo
            {
                Ultimo.Siguiente = NewNodo;
                NewNodo.Siguiente = Primero;
                Ultimo = NewNodo;
            }
        }

        public void Eliminar1() 
        {
            //Se asegura de que no esté vacía
            if (Primero == null || ContLCL == 0)
            {
                return;
            }
            //Se elimina todo vinvulo del primero nodo con los demás elementos de la lista
            Primero = Primero.Siguiente;
            //Se disminuye el contador
            ContLCL--;
        }

        public void Eliminar(Foto<string> DelNodo)
        {
            //Lista vacía
            if (Primero == null || ContLCL == 0)
            {
                return;
            }

            //Se elimina al primero si se cumple la condición
            if (Primero.ID == DelNodo.ID)
            {
                Eliminar1();
            }

            //Si no entra en ninguna de estas dos categorías se tiene que hacer la
            ////transversa de la lista
            Foto<T> anterior = Primero;
            Foto<T> Actual = Primero.Siguiente;

            //Se elimina el último
            if (Ultimo.ID == DelNodo.ID)
            {
                anterior.Siguiente = Primero;
                Ultimo = anterior;
            }

            while (Actual != null && Actual.ID != DelNodo.ID)
            {
                //Va avanzado por la ista hasta que se acabe y llegue a null o hasta que 
                //encuentre la id a eliminar
                anterior = Actual;
                Actual = anterior.Siguiente;
            }

            if (Actual != null)
            {
                //Se eliminan los vinculos del nodo con los demás nodos de la lista
                anterior.Siguiente = Actual.Siguiente;
                //Se disminuye el contador
                ContLCL--;
            }
        }
    }
}
